using System;
using System.Windows.Forms;

namespace Behave_Tool
{
    public partial class PanelOptions : Form
    {
        public PanelOptions()
        {
            InitializeComponent();
            
        }

        private void Lock_Click(object sender, EventArgs e)
        {
        }

        private void Close_Click(object sender, EventArgs e)
        {
            ParentForm.Close();
        }
    }
}