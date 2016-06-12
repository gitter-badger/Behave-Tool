using System;
using System.Windows.Forms;

namespace Behave_Tool
{
    public partial class Html_Downloader : Form
    {
        public Html_Downloader()
        {
            InitializeComponent();
        }
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg != 132)
                return;
            m.Result = (IntPtr)2;
        }
    }
}