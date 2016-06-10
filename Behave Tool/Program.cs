using System;
using System.Diagnostics;
using System.IO;
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

            // Application.Run(new Behave());
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
                        try
                        {
                            Application.Run(new Behave());
                        }
                        catch (Exception ex)
                        {
                            Properties.Settings.Default.Reset();
                            MessageBox.Show("Behave has crashed. \n Settings have been reset. \nPlease choose a location to save the error log and send it to COOP");
                            SaveFileDialog savefile = new SaveFileDialog();
                            // set a default file name
                            savefile.FileName = "Behave_Error.txt";
                            // set filters - this can be done in properties as well
                            savefile.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";

                            if (savefile.ShowDialog() == DialogResult.OK)
                            {
                                using (StreamWriter sw = new StreamWriter(savefile.FileName))
                                {
                                    sw.WriteLine(ex);
                                }
                                Process.Start(savefile.FileName);
                            }
                        }
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