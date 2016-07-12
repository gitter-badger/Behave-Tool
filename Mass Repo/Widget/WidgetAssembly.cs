using System.Collections.Generic;
using System.Windows.Forms;

namespace MassRepo.Widget
{
    public partial class WidgetAssembly : ToolDefaultForm
    {
        public WidgetAssembly()
        {
            InitializeComponent();
            fillWidgetList();
        }

        private void fillWidgetList()
        {
            //ListViewGroup group1 = new ListViewGroup("System");
            //widgetList.Groups.AddRange(new ListViewGroup[] { group1});

            //var cpu = new ListViewItem { Text = "CPU", Tag = "", Group = group1 };
            //var ram = new ListViewItem { Text = "RAM", Tag = "", Group = group1 };
            //widgetList.Items.Add(cpu);
            //widgetList.Items.Add(ram);
        }

        private void widgetList_ItemDrag(object sender, ItemDragEventArgs e)
        {
            // create array or collection for all selected items
            var items = new List<ListViewItem>();
            // add dragged one first
            items.Add((ListViewItem)e.Item);
            // optionally add the other selected ones
            foreach (ListViewItem lvi in widgetList.SelectedItems)
            {
                if (!items.Contains(lvi))
                {
                    items.Add(lvi);
                }
            }
            // pass the items to move...
            widgetList.DoDragDrop(items, DragDropEffects.Move);
        }

        private void widgetCollectionList_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(List<ListViewItem>)))
            {
                e.Effect = DragDropEffects.Move;
            }
        }

        private void widgetCollectionList_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(List<ListViewItem>)))
            {
                var items = (List<ListViewItem>)e.Data.GetData(typeof(List<ListViewItem>));
                // move to dest LV
                foreach (ListViewItem lvi in items)
                {
                    // LVI obj can only belong to one LVI, remove
                    lvi.ListView.Items.Remove(lvi);
                    //lvi.Group = widgetList.Groups[lvi.SubItems[1].Text];   // gets text from subitem  aka group
                    lvi.BackColor = widgetCollectionList.BackColor;
                    lvi.ForeColor = widgetCollectionList.ForeColor;
                    widgetCollectionList.Items.Add(lvi);
                }
            }
        }

        private void WidgetMaker_Load(object sender, System.EventArgs e)
        {
            widgetCollectionList.HoverSelection = false;
            widgetCollectionList.HideSelection = true;

            widgetList.HoverSelection = false;
            widgetList.HideSelection = true;
            widgetCollectionList.AllowDrop = true;
            widgetCollectionList.DragDrop += new DragEventHandler(widgetCollectionList_DragDrop);
            widgetList.AllowDrop = true;
            widgetList.DragDrop += new DragEventHandler(widgetList_DragDrop);
        }

        private void WidgetCollectionList_ItemDrag(object sender, ItemDragEventArgs e)
        {
            // create array or collection for all selected items
            var items = new List<ListViewItem>();
            // add dragged one first
            items.Add((ListViewItem)e.Item);
            // optionally add the other selected ones
            foreach (ListViewItem lvi in widgetCollectionList.SelectedItems)
            {
                if (!items.Contains(lvi))
                {
                    items.Add(lvi);
                }
            }
            // pass the items to move...
            widgetCollectionList.DoDragDrop(items, DragDropEffects.Move);
        }

        private void widgetList_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(List<ListViewItem>)))
            {
                e.Effect = DragDropEffects.Move;
            }
        }

        private void widgetList_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(List<ListViewItem>)))
            {
                var items = (List<ListViewItem>)e.Data.GetData(typeof(List<ListViewItem>));
                // move to dest LV
                foreach (ListViewItem lvi in items)
                {
                    // LVI obj can only belong to one LVI, remove
                    lvi.ListView.Items.Remove(lvi);
                    lvi.Group = widgetList.Groups[lvi.SubItems[1].Text];  // gets text from subitem  aka group
                    lvi.BackColor = widgetList.BackColor;
                    lvi.ForeColor = widgetList.ForeColor;
                    widgetList.Items.Add(lvi);
                }
            }
        }

        private void ClearMakerList_Click(object sender, System.EventArgs e)
        {
            foreach (ListViewItem item in widgetCollectionList.Items)
            {
                item.Remove();
                item.Group = widgetList.Groups[item.SubItems[1].Text];
                item.BackColor = widgetList.BackColor;
                item.ForeColor = widgetList.ForeColor;
                widgetList.Items.Add((ListViewItem)item.Clone());
            }
        }
    }
}