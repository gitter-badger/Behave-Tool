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
        private static int attempts = 0;
        public bool success;
        private string user;
        private string pass;

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg != 132)
                return;
            m.Result = (IntPtr)2;
        }

        public Login()
        {
            InitializeComponent();
            this.PassWord.PasswordChar = this.randChar();
            CheckForIllegalCrossThreadCalls = false;
            StartPosition = FormStartPosition.Manual;
            this.Location = new Point((Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2,
                          (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2);

            new Thread(new ThreadStart(this.getServerStatus)) { IsBackground = true }.Start();
        }

        private char randChar()
        {
            string[] strArray = new string[] { "≡", "☻", "£", "ƒ", "⌛", "◙", "§", "Θ", "✌" };
            return Convert.ToChar(strArray[new Random().Next(0, strArray.Length)]);
        }

        private bool loginSuccess()
        {
            //if (sqlConnect())
            if (user == "admin" && pass == "ddr3")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void startLoading()
        {
            this.loading.BackgroundImage = Properties.Resources.Loading_Gif;
        }

        private void stopLoading()
        {
            this.loading.BackgroundImage = null;
        }

        private void login()
        {
            new Thread(new ThreadStart(this.startLoading))
            {
                IsBackground = true
            }.Start();
            this.user = this.UserName.Text;
            this.pass = this.PassWord.Text;
            attempts += 1;
            if (!this.loginSuccess())
            {
                this.Error.Visible = true;
                if (attempts <= 2)
                {
                    new Thread(new ThreadStart(this.err))
                    {
                        IsBackground = true
                    }.Start();
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
                this.Close();
            }
        }

        private void Log_In_Click(object sender, EventArgs e)
        {
            new Thread(new ThreadStart(login)) { IsBackground = true }.Start();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Program.failLogin = true;
            Close();
        }

        private void err()
        {
            Error.Visible = true;
            Thread.Sleep(3000);
            Error.Visible = false;
        }

        private void PassWord_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue != 13)
                return;
            this.login();
        }

        private bool sqlConnect()
        {
            bool success = false;
            SqlConnection connection = new SqlConnection("server=server9.000webhost.com;database=a6007078_behave;user id=a6007078_sqlcon;password=sd98sda7;Trusted_Connection=yes;connection timeout=10");
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

        private void getServerStatus()
        {
            this.serverStatus.Text = "Checking Server...";
            if (new Ping().Send(IPAddress.Parse("31.170.162.63")).Status == IPStatus.Success)
                this.serverStatus.Text = "Online";
            else
                this.serverStatus.Text = "No Connection";
        }

        private void serverStatus_TextChanged(object sender, EventArgs e)
        {
            if (this.serverStatus.Text == "Online")
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
    }
}