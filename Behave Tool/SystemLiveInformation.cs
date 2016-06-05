using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Behave_Tool
{
    public partial class SystemLiveInformation : Form
    {
        public SystemLiveInformation()
        {
            InitializeComponent();
            Location = new Point(0, Screen.PrimaryScreen.WorkingArea.Height / 2);

        }

        private void SystemLiveInformation_Load(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void tableLayoutPanel1_MouseClick(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {

                case MouseButtons.Left:
                    // Left click
                    break;

                case MouseButtons.Right:
                    // Right click
                    new PanelOptions().Show();
                    break;
            }
        }

        private void showHide1_Load(object sender, EventArgs e)
        {

        }
    }
}

