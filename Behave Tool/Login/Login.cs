using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Net;
using System.Net.NetworkInformation;
using System.Threading;
using System.Windows.Forms;

namespace Behave_Tool
{
    public partial class Login : Form
    {
        public bool success;
        private static int attempts = 0;
        public static string loggedInAss;

        public Login()
        {
            InitializeComponent();

        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg != 132)
                return;
            m.Result = (IntPtr)2;
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
            Close();
        }

        private void err()
        {
            Thread.Sleep(3000);
            Error.Visible = false;
        }

        private void getServerStatus()
        {
            try
            {
                serverStatus.Text = "Checking Server...";
                if (new Ping().Send(IPAddress.Parse("31.170.162.63")).Status == IPStatus.Success)
                    this.serverStatus.Text = "Online";
                else
                    this.serverStatus.Text = "No Connection";
            }
            catch (Exception)
            { serverStatus.Text = "No Connection"; }
        }

        private void Log_In_Click(object sender, EventArgs e)
        {
            new Thread(new ThreadStart(login)) { IsBackground = true }.Start();
        }

        private void login()
        {

            if (saveLogIn.Checked == true)
            {
                Properties.Settings.Default["Sign_In"] = (UserName.Text + "," + PassWord.Text);
            }
            new Thread(new ThreadStart(startLoading))
            {
                IsBackground = true
            }.Start();

            attempts += 1;
            if (!this.loginSuccess())
            {
                                
                if (attempts <= 2)
                {
                    this.AttemptCount.Text = "Attempts left: " + (3 - attempts);
                    this.loading.Visible = false;
                    new Thread(new ThreadStart(this.stopLoading))
                    {
                        IsBackground = true
                    }.Start();
                }
                else
                {
                    MessageBox.Show("You have ran out of attempts!");
                    Program.failLogin = true;
                    this.Close();
                }
            }
            else
            {
                Program.failLogin = false;
                loggedInAss = UserName.Text;
                this.Close();
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.PassWord.PasswordChar = this.randChar();
            CheckForIllegalCrossThreadCalls = false;
            StartPosition = FormStartPosition.Manual;
            this.Location = new Point((Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2,
                          (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2);

            new Thread(new ThreadStart(setSave)) { IsBackground = true }.Start();
            new Thread(new ThreadStart(this.getServerStatus)) { IsBackground = true }.Start();
        }

        private bool loginSuccess()
        {
            //if (sqlConnect())
            if (UserName.Text == "admin" && PassWord.Text == "ddr3")
            {
                Properties.Settings.Default.Save();
                return true;
            }
            else
            {
                return false;
            }
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
            if (serverStatus.Text == "Online")
            {
                this.serverStatus.ForeColor = Color.Green;
                Thread.Sleep(20000);
                new Thread(new ThreadStart(getServerStatus)) { IsBackground = true }.Start();
            }
            else if (this.serverStatus.Text == "Checking Server...")
            {
                this.serverStatus.ForeColor = Color.Yellow;
            }
            else if (serverStatus.Text == "No Connection")
            {
                this.serverStatus.ForeColor = Color.Red;
                Thread.Sleep(20000);
                new Thread(new ThreadStart(getServerStatus)) { IsBackground = true }.Start();
            }
        }

        private bool sqlConnect()
        {
            bool success = false;
            SqlConnection connection = new SqlConnection("server=mysql2.gear.host;database=behave;user id=behave423;password=vYcB487Dd8eWZFGb^;Trusted_Connection=yes;connection timeout=10");
            try
            {
                connection.Open();
            }
            catch (Exception ex)
            {
                int num = (int)MessageBox.Show(ex.ToString());
            }
            if (connection != null && connection.State == ConnectionState.Closed)
            {
                success = false;
            }
            else
            {
                SqlDataReader sqlDataReader = new SqlCommand("SELECT * FROM users WHERE username='" + this.UserName.Text + "' AND password='" + this.PassWord.Text + "'", connection).ExecuteReader();
                while (sqlDataReader.Read())
                {
                    if (sqlDataReader.HasRows)
                    {
                        int num = (int)MessageBox.Show("Login Successfully Done");
                        success = true;
                    }
                }
                if (!sqlDataReader.HasRows)
                {
                    int num = (int)MessageBox.Show("Access Denied, password username mismatched");
                    success = false;
                }
                try
                {
                    connection.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }
            return success;
        }

        private void startLoading()
        {
            this.loading.Image = Properties.Resources.Loading_Gif;
        }

        private void stopLoading()
        {
            this.loading.BackgroundImage = null;
        }

        private void saveLogIn_CheckedChanged(object sender, EventArgs e)
        {
            if (saveLogIn.Checked)
            {
                Properties.Settings.Default.KeepWindowOnTop = true;
            }
            else
            {
                Properties.Settings.Default.KeepWindowOnTop = false;
            }
            Properties.Settings.Default.Save();
        }
    }
}