using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace MassRepo.Tools
{
    public partial class BetterTaskManager : Form
    {
        public BetterTaskManager()
        {
            InitializeComponent();
            activeApps();
        }

        private void activeApps()
        {
            Process[] processes = Process.GetProcesses();
            foreach (Process p in processes)
            {
                if (!String.IsNullOrEmpty(p.MainWindowTitle))
                {
                    listView1.Items.Add(p.MainWindowTitle);
                }
            }
        }
    }
}