using System;
using System.Data;
using System.Drawing;
using System.Net.NetworkInformation;
using System.Threading;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Runtime.InteropServices;
using System.Text;

namespace MassRepo
{
    public partial class Login : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();


        public bool success;
        private static int attempts = 0;
        public static string loggedInAs;
        public string _version = System.Diagnostics.FileVersionInfo.GetVersionInfo(System.Reflection.Assembly.GetExecutingAssembly().Location).FileVersion;
        public Login()
        {
            InitializeComponent();
        }
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            // mouse in window or in Border and max, close & min buttons     
            if (m.Msg == 0xa0 || m.Msg == 0x200)
            {
                Activate();
            }
        }
        private void toolStrip1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void setSave()
        {
            if (Properties.Settings.Default.Sign_In != "%*#(@")
            {
                saveLogIn.Checked = true;
                string s = Properties.Settings.Default.Sign_In;
                string[] details = s.Split(',');
                UserName.Text = details[0];
                PassWord.Text = details[1];
            }
            else
            {
                saveLogIn.Checked = false;
            }
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Program.failLogin = true;
            Environment.Exit(0);
        }

        private void err()
        {
            Color oldColour = AttemptCount.ForeColor;
            Error.Show();
            AttemptCount.ForeColor = Color.Red;
            Thread.Sleep(3000);
            AttemptCount.ForeColor = oldColour;
            Error.Hide();
        }

        private void getServerStatus()
        {
            try
            {
                serverStatus.Text = "Checking Server...";
                if (new Ping().Send(("massrepo.com")).Status == IPStatus.Success)
                {
                    serverStatus.Text = "Domain Is Reachable";
                }
                else
                {
                    serverStatus.Text = "Cant Reach Domain";
                }
            }
            catch (Exception)
            { serverStatus.Text = "No Network Connection"; }
        }

        private void Log_In_Click(object sender, EventArgs e)
        {
            new Thread(new ThreadStart(login)) { IsBackground = true }.Start();
        }

        private void login()
        {
            attempts += 1;
            if (saveLogIn.Checked == true)
            {
                Properties.Settings.Default["Sign_In"] = (UserName.Text + "," + PassWord.Text);
            }

            if (!loginSuccess())
            {

                if (attempts <= 2)
                {
                    AttemptCount.Text = "Attempts left: " + (3 - attempts);
                    new Thread(new ThreadStart(err)) { IsBackground = true }.Start();
                }
                else
                {
                    MessageBox.Show("You have ran out of attempts!");
                    Program.failLogin = true;
                    Environment.Exit(0);

                }
            }
            else
            {
                Program.failLogin = false;
                loggedInAs = UserName.Text;
                Close();

            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

            //Icon = Properties.Resources.MassRepo_Icon;
            toolStrip1.Renderer = new MySR();
            version.Text = "Alpha: " + _version;
            Error.Hide();
            PassWord.PasswordChar = randChar();
            CheckForIllegalCrossThreadCalls = false;
            StartPosition = FormStartPosition.Manual;
            Location = new Point((Screen.PrimaryScreen.WorkingArea.Width - Width) / 2,
                          (Screen.PrimaryScreen.WorkingArea.Height - Height) / 2);

            new Thread(new ThreadStart(setSave)) { IsBackground = true }.Start();
            new Thread(new ThreadStart(getServerStatus)) { IsBackground = true }.Start();
        }

        private bool loginSuccess()
        {

            if (sqlConnect())
            {
                Properties.Settings.Default.Save();
                return true;
            }

            return false; // if failed

        }

        private void PassWord_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                login();
            }
        }

        private char randChar()
        {
            string[] strArray = new string[] { "≡", "☻", "£", "ƒ", "⌛", "◙", "§", "Θ", "✌" };
            return Convert.ToChar(strArray[new Random().Next(0, strArray.Length)]);
        }

        private void serverStatus_TextChanged(object sender, EventArgs e)
        {
            if (serverStatus.Text == "Domain Is Reachable")
            {
                serverStatus.ForeColor = Color.Green;
                Thread.Sleep(20000);
                new Thread(new ThreadStart(getServerStatus)) { IsBackground = true }.Start();
            }
            else if (serverStatus.Text == "Checking Server...")
            {
                serverStatus.ForeColor = Color.Yellow;
            }
            else
            {
                serverStatus.ForeColor = Color.Red;
                Thread.Sleep(5000);
                new Thread(new ThreadStart(getServerStatus)) { IsBackground = true }.Start();
            }
        }
        const string myConnectionString = "Server=massrepo.com;Database=massrepo;Uid=root;Pwd=9vXcr8epuswBjmLH";

        private bool sqlConnect()
        {

            string ip = Tools.Network.IPinfo.getPublicIP();
            using (var connection = new MySqlConnection(myConnectionString))
            using (MySqlCommand command = connection.CreateCommand())
            {
                try
                {
                    connection.Open();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                if (connection != null && connection.State == ConnectionState.Closed)
                {
                    return false;
                }
                else
                {
                    using (MySqlDataReader sqlDataReader = new MySqlCommand("SELECT id FROM users WHERE username='" + UserName.Text + "' AND password='" + encrypt(PassWord.Text) + "'", connection).ExecuteReader())
                    {
                        try
                        {
                            while (sqlDataReader.Read())
                            {

                                if (sqlDataReader.HasRows)
                                {
                                    string update = "UPDATE users SET ip='" + ip + "',lastLogin='" + DateTime.Now + "',logins= logins + 1, queries= queries + 1 WHERE username='" + UserName.Text + "' AND password= '" + encrypt(PassWord.Text) + "';";
                                    updateCommand(update);
                                    getFirstName();
                                    return true;
                                }


                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString());
                        }

                        string update1 = "UPDATE users SET ip='" + ip + "',lastLogin='" + DateTime.Now + "',badQueries= badQueries + 1 WHERE username='" + UserName.Text + "';";
                        updateCommand(update1);
                        return false;

                    }
                }
            }
        }
        private void updateCommand(string update)
        {
            try
            {
                using (MySqlConnection MyConn2 = new MySqlConnection(myConnectionString))
                {
                    MySqlCommand MyCommand2 = new MySqlCommand(update, MyConn2);
                    MySqlDataReader MyReader2;
                    MyConn2.Open();
                    MyReader2 = MyCommand2.ExecuteReader();

                    while (MyReader2.Read())
                    {
                        MyCommand2.ExecuteNonQuery();
                    }
                    //Connection closed here  
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public string displayCommand(string query, string cell)
        {
            try
            {
                using (MySqlConnection MyConn2 = new MySqlConnection(myConnectionString))
                {
                    MySqlCommand MyCommand2 = new MySqlCommand(query, MyConn2);
                    MySqlDataReader MyReader2;
                    MyConn2.Open();
                    using (MyReader2 = MyCommand2.ExecuteReader())
                    {
                        while (MyReader2.Read())
                        {
                            return MyReader2.GetString(MyReader2.GetOrdinal(cell));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }
        public static string firstName;
        public void getFirstName()
        {
            string query = "SELECT * FROM users WHERE username= '" + UserName.Text + "';";
            firstName = displayCommand(query, "firstname");
        }

        public string encrypt(string input)
        {
            // Use input string to calculate MD5 hash
            using (System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create())
            {
                byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                // Convert the byte array to hexadecimal string
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("X2"));
                }
                return sb.ToString();
            }
        }

        private void SignupBtn_Click(object sender, EventArgs e)
        {
            new Signup().ShowDialog();
        }
    }

}