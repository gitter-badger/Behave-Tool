using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Threading;
using System.Windows.Forms;

namespace Behave_Tool
{
    public partial class Network : Form
    {
        public Network()
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

        private void startupProcedure()
        {
            new Thread(new ThreadStart(getWebConnect)) { IsBackground = true }.Start();
            new Thread(new ThreadStart(getPublicIP)) { IsBackground = true }.Start();
            new Thread(new ThreadStart(getGateway)) { IsBackground = true }.Start();
            new Thread(new ThreadStart(getIPv4)) { IsBackground = true }.Start();
            new Thread(new ThreadStart(getIPv6)) { IsBackground = true }.Start();
            new Thread(new ThreadStart(getMAC)) { IsBackground = true }.Start();
        }

        private void IndepthIPinfo_Load(object sender, EventArgs e)
        {
            new Thread(new ThreadStart(startupProcedure)) { IsBackground = true }.Start();
        }

        private void getPublicIP()
        {
            IP.Text = "Getting...";

            IP.Text = Behave_Tool.IP.getPublicIP();
        }

        private void getIPv6()
        {
            IPv6.Text = "Getting...";

            IPv6.Text = Behave_Tool.IP.getIPv6();
        }

        private void getWebConnect()
        {
            WebConnection.Text = "Ping'ing...";

            WebConnection.Text = Behave_Tool.IP.getConnectionStatus();
        }

        private void getIPv4()
        {
            IPv4.Text = "Getting...";

            IPv4.Text = Behave_Tool.IP.getIPv4();
        }

        private void getMAC()
        {
            MAC.Text = "Getting...";

            MAC.Text = Behave_Tool.IP.getMAC();
        }

        private void getGateway()
        {
            gateway.Text = "Getting...";
            gateway.Text = Behave_Tool.IP.getGateway();
        }

        private void recheckAll()
        {
            startupProcedure();
        }

        private void WebConnection_TextChanged(object sender, EventArgs e)
        {
            if (WebConnection.Text == "Success")
            {
                WebConnection.ForeColor = Color.Green;
            }
            else if (WebConnection.Text == "Ping'ing...") { WebConnection.ForeColor = Color.Yellow; }
            else { WebConnection.ForeColor = Color.Red; }
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ALL_Refresh_Click(object sender, EventArgs e)
        {
            new Thread(new ThreadStart(recheckAll)) { IsBackground = true }.Start();
        }

        private void Web_Refresh_Click(object sender, EventArgs e)
        {
            new Thread(new ThreadStart(getWebConnect)) { IsBackground = true }.Start();
        }

        private void IP_Refresh_Click(object sender, EventArgs e)
        {
            new Thread(new ThreadStart(getPublicIP)) { IsBackground = true }.Start();
        }

        private void IPv4_Refresh_Click(object sender, EventArgs e)
        {
            new Thread(new ThreadStart(getIPv4)) { IsBackground = true }.Start();
        }

        private void IPv6_Refresh_Click(object sender, EventArgs e)
        {
            new Thread(new ThreadStart(getIPv6)) { IsBackground = true }.Start();
        }

        private void MAC_Refresh_Click(object sender, EventArgs e)
        {
            new Thread(new ThreadStart(getMAC)) { IsBackground = true }.Start();
        }

        private void gateway_Refresh_Click(object sender, EventArgs e)
        {
            new Thread(new ThreadStart(getGateway)) { IsBackground = true }.Start();
        }

        private void MAC_Click(object sender, EventArgs e)
        {
        }

        private void MAC_Label_Click(object sender, EventArgs e)
        {
        }

        private void IPv6_Click(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void IPv4_Click(object sender, EventArgs e)
        {
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void Ipv4Label_Click(object sender, EventArgs e)
        {
        }

        private void gateLabel_Click(object sender, EventArgs e)
        {
        }

        private void gateway_Click(object sender, EventArgs e)
        {
        }

        private void IP_TextChanged(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void WebLabel_Click(object sender, EventArgs e)
        {
        }

        private void WebConnection_Click(object sender, EventArgs e)
        {
        }
    }

    public class IP
    {
        public static string getConnectionStatus()

        {
            try
            {
                using (var client = new WebClient())
                {
                    using (var stream = client.OpenRead("http://www.google.com"))
                    {
                        return "Success";
                    }
                }
            }
            catch
            {
                return "Failed";
            }
        }

        public static string getPublicIP()
        {
            Console.WriteLine("=GetPublicIP= Start");
            try
            {
                string ip = new StreamReader(WebRequest.Create("http://checkip.dyndns.org").GetResponse().GetResponseStream()).ReadToEnd().Trim().Split(':')[1].Substring(1).Split('<')[0];

                Console.WriteLine("=GetPublicIP= Returned " + ip);
                return ip;
            }
            catch (Exception)
            {
                Console.WriteLine("=GetPublicIP= Failed");
                return "Failed";
            }
        }

        public static string getIPv4()
        {
            Console.WriteLine("=getIPV4= Start");
            try
            {
                using (Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, 0))
                {
                    socket.Connect("10.0.2.4", 65530);
                    IPEndPoint endPoint = socket.LocalEndPoint as IPEndPoint;
                    Console.WriteLine("=getIPV4= Returned " + endPoint.Address.ToString());
                    return endPoint.Address.ToString(); //ipv4
                }
            }
            catch (Exception)
            {
                Console.WriteLine("=GetIPv4= Failed");
                return "Failed";
            }
        }

        public static string getIPv6()
        {
            Console.WriteLine("=getIPv6= Start");
            string strHostName = System.Net.Dns.GetHostName(); ;
            IPHostEntry ipEntry = System.Net.Dns.GetHostEntry(strHostName);
            IPAddress[] addr = ipEntry.AddressList;
            Console.WriteLine(addr[addr.Length - 1].ToString());
            if (addr[0].AddressFamily == System.Net.Sockets.AddressFamily.InterNetworkV6)
            {
                Console.WriteLine("=getIPV6= Returned " + addr[0].ToString());
                return addr[0].ToString();
            }
            else
            {
                return "Failed";
            }
        }

        public static string getMAC()
        {
            try
            {
                NetworkInterface[] nics = NetworkInterface.GetAllNetworkInterfaces();
                String sMacAddress = string.Empty;
                foreach (NetworkInterface adapter in nics)
                {
                    if (sMacAddress == string.Empty)
                    {
                        IPInterfaceProperties properties = adapter.GetIPProperties();
                        sMacAddress = adapter.GetPhysicalAddress().ToString();
                    }
                }
                return sMacAddress;
            }
            catch (Exception)
            {
                return "Failed";
            }
        }

        public static string getGateway()
        {
            try
            {
                var gateway = NetworkInterface.GetAllNetworkInterfaces().Where(e => e.OperationalStatus == OperationalStatus.Up).SelectMany(e => e.GetIPProperties().GatewayAddresses).FirstOrDefault();
                return gateway.Address.ToString();
            }
            catch (Exception)
            {
                return "Failed";
            }
        }
    }
}