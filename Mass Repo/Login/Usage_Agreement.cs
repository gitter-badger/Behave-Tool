using System;
using System.Windows.Forms;

namespace MassRepo
{
    public partial class Usage_Agreement : Form
    {
        private static bool _agreement = false;

        public Usage_Agreement()
        {
            InitializeComponent();
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
            _agreement = false;
            Close();
        }

        public static bool agreement()
        {
            return _agreement;
        }

        private void Checkbox_CheckStateChanged(object sender, EventArgs e)
        {
            if (Checkbox.Checked)
            {
                Agree.Enabled = true;
            }
            else
            {
                Agree.Enabled = false;
            }
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            // mouse in window or in Border and max, close & min buttons
            if (m.Msg == 0xa0 || m.Msg == 0x200)
            {
                Activate();
            }
        }

        private void Usage_Agreement_Load(object sender, EventArgs e)
        {
            //Icon = Properties.Resources.MassRepo_Icon;
            FormBorderStyle = FormBorderStyle.None;
            StartPosition = FormStartPosition.CenterScreen;
        }
    }
}