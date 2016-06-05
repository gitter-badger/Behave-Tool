using System;
using System.Windows.Forms;

namespace Behave_Tool
{
    public partial class ShowHide : UserControl
    {
        public ShowHide()
        {
            InitializeComponent();
        }

        private void checkBox1_Checked_Changed(object sender, EventArgs e)
        {
            if (checkBox1.Checked == false)
            {
                ParentForm.Width = 194;
                checkBox1.Checked = true;
            }
            else
            {
                checkBox1.Checked = false;
                ParentForm.Width = 23;
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
    }
}