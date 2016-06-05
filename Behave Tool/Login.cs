using System;
using System.Drawing;
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

            CheckForIllegalCrossThreadCalls = false;
            StartPosition = FormStartPosition.Manual;
            this.Location = new Point((Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2,
                          (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2);
        }

        private bool loginSuccess()
        {
            if (user == "admin" && pass == "ddr3")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void Log_In_Click(object sender, EventArgs e)
        {
            user = UserName.Text;
            pass = PassWord.Text;

            attempts += 1;

            if (loginSuccess() == false)
            {
                Error.Visible = true;
                if (attempts <= 2)
                {
                    new Thread(new ThreadStart(err)) { IsBackground = true }.Start();
                    AttemptCount.Text = "Attempts left: " + (3 - attempts);
                }
                else // if attempts is more than 3
                {
                    MessageBox.Show("You have ran out of attempts!");
                    Program.failLogin = true;
                    Close();
                }
            }
            else // allow to login
            {
                Program.failLogin = false;
                Close();
            }
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
    }
}