using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Behave_Tool
{
    public partial class ShowHide : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

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

        private void ShowHide_Load(object sender, EventArgs e)
        {
            toolStrip1.Renderer = new MySR();
            WidgetName.Text = getFormName();
            startPosition();
            originalWidth = Width;
            widthToggle();
            AutoSize = true;
        }
        private string getFormName()
        {
            string formname = GetType().Name;
            formname = Regex.Replace(formname, "([a-z])([A-Z])", "$1 $2");
            return formname;
        }
        private void Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void toolStrip1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
    
}