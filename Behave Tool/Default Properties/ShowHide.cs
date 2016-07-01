using System;
using System.Drawing;
using System.Windows.Forms;

namespace Behave_Tool
{
    public partial class ShowHide : Form
    {
        private int originalWidth;
        public ShowHide()
        {
            InitializeComponent();

        }
        private void startPosition()
        {
            StartPosition = FormStartPosition.Manual;
            Location = new Point(0, (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2);
        }
        private void checkBox1_Checked_Changed(object sender, EventArgs e)
        {

        }

        private void ShowHide_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {


            }
        }

        private void ShowHideToggle_CheckStateChanged(object sender, EventArgs e)
        {
            ShowHideToggle.Visible = false;
            t.Start();
            
        }
        Timer t = new Timer();
        private void widthToggle()
        {

            t.Interval = 14;

            t.Tick += delegate
            {
                if (!ShowHideToggle.Checked) //collapse
                {
                    if (Width > 24) // Set Form.MinimumSize to this otherwise the Timer will keep going, so it will permanently try to decrease the size.
                    {
                        Width -= 15;
                    }
                    else
                    {
                        ShowHideToggle.Visible = true;
                        ShowHideToggle.Text = ">";
                        t.Stop();
                    }
                }
                else
                {
                    if (Width < originalWidth)
                    {
                        Width += 15;
                    }
                    else
                    {
                        ShowHideToggle.Visible = true;
                        ShowHideToggle.Text = "<";
                        t.Stop();
                    }
                }
            };
        }
        private void Option()
        {
            ContextMenu cm = new ContextMenu();
            cm.MenuItems.Add("Lock Position");
            cm.MenuItems.Add("Item 2");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void ShowHide_Load(object sender, EventArgs e)
        {
            startPosition();
            originalWidth = Width;
            widthToggle();
            AutoSize = true;
        }
    }
}