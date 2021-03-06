﻿using System;
using System.Diagnostics;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Threading;

namespace MassRepo.Tools.Network
{
    public partial class LocalHostScanner : ToolDefaultForm
    {
        private static CountdownEvent countdown;
        private static int upCount = 0;
        private static object lockObj = new object();
        private const bool resolveNames = true;

        public LocalHostScanner()
        {
            InitializeComponent();
            TopMost = true;
        }

        public void program()
        {
            Status.Text = "Scanning all Ports...";
            countdown = new CountdownEvent(1);
            Stopwatch sw = new Stopwatch();
            sw.Start();
            string ipBase = string.Empty;
            string gate = IPinfo.getGateway();

            if (gate != "Failed")
            {
                ipBase = gate.Substring(0, gate.Length - 1);
            }
            try
            {
                for (int i = 1; i <= 254; i++)
                {
                    string ip = ipBase + i.ToString();

                    Ping p = new Ping();
                    p.PingCompleted += new PingCompletedEventHandler(p_PingCompleted);
                    countdown.AddCount();
                    p.SendAsync(ip, 100, ip);
                }

                countdown.Signal();

                countdown.Wait();

                sw.Stop();
                TimeSpan span = new TimeSpan(sw.ElapsedTicks);
                listBox1.Items.Add("Took " + sw.ElapsedMilliseconds + " ms. " + upCount + " hosts active.");
                //Console.ReadLine();
                Status.Text = "Complete";
            }
            catch (Exception)
            {
                listBox1.Items.Add("No Network");
            }
        }

        private void p_PingCompleted(object sender, PingCompletedEventArgs e)
        {
            Status.Text = "Pinging possible hosts...";
            string ip = (string)e.UserState;
            string response;
            if (e.Reply != null && e.Reply.Status == IPStatus.Success)
            {
                if (resolveNames)
                {
                    string name;
                    try
                    {
                        IPHostEntry hostEntry = Dns.GetHostEntry(ip);
                        name = hostEntry.HostName;
                    }
                    catch (SocketException)
                    {
                        name = "???";
                    }
                    response = (ip + " (" + name + ") " + " is up: (" + e.Reply.RoundtripTime + " ms)").ToString();
                    listBox1.Items.Add(response);
                    //Console.WriteLine("{0} ({1}) is up: ({2} ms)", ip, name, e.Reply.RoundtripTime);
                }

                lock (lockObj)
                {
                    upCount++;
                }
            }
            else if (e.Reply == null)
            {
            }
        }

        private void Scan_Click(object sender, EventArgs e)
        {
            new Thread(program).Start();
        }

        private void ClearList_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void SaveToTxt_Click(object sender, EventArgs e)
        {
            Misc.listBoxSaveTxt(listBox1);
        }
    }
}