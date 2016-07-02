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

        private void Close_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void ToolDefaultForm_Load(object sender, EventArgs e)
        {
            Username.Text = Login.loggedInAss;
            ToolName.Text = getFormName();
            ToolBar.Renderer = new MySR();
        }
        public class MySR : ToolStripSystemRenderer
        {
            public MySR() { }

            protected override void OnRenderToolStripBorder(ToolStripRenderEventArgs e)
            {
                
                //base.OnRenderToolStripBorder(e);
            }
        }
    }

}
