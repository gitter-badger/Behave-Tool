using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Behave_Tool.CustomControls
{
    public partial class WidgetMakerList : UserControl
    {
        public WidgetMakerList()
        {
            InitializeComponent();
        }

        void listView1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        void listView1_DragDrop(object sender, DragEventArgs e)
        {
            listView1.Items.Add(e.Data.ToString());

        }

        private void ListViewDragDrop_Load(object sender, EventArgs e)
        {
            listView1.AllowDrop = true;
            listView1.DragDrop += new DragEventHandler(listView1_DragDrop);
            listView1.DragEnter += new DragEventHandler(listView1_DragEnter);
        }

        private void DragDrop_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (listView1.FocusedItem.Bounds.Contains(e.Location) == true)
                {
                    //options.Show(Cursor.Position);
                }
            }
        }

    }
}
