using System;
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

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg != 132)
                return;
            m.Result = (IntPtr)2;
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
            _stopScan = false;
            ScanStatus.Text = "Scanning";
            string ipBase = string.Empty;
            string gate = IP.getGateway();

            if (gate != "Failed")
            {
                ipBase = gate.Substring(0, gate.Length - 1);
            }
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
                        tcpClient.Connect(gate, port);
                        listBox1.Items.Add(port);
                        Console.WriteLine("Port {0} is open", port);
                    }
                    catch (System.Net.Sockets.SocketException)
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
            ScanStatus.Text = "stopping";
        }

        private void ScanSingle_Click(object sender, EventArgs e)
        {
            string ipBase = string.Empty;
            string gate = IP.getGateway();

            if (gate != "Failed")
            {
                ipBase = gate.Substring(0, gate.Length - 1);
            }

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
                    tcpClient.Connect(gate, port);
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
            Tools.Misc.listBoxSaveTxt(listBox1);
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}