using System;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.NetworkInformation;
using System.Threading;
using System.Windows.Forms;

namespace Behave_Tool
{
    public partial class Behave : Form
    {
        private static bool networkTrafficMonitoring = true;
        private static bool systemUsageOn = true;
        private const int WM_NCHITTEST = 132;
        private const int HT_CLIENT = 1;
        private const int HT_CAPTION = 2;
        public static bool loadComplete = false;

        public Behave()
        {
            InitializeComponent();
            this.Opacity = 0;

            //new Loading().Show();

            Load_Settings();
            startupProceedure();
            loadComplete = true;
            MessageBox.Show("Double Click Storage to disable the disgusting flickery. Will improve in the future.");
        }

        public class MySR : ToolStripSystemRenderer
        {
            public MySR()
            {
            }

            protected override void OnRenderToolStripBorder(ToolStripRenderEventArgs e)
            {
                //base.OnRenderToolStripBorder(e);
            }
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg != 132)
                return;
            m.Result = (IntPtr)2;
        }

        private void startupProceedure()
        {
            Console.WriteLine(NetworkInterface.GetIsNetworkAvailable());

            new Thread(new ThreadStart(UpdatePublicIP))
            {
                IsBackground = true
            }.Start();

            new Thread(new ThreadStart(ShowNetworkTraffic))
            {
                IsBackground = true
            }.Start();
            new Thread(new ThreadStart(systemUsage))
            {
                IsBackground = true
            }.Start();
            new Thread(new ThreadStart(sessionTimer))
            {
                IsBackground = true
            }.Start();
            new Thread(new ThreadStart(AvailableDrives)).Start();
        }

        private void ShowNetworkTraffic()
        {
            PerformanceCounterCategory performanceCounterCategory = new PerformanceCounterCategory("Network Interface");
            string instanceName = performanceCounterCategory.GetInstanceNames()[0];
            PerformanceCounter performanceCounter1 = new PerformanceCounter("Network Interface", "Bytes Sent/sec", instanceName);
            PerformanceCounter performanceCounter2 = new PerformanceCounter("Network Interface", "Bytes Received/sec", instanceName);
            while (networkTrafficMonitoring == true)
            {
                NetworkTrafficDown.Text = Math.Round((float)(performanceCounter2.NextValue() / 1024.0), 2) + " kb/s";
                NetworkTrafficUp.Text = Math.Round((float)(performanceCounter1.NextValue() / 1024.0), 2) + " kb/s";
                Console.WriteLine("Down: " + (float)(performanceCounter2.NextValue() / 1024.0) + " | Up: " + (float)(performanceCounter1.NextValue() / 1024.0));
                Thread.Sleep(2000);
            }
        }

        private void sessionTimer()
        {
            int counter = 0;
            int totalCounter = Properties.Settings.Default.Total_Session_Time;
            while (true)
            {
                counter += 1;
                totalCounter += 1;
                SessionTimer.Text = "This Session: " + TimeSpan.FromSeconds(counter).ToString();
                TotalSessionTime.Text = "Total Time: " + TimeSpan.FromSeconds(totalCounter).ToString();
                Properties.Settings.Default["Total_Session_Time"] = totalCounter;
                Properties.Settings.Default.Save();
                Thread.Sleep(1000);
            }
        }

        public string GetPublicIP()
        {
            Console.WriteLine("=Start= GetPublicIP");
            try
            {
                return "Public IP: " + new StreamReader(WebRequest.Create("http://checkip.dyndns.org").GetResponse().GetResponseStream()).ReadToEnd().Trim().Split(':')[1].Substring(1).Split('<')[0];
            }
            catch (Exception)
            {
                Console.WriteLine("=Fail= GetPublicIP => Retrieve Public IP ");
                return "Failed To Retrieve Public IP";
            }
        }

        public void UpdatePublicIP()
        {
            IPrefresh.Image = Properties.Resources.Loading_Gif;
            Console.WriteLine("=Start= UpdatePublicIP");

            IPdisplay.Text = "Checking IP...";
            IPdisplay.Text = GetPublicIP();
            Console.WriteLine("=Done= GetPublicIP");
            Console.WriteLine("=Done= UpdatePublicIP");
            IPrefresh.Image = Properties.Resources.Behave;
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Environment.Exit(Environment.ExitCode);
        }

        private void IPrefresh_Click(object sender, EventArgs e)
        {
            new Thread(new ThreadStart(UpdatePublicIP))
            {
                IsBackground = true
            }.Start();
        }

        private void releaseIPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("ipconfig", "/release").WaitForExit();
            IPdisplay.Text = "IP Released!";
        }

        private void renewIPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IPdisplay.Text = "Renewing IP...";
            Process.Start("ipconfig", "/renew").WaitForExit();
            new Thread(new ThreadStart(UpdatePublicIP))
            {
                IsBackground = true
            }.Start();
        }

        public void systemUsage()
        {
            new Thread(new ThreadStart(getCPUusage)).Start();
            new Thread(new ThreadStart(getRamUsage)).Start();
        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

            notifyIcon1.BalloonTipText = "Application Minimized.";
            notifyIcon1.BalloonTipTitle = "test";
            notifyIcon1.Visible = true;
            notifyIcon1.ShowBalloonTip(5000);
        }

        private void Main_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                notifyIcon1.Icon = Properties.Resources.Behave_Icon;
                notifyIcon1.BalloonTipText = "Application Minimized.";
                notifyIcon1.BalloonTipTitle = "test";
                notifyIcon1.Visible = true;
                notifyIcon1.ShowBalloonTip(5000);
            }
            else if (WindowState == FormWindowState.Normal)
            {
                notifyIcon1.Visible = false;
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ShowInTaskbar = true;
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

        private void MaximizeNormalize_Click(object sender, EventArgs e)
        {
            this.WindowState = this.WindowState == FormWindowState.Maximized ? FormWindowState.Normal : FormWindowState.Maximized;
        }

        private void getCPUusage()
        {
            CPUbar.ForeColor = Color.Red;
            CPUbar.Style = ProgressBarStyle.Continuous;
            CPUbar.Maximum = 100;
            CPUbar.Minimum = 0;
            RAMbar.ForeColor = Color.Red;
            RAMbar.Style = ProgressBarStyle.Continuous;
            RAMbar.Maximum = 100;
            RAMbar.Minimum = 0;
            while (systemUsageOn)
            {
                PerformanceCounter cpuCounter = new PerformanceCounter();
                cpuCounter.CategoryName = "Processor";
                cpuCounter.CounterName = "% Processor Time";
                cpuCounter.InstanceName = "_Total";
                // will always start at 0
                dynamic firstValue = cpuCounter.NextValue();
                Thread.Sleep(1000);
                // now matches task manager reading
                dynamic secondValue = cpuCounter.NextValue();
                secondValue = Math.Round(secondValue, 2);
                cpuUsage.Text = secondValue + "%";

                CPUbar.Value = (int)secondValue;
            }
        }

        private void getRamUsage()
        {
            double memAvailable, memPhysical, memUsing;
            int percentage;

            while (true)
            {
                memAvailable = GetUsingMemoryInBytes();
                memPhysical = GetTotalMemoryInBytes();
                memUsing = memPhysical - memAvailable;

                percentage = Convert.ToInt16(memUsing / memPhysical * 100);

                ramUsage.Text = Math.Round((memUsing / 1024), 2) + " GB" + " / " + Math.Round((memPhysical / 1024), 2) + " GB";

                RAMbar.Value = percentage;
                Thread.Sleep(4000);
            }
        }

        private static ulong GetTotalMemoryInBytes()
        {
            return new Microsoft.VisualBasic.Devices.ComputerInfo().TotalPhysicalMemory / 1024 / 1024;
        }

        private static ulong GetUsingMemoryInBytes()
        {
            return new Microsoft.VisualBasic.Devices.ComputerInfo().AvailablePhysicalMemory / 1024 / 1024;
        }

        private void Settings_MouseHover(object sender, EventArgs e)
        {
            Settings.Image = Properties.Resources.Spiral_Gif;
        }

        private void Settings_MouseLeave(object sender, EventArgs e)
        {
            Settings.Image = Properties.Resources.Gear_;
        }

        public void AvailableDrives()
        {
            int defaultHeight = tableLayoutPanel1.Height;
            while (true)
            {
                DrivesList.HeaderStyle = ColumnHeaderStyle.None;
                // Here we create a DataTable with four columns.
                DataTable table = new DataTable();
                table.Columns.Add("Drive:", typeof(string));
                table.Columns.Add("Using", typeof(string));
                table.Columns.Add("Total", typeof(string));
                table.Columns.Add("seperator", typeof(string));

                // string rowdata;
                string name;
                string usingSpace = null;
                string totalSpace = null;
                string seperator = "/";
                int counter = -42;
                DriveInfo[] allDrives = DriveInfo.GetDrives();

                foreach (DriveInfo d in allDrives)
                {
                    counter += 21;
                    if (d.IsReady == true)
                    {
                        name = d.Name + " ";
                        if ((d.TotalSize / 1024 / 1024 / 1024) - (d.TotalFreeSpace / 1024 / 1024 / 1024) < 1000)
                        {
                            usingSpace = (d.TotalSize / 1024 / 1024 / 1024) - (d.TotalFreeSpace / 1024 / 1024 / 1024) + " GB";
                        }
                        else if ((d.TotalSize / 1024 / 1024 / 1024) - (d.TotalFreeSpace / 1024 / 1024 / 1024) >= 1000)
                        {
                            usingSpace = Math.Round(d.TotalSize / 1024 / 1024 / 1024 / 1024 - (float)(d.TotalFreeSpace / 1024 / 1024 / 1024 / 1024), 2) + " TB";
                        }
                        if ((d.TotalSize / 1024 / 1024 / 1024) < 1000)
                        {
                            totalSpace = (d.TotalSize / 1024 / 1024 / 1024).ToString() + " GB";
                        }
                        else if ((d.TotalSize / 1024 / 1024 / 1024) >= 1000)
                        {
                            totalSpace = Math.Round(((float)d.TotalSize / 1024 / 1024 / 1024 / 1024), 2).ToString() + " TB";
                        }
                        table.Rows.Add(d.Name, usingSpace, seperator, totalSpace);
                    }
                }
                tableLayoutPanel1.Height += counter;

                foreach (DataRow d in table.Rows)
                {
                    ListViewItem item = new ListViewItem(d[0].ToString());
                    for (int i = 1; i < table.Columns.Count; i++)
                    {
                        item.SubItems.Add(d[i].ToString());
                    }
                    DrivesList.Items.Add(item);
                }
                if (stopflicker == true) { break; }
                Thread.Sleep(5000);
                DrivesList.Items.Clear();
                DrivesList.Update();
                DrivesList.Refresh();
                tableLayoutPanel1.Height = defaultHeight; // reset height of List
            }
        }

        private bool stopflicker = false;

        private void label5_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            stopflicker = true;
        }

        private void localPortScannerToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void Settings_Click(object sender, EventArgs e)
        {
            new Behave_Settings().Show();
        }

        private void Load_Settings()
        {
            var colour1 = ColorTranslator.FromHtml(Properties.Settings.Default.Text1_Colour);
            var colour2 = ColorTranslator.FromHtml(Properties.Settings.Default.Text2_Colour);
            Menu.ForeColor = colour1;
            IPdisplay.ForeColor = colour2;
            CPU_Label.ForeColor = colour2;
            RAM_Label.ForeColor = colour2;
            Download_Label.ForeColor = colour2;
            Upload_Label.ForeColor = colour2;
            Storage_Label.ForeColor = colour2;
            SessionTimer.ForeColor = colour2;
            TotalSessionTime.ForeColor = colour2;

            ToolBar.Renderer = new MySR();

            FormBorderStyle = FormBorderStyle.None;
            StartPosition = FormStartPosition.Manual;
            Location = new Point((Screen.PrimaryScreen.WorkingArea.Width - Width) / 2, 0);
            TopMost = Properties.Settings.Default.KeepWindowOnTop;
            CheckForIllegalCrossThreadCalls = false; // this is bad!
            Opacity = Properties.Settings.Default.BehaveOpacity; // default 0.9;
        }

        private void changeBackground()
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void preset1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (preset1ToolStripMenuItem.Checked == false)
            {
                preset1ToolStripMenuItem.Checked = true;
                new SystemLiveInformation().Show();
            }
            else
            {
                preset1ToolStripMenuItem.Checked = false;
                foreach (Form form in Application.OpenForms)
                {
                    if (form.Name == "SystemLiveInformation")
                    {
                        form.Close();
                    }
                }
            }
        }

        private void openPortScannerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Local_Port_Scanner().Show();
        }

        private void tCPConnectionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ActiveTcpConnections().Show();
        }

        private void localHostScannerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new LocalHostScanner().Show();
        }
    }
}