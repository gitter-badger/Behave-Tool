using System;
using System.Diagnostics;
using System.IO;
using System.Net.Sockets;
using System.Threading;
using System.Windows.Forms;

namespace Behave_Tool
{
    public partial class Local_Port_Scanner : Form
    {
        private bool _stopScan;

        public Local_Port_Scanner()
        {
            InitializeComponent();
            TopMost = true;
            CheckForIllegalCrossThreadCalls = false;
        }

        private void ClearList_Click(object sender, System.EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void ScanRange_Click(object sender, System.EventArgs e)
        {
            new Thread(new ThreadStart(AllOpenPorts)).Start();
        }

        public void AllOpenPorts()
        {
            ScanStatus.Text = "Scanning";
            int num1 = 0;
            int num2 = 0;
            try
            {
                num1 = Convert.ToInt32(RangeMin.Text);
                num2 = Convert.ToInt32(RangeMax.Text);
            }
            catch (Exception)
            {
            }
            Console.WriteLine("Starting Port Scan On {0} And Ending On {1}", num1, num2);
            using (TcpClient tcpClient = new TcpClient())
            {
                for (int port = num1; port <= num2; ++port)
                {
                    ScanStatus.Text = "Scanning Port " + port;
                    try
                    {
                        tcpClient.Connect("127.0.0.1", port);
                        listBox1.Items.Add(port);
                        Console.WriteLine("Port {0} is open", port);
                    }
                    catch (Exception)
                    {
                        // listBox2.Items.Add(port);
                        Console.WriteLine("Port {0} is closed", port);
                    }
                    if (_stopScan == true)
                    {
                        break;
                    }
                }
                ScanStatus.Text = "Idle";
            }
            Console.WriteLine("Port Scan Complete");
        }

        private void StopScan_Click(object sender, EventArgs e)
        {
            _stopScan = true;
            ScanStatus.Text = "Idle";
        }

        private void ScanSingle_Click(object sender, EventArgs e)
        {
            using (TcpClient tcpClient = new TcpClient())
            {
                int port = 0;

                try
                {
                    port = Convert.ToInt32(SinglePort.Text);
                }
                catch (Exception)
                {
                }
                ScanStatus.Text = "Scanning Port " + port;
                try
                {
                    tcpClient.Connect("127.0.0.1", port);
                    listBox1.Items.Add(port);
                    Console.WriteLine("Port {0} is Open", port);
                }
                catch (Exception)
                {
                    //listBox1.Items.Add(port);
                    ScanStatus.Text = "Port " + port + " Is Closed";
                    Console.WriteLine("Port {0} is closed", port);
                    Thread.Sleep(1000);
                }
            }

            ScanStatus.Text = "Idle";
        }

        private void OnKeyDown(object sender, KeyEventArgs e)
        {
            string copy = null;
            if (e.Control && e.KeyCode == Keys.C)
            {
                foreach (object port in listBox1.SelectedItems)
                {
                    copy += port.ToString() + ", ";
                }
                Clipboard.SetText(copy);
            }
        }

        private void SaveToTxt_Click(object sender, EventArgs e)
        {
            SaveFileDialog savefile = new SaveFileDialog();
            // set a default file name
            savefile.FileName = "OpenPorts.txt";
            // set filters - this can be done in properties as well
            savefile.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";

            if (savefile.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(savefile.FileName))
                {
                    foreach (object port in listBox1.Items)
                    {
                        sw.WriteLine(port);
                    }
                }
                Process.Start(savefile.FileName);
            }
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}