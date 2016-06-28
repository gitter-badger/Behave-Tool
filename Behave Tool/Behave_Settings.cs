using Behave_Tool.Tools;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;
namespace Behave_Tool
{
    public partial class Behave_Settings : Form
    {

        private string[] colourList = { "Black", "White", "Red", "Green", "Lime",
            "Blue", "cyan", "Magenta", "Yellow", "Aqua", "Fuchsia", "Navy", "Teal",
            "Olive", "Maroon", "Gray", "Silver", "Purple", "Orange" };

        public Behave_Settings()
        {
            InitializeComponent();
            TopMost = Properties.Settings.Default.KeepWindowOnTop;
            var colour1 = ColorTranslator.FromHtml(Properties.Settings.Default.Text1_Colour);
            var colour2 = ColorTranslator.FromHtml(Properties.Settings.Default.Text2_Colour);
            var colour3 = ColorTranslator.FromHtml(Properties.Settings.Default.Text3_Colour);
            Text1_Label.ForeColor = colour1;
            Text2_Label.ForeColor = colour2;
            Text3_Label.ForeColor = colour3;
            Text1_Colour.Text = Properties.Settings.Default.Text1_Colour;
            Text2_Colour.Text = Properties.Settings.Default.Text2_Colour;
            Text3_Colour.Text = Properties.Settings.Default.Text3_Colour;
            checkBox1.Checked = Properties.Settings.Default.KeepWindowOnTop;
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg != 132)
                return;
            m.Result = (IntPtr)2;
        }

        private void SaveSettings_Click(object sender, EventArgs e)
        {
            try
            {
                Properties.Settings.Default["Text1_Colour"] = Text1_Colour.Text;
                Properties.Settings.Default["Text2_Colour"] = Text2_Colour.Text;
                Properties.Settings.Default["Text3_Colour"] = Text3_Colour.Text;
                Properties.Settings.Default.Save();
                new Restarting().Show();
                Restarting.restartNow();
            }
            catch (Exception ex)
            {
                Misc.SaveError(ex.ToString());
            }
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

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(e.Link.LinkData as string);
        }

        private void backgroundSelecter_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                switch (backgroundSelecter.SelectedIndex)
                {
                    case 0:
                        //if (Properties.Settings.Default.BackgroundImg != "OrangeCore1")
                        // {
                        Properties.Settings.Default["BackgroundImg"] = "OrangeCore1";
                        // }
                        pictureBox1.BackgroundImage = Properties.Resources.Background_OrangeCore1;
                        break;

                    case 1:
                        Properties.Settings.Default["BackgroundImg"] = "SnowFlake1";
                        pictureBox1.BackgroundImage = Properties.Resources.Background_SnowFlake1;
                        break;

                    case 2:
                        Properties.Settings.Default["BackgroundImg"] = "SnowFlake2";
                        pictureBox1.BackgroundImage = Properties.Resources.Background_SnowFlake2;
                        break;

                    case 3:
                        Properties.Settings.Default["BackgroundImg"] = "GlassWindows1";
                        pictureBox1.BackgroundImage = Properties.Resources.Background_GlassWindows1;
                        break;

                    case 4:
                        Properties.Settings.Default["BackgroundImg"] = "FireFlower1";
                        pictureBox1.BackgroundImage = Properties.Resources.Background_FireFlower1;
                        break;
                }
            }
            catch (Exception ex)
            {
                Misc.SaveError(ex.ToString());
            }
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ColourDiag1_Click(object sender, EventArgs e)
        {
            // Show the color dialog.
            ColorDialog dlg = new ColorDialog();
            //dlg.ShowDialog();
            // See if user pressed ok.
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string str = null;
                str = dlg.Color.Name;
                if (colourList.Contains(str))
                {
                    Text1_Colour.Text = str;
                }
                else
                {
                    Text1_Colour.Text = "#" + str;
                }
            }
        }

        private void ColourDiag2_Click(object sender, EventArgs e)
        {
            // Show the color dialog.
            ColorDialog dlg = new ColorDialog();
            //dlg.ShowDialog();
            // See if user pressed ok.
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string str = null;
                str = dlg.Color.Name;
                if (colourList.Contains(str))
                {
                    Text2_Colour.Text = str;
                }
                else
                {
                    Text2_Colour.Text = "#" + str;
                }
            }
        }

        private void ColourDiag3_Click(object sender, EventArgs e)
        {
            // Show the color dialog.
            ColorDialog dlg = new ColorDialog();
            // dlg.ShowDialog();
            // See if user pressed ok.
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string str = null;
                str = dlg.Color.Name;
                if (colourList.Contains(str))
                {
                    Text3_Colour.Text = str;
                }
                else
                {
                    Text3_Colour.Text = "#" + str;
                }
            }
        }

        private void Text2_Colour_TextChanged(object sender, EventArgs e)
        {
            Text2_Label.ForeColor = ColorTranslator.FromHtml(Text2_Colour.Text);
        }

        private void Text1_Colour_TextChanged(object sender, EventArgs e)
        {
            Text1_Label.ForeColor = ColorTranslator.FromHtml(Text1_Colour.Text);
        }
        private void Text3_Colour_TextChanged(object sender, EventArgs e)
        {
            Text3_Label.ForeColor = ColorTranslator.FromHtml(Text3_Colour.Text);
        }
    }
}