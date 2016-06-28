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
            startPosition();
            originalWidth = Width;
            widthToggle();

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

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg != 132)
                return;
            m.Result = (IntPtr)2;
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {


            }
        }

        private void ShowHideToggle_CheckStateChanged(object sender, EventArgs e)
        {


            t.Start();
            //if (ShowHideToggle.Checked) //checked = expand form
            //{
            //    ShowHideToggle.Text = "<";
            //    while (Width < originalWidth)
            //    {
            //        Width++;
            //        Application.DoEvents();// stops form freezing
            //    }
            //}
            //else
            //{
            //    ShowHideToggle.Text = ">";
            //    while (Width > 24)
            //    {
            //        Width--;
            //        Application.DoEvents();// stops form freezing
            //    }
            //}
        }
        Timer t = new Timer();
        private void widthToggle()
        {

            t.Interval = 15;

            t.Tick += delegate
            {
                if (!ShowHideToggle.Checked) //collapse
                {
                    if (Width > 24) // Set Form.MinimumSize to this otherwise the Timer will keep going, so it will permanently try to decrease the size.
                    {
                        Width -= 10;
                    }
                    else
                    {
                        ShowHideToggle.Text = ">";
                        t.Stop();
                    }
                }
                else
                {
                    if (Width < originalWidth)
                    {
                        Width += 10;
                    }
                    else
                    {
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
    }
}