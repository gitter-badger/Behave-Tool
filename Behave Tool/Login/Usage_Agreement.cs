using System;
using System.Windows.Forms;

namespace Behave_Tool
{
    public partial class Usage_Agreement : Form
    {
        public Usage_Agreement()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void Agree_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default["Agreement"] = true;
            Properties.Settings.Default.Save();
            Close();
        }

        private void Disagree_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default["Agreement"] = false;
            Properties.Settings.Default.Save();
            Close();
        }
    }
}