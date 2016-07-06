using Behave_Tool.Tools;
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
            
            //Application.Run(new Behave());
            while (true)
            {
                for (int i = 0; i <=10; i++)
                restart = false;
                if (!(new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator)))
                {
                    if (Properties.Settings.Default.Agreement == false)
                    {
                        Application.Run(new Usage_Agreement());
                        if(Usage_Agreement.agreement() == false)
                        {
                            return; // incase someone modifies agreement form;
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
                            int totaltime = Properties.Settings.Default.Total_Session_Time;
                            Properties.Settings.Default.Reset();
                            Properties.Settings.Default["Total_Session_Time"] = totaltime;
                            Properties.Settings.Default.Save();
                            Misc.SaveError(ex.ToString());
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

        //static void Application_ThreadException(object sender, ThreadExceptionEventArgs e)
        //{
        //    MessageBox.Show(e.Exception.Message, "Unhandled Thread Exception");
        //    // here you can log the exception ...
        //}

        //static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        //{
        //    MessageBox.Show((e.ExceptionObject as Exception).Message, "Unhandled UI Exception");
        //    // here you can log the exception ...
        //}
    }
}