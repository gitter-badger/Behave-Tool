using Behave_Tool.Tools;
using System;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net.NetworkInformation;
using System.Threading;
using System.Windows.Forms;

namespace Behave_Tool
{
    
    public partial class Behave : Form
    {
        //private const int HT_CLIENT = 1;
        //private const int HT_CAPTION = 2;
        public static bool loadComplete = false;

        // private string[] _tools = new string[] { "Local Host Scanner" };    // Search Bar Items
        private const int WM_NCHITTEST = 132;

        private static bool networkTrafficMonitoring = true;
        private static bool systemUsageOn = true;
        private bool stopflicker = false;


        public Behave()
        {
            InitializeComponent();

            this.Opacity = 0;
            //ControlBox = false;
            //Text = "";
            //new Loading().Show();

            Load_Settings();
            startupProceedure();
            loadComplete = true;
            MessageBox.Show("Double Click Storage to disable the disgusting flickery. Will improve in the future.");
        }

        private void AvailableDrives()
        {
            int defaultHeight = tableLayoutPanel1.Height;
            while (true)
            {
                DrivesList.HeaderStyle = ColumnHeaderStyle.None;
                // Here we create a DataTable with four columns.
                DataTable table = new DataTable();

                table.Columns.Add("Drive", typeof(string));
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

        private void systemUsage()
        {
            new Thread(new ThreadStart(getCPUusage))
            {
                IsBackground = true
            }.Start();
            new Thread(new ThreadStart(getRamUsage))
            {
                IsBackground = true
            }.Start();
        }

        private void UpdatePublicIP()
        {
            Console.WriteLine("=UpdatePublicIP= Start");
            IPrefresh.Image = Properties.Resources.Loading_Gif;

            IPdisplay.Text = "Checking IP...";
            IPdisplay.Text = "Public IP: " + IP.getPublicIP();
            IPrefresh.Image = Properties.Resources.Behave;
            Console.WriteLine("=Done= UpdatePublicIP");
        }

        protected override void WndProc(ref Message m)
        {
            const int wmNcHitTest = 0x84;
            const int htBottomLeft = 16;
            const int htBottomRight = 17;
            if (m.Msg == wmNcHitTest)
            {
                int x = (int)(m.LParam.ToInt64() & 0xFFFF);
                int y = (int)((m.LParam.ToInt64() & 0xFFFF0000) >> 16);
                Point pt = PointToClient(new Point(x, y));
                Size clientSize = ClientSize;
                if (pt.X >= clientSize.Width - 16 && pt.Y >= clientSize.Height - 16 && clientSize.Height >= 16)
                {
                    m.Result = (IntPtr)(IsMirrored ? htBottomLeft : htBottomRight);
                    return;
                }
            }

            base.WndProc(ref m);
            if (m.Msg != 132)
                return;
            m.Result = (IntPtr)2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }



        private void Close_Click(object sender, EventArgs e)
        {
            Environment.Exit(Environment.ExitCode);
        }

        private void getCPUusage()
        {
            
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
                memAvailable = System_Information.RAM.GetUsingMemoryInBytes();
                memPhysical = System_Information.RAM.GetTotalMemoryInBytes();
                memUsing = memPhysical - memAvailable;

                percentage = Convert.ToInt16(memUsing / memPhysical * 100);

                ramUsage.Text = Math.Round((memUsing / 1024), 2) + " GB" + " / " + Math.Round((memPhysical / 1024), 2) + " GB";

                RAMbar.Value = percentage;
                Thread.Sleep(4000);
            }
        }

        private void htmlDownloaderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Html_Downloader().Show();
        }

        private void htmlHeaderScraperToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Html_Header_Scraper().Show();
        }

        private void IPdisplay_ButtonClick(object sender, EventArgs e)
        {
            new Network().Show();
        }

        private void IPrefresh_Click(object sender, EventArgs e)
        {
            new Thread(new ThreadStart(UpdatePublicIP)) { IsBackground = true }.Start();
        }

        private void label5_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            stopflicker = true;
        }

        private void Load_Settings()
        {
            setBackground();
            var colour1 = ColorTranslator.FromHtml(Properties.Settings.Default.Text1_Colour);
            var colour2 = ColorTranslator.FromHtml(Properties.Settings.Default.Text2_Colour);
            var colour3 = ColorTranslator.FromHtml(Properties.Settings.Default.Text3_Colour);
            foreach (ToolStripDropDownItem button in Menu.DropDownItems)
            {
                button.ForeColor = colour3;
            }
            CPUbar.ForeColor = Color.Red;
            CPUbar.Style = ProgressBarStyle.Continuous;
            CPUbar.Maximum = 100;
            CPUbar.Minimum = 0;
            RAMbar.ForeColor = Color.Red;
            RAMbar.Style = ProgressBarStyle.Continuous;
            RAMbar.Maximum = 100;
            RAMbar.Minimum = 0;

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

        private void localHostScannerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new LocalHostScanner().Show();
        }

        private void localPortScannerToolStripMenuItem_Click(object sender, EventArgs e)
        {
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

        private void MaximizeNormalize_Click(object sender, EventArgs e)
        {
            this.WindowState = this.WindowState == FormWindowState.Maximized ? FormWindowState.Normal : FormWindowState.Maximized;
        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

            notifyIcon1.BalloonTipText = "Application Minimized.";
            notifyIcon1.BalloonTipTitle = "test";
            notifyIcon1.Visible = true;
            notifyIcon1.ShowBalloonTip(5000);
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ShowInTaskbar = true;
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

        private void openPortScannerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Local_Port_Scanner().Show();
        }

        private void preset1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
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
                        SystemLiveInformation.ActiveForm.Close();
                        //if (form.Name == "SystemLiveInformation")
                        //{
                        //    form.Close();
                        //}
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
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

        private void SearchBar_KeyUp(object sender, KeyEventArgs e)
        {
            //foreach (string t in _tools)
            //{
            //    string value1 = Array.Find(_tools, element => element.StartsWith(Text, StringComparison.Ordinal));
            //    if (value1.Contains(Text))
            //    {
            //        SearchBar.Items.Clear();
            //        SearchBar.Items.Add(value1);
            //    }
            //}
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

        private void Settings_Click(object sender, EventArgs e)
        {
            new Behave_Settings().Show();
        }

        private void Settings_MouseHover(object sender, EventArgs e)
        {
            Settings.Image = Properties.Resources.Spiral_Gif;
        }

        private void Settings_MouseLeave(object sender, EventArgs e)
        {
            Settings.Image = Properties.Resources.Gear_;
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
                //Console.WriteLine("Down: " + (float)(performanceCounter2.NextValue() / 1024.0) + " | Up: " + (float)(performanceCounter1.NextValue() / 1024.0));
                Thread.Sleep(2000);
            }
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
            new Thread(new ThreadStart(AvailableDrives))
            {
                IsBackground = true
            }.Start();
        }

        private void tCPConnectionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ActiveTcpConnections().Show();
        }

        private void urlToIPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new URLtoIP().Show();
        }

        private class MySR : ToolStripSystemRenderer
        {
            public MySR()
            {
            }

            protected override void OnRenderToolStripBorder(ToolStripRenderEventArgs e)
            {
                base.OnRenderToolStripBorder(e);
            }
        }

        private void setBackground()
        {
            try
            {
                switch (Properties.Settings.Default.BackgroundImg)
                {
                    case "OrangeCore1":
                        BackgroundImage = Properties.Resources.Background_OrangeCore1;
                        return;

                    case "SnowFlake1":
                        BackgroundImage = Properties.Resources.Background_SnowFlake1;
                        return;

                    case "GlassWindows1":
                        BackgroundImage = Properties.Resources.Background_GlassWindows1;
                        return;

                    case "FireFlower1":
                        BackgroundImage = Properties.Resources.Background_FireFlower1;
                        return;

                    case "SnowFlake2":
                        BackgroundImage = Properties.Resources.Background_SnowFlake2;
                        return;
                }
            }
            catch (Exception ex)
            {
                Misc.SaveError(ex.ToString());
            }
        }

        private void spotifyControllerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new SpotifyController().Show();
        }

        private void soundcloudDownloaderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new SoundcloudDownloader().Show();
        }

        private void socketListenerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Network_Socket_Listener().Show();
        }

        private void sandboxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Sandbox().Show();
        }

        private void softwareInstallerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new SoftwareDownload().Show();
        }

        private void betterTaskManagerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new BetterTaskManager().Show(); 
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            new ShowHide().Show();
        }

        private void storageDrives1_Load(object sender, EventArgs e)
        {

        }
    }
}