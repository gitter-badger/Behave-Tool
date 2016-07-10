using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Behave_Tool
{
    public partial class ChangeLog : ToolDefaultForm
    {
        public ChangeLog()
        {
            InitializeComponent();
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
    }
}
