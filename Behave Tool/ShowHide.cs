using System;
using System.Drawing;
using System.Windows.Forms;

namespace Behave_Tool
{
    public partial class ShowHide : UserControl
    {
        public ShowHide()
        {
            InitializeComponent();
            // panel1.BackColor = Color.FromArgb(0, 0, 0, 0);
        }
        
        private void checkBox1_Checked_Changed(object sender, EventArgs e)
        {
            if (checkBox1.Checked == false)
            {
                Width = 194;
                checkBox1.Checked = true;
            }
            else
            {
                checkBox1.Checked = false;
                Width = 23;
            }
        }

        private void ShowHide_MouseClick(object sender, MouseEventArgs e)
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        protected override void WndProc(ref Message m)
        {
            
            base.WndProc(ref m);
            if (m.Msg != 132)
                return;
            m.Result = (IntPtr)2;
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {

            new PanelOptions().Show();
        }

    }
}