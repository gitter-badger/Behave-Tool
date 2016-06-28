using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Behave_Tool.Tools
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
