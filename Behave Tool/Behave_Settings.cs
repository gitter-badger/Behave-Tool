using System;
using System.Drawing;
using System.Windows.Forms;

namespace Behave_Tool
{
    public partial class Behave_Settings : Form
    {
        public Behave_Settings()
        {
            InitializeComponent();
            TopMost = true;
            var colour1 = ColorTranslator.FromHtml(Properties.Settings.Default.Text1_Colour);
            var colour2 = ColorTranslator.FromHtml(Properties.Settings.Default.Text2_Colour);
            Text1_Label.ForeColor = colour1;
            Text2_Label.ForeColor = colour2;
            Text1_Colour.Text = Properties.Settings.Default.Text1_Colour;
            Text2_Colour.Text = Properties.Settings.Default.Text2_Colour;
            checkBox1.Checked = Properties.Settings.Default.KeepWindowOnTop;
        }

        private void SaveSettings_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default["Text1_Colour"] = Text1_Colour.Text;
            Properties.Settings.Default["Text2_Colour"] = Text2_Colour.Text;

            Properties.Settings.Default.Save();
            new Restarting().Show();
            Restarting.restartNow();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBox1.Checked)
            {
                Properties.Settings.Default.KeepWindowOnTop = true;
            }
            else
            {
                Properties.Settings.Default.KeepWindowOnTop = false;
            }
            Properties.Settings.Default.Save();
        }

        public void trackBar1_Scroll(object sender, EventArgs e)
        {
            double op = Properties.Settings.Default.BehaveOpacity;

            Opacity = trackBar1.Value * 0.1;
            Properties.Settings.Default["BehaveOpacity"] = trackBar1.Value;
        }
    }
}