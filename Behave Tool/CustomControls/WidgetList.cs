using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Behave_Tool.Widget
{
    public partial class WidgetList : UserControl
    {
        ContextMenuStrip options = new ContextMenuStrip();
        public WidgetList()
        {
            InitializeComponent();
        }
        //void DragDrop_DragEnter(object sender, DragEventArgs e)
        //{
        //    e.Effect = DragDropEffects.Copy;
        //}

        //void DragDrop_DragDrop(object sender, DragEventArgs e)
        //{
        //    DragDrop.Items.Add(e.Data.ToString());

        //}

        private void fillWidgetList()
        {


        }
        private void ListViewDragDrop_Load(object sender, EventArgs e)
        {
            List.Groups.Add(new ListViewGroup("System", HorizontalAlignment.Left));

            ListViewItem systemPerformance = new ListViewItem();
            var myGroup = List.Groups["System"];
            var cpu = new ListViewItem { Text = "CPU", Tag = "", Group = myGroup };
            var ram = new ListViewItem { Text = "RAM", Tag = "", Group = myGroup };
            List.Items.Add(cpu);
            List.Items.Add(ram);
            //systemPerformance.SubItems.Add(cpu);
            //List.Items.Add(systemPerformance);

            options.Items.Add("Show Example");
            options.Items.Add("Remove");


            //DragDrop.AllowDrop = true;
            //DragDrop.DragDrop += new DragEventHandler(DragDrop_DragDrop);
            //List.DragEnter += new DragEventHandler(DragDrop_DragEnter);
        }

        private void DragDrop_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (List.FocusedItem.Bounds.Contains(e.Location) == true)
                {
                    options.Show(Cursor.Position);
                }
            }
        }

        private void List_ItemDrag(object sender, ItemDragEventArgs e)
        {
            DoDragDrop(e.Item, DragDropEffects.Move);
        }
    }
}
