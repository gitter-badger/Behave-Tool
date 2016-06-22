using Behave_Tool.Tools;
using System;
using System.Diagnostics;
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

                Properties.Settings.Default.Save();
                new Restarting().Show();
                Restarting.restartNow();
            }catch(Exception ex)
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
            } catch(Exception ex)
            {
                Misc.SaveError(ex.ToString());
            }
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}