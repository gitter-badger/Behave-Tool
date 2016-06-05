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


        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox1.MaxLength = 1;
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
               // int durationMilliseconds = 10000;
               // ToolTip1.Show(ToolTip1.GetToolTip(PictureBox1), PictureBox1, durationMilliseconds);

            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}