using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Behave_Tool
{
    
    public partial class ToolDefaultForm : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        public ToolDefaultForm()
        {
            InitializeComponent();
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

        private void ToolBar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
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
        private void ToolDefaultForm_Load(object sender, EventArgs e)
        {
            
            Icon = Properties.Resources.Behave_Icon;
            BringToFront();
            Username.Text = Login.loggedInAs;
            ToolName.Text = getFormName();
            if (ToolName.Text == "Change Log")
            {
                Minimize.Enabled = false;
            }
                ToolBar.Renderer = new MySR();
        }
        
    }

}
