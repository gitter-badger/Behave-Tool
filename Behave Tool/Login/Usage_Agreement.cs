using System;
using System.Windows.Forms;

namespace Behave_Tool
{
    public partial class Usage_Agreement : Form
    {
        private static bool _agreement = false;
        public Usage_Agreement()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void Agree_Click(object sender, EventArgs e)
        {
            _agreement = true;
            Properties.Settings.Default["Agreement"] = true;
            Properties.Settings.Default.Save();
            Close();
        }

        private void Disagree_Click(object sender, EventArgs e)
        {
            // exit application
            //Application.Exit();
            // incase did not exit
            _agreement = false;
            Close();
        }
        public static bool agreement()
        {
            return _agreement;
        }
        private void Checkbox_CheckStateChanged(object sender, EventArgs e)
        {
            if(Checkbox.Checked)
            {
                Agree.Enabled = true;
            }else
            {
                Agree.Enabled = false;
            }
        }
    }
}