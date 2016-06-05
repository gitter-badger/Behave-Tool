using System;
using System.Security.Principal;
using System.Windows.Forms;

namespace Behave_Tool
{
    internal static class Program
    {
        public static bool failLogin = true;
        public static bool restart;

        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            while (true)
            {
                restart = false;
                if (!(new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator)))
                {
                    if (Properties.Settings.Default.Agreement == false)
                    {
                        Application.Run(new Usage_Agreement());

                        if (Properties.Settings.Default.Agreement == false)
                        {
                            Application.Exit();
                        }
                    }
                    // if Agreement agreed

                    Application.Run(new Login());
                    if (failLogin == true)
                    {
                        Application.Exit(); // Login Fail, Close Program
                    }
                    else
                    {
                        Application.Run(new Behave());
                    }
                }
                else
                {
                    MessageBox.Show("This application needs administrator privileges to run properly.");
                }
                if (restart == false)
                {
                    break;
                }
                Application.Exit();
            }
        }
    }
}