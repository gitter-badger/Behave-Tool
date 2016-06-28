using System;
using System.Collections;
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
    public partial class FreshSystemStarter : Form
    {
        public FreshSystemStarter()
        {
            InitializeComponent();
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            foreach(ListViewItem item in Browsers.CheckedItems)
            {
                item.Checked = false;
            }
            foreach (ListViewItem item in Utilities.CheckedItems)
            {
                item.Checked = false;
            }
            foreach (ListViewItem item in Runtimes.CheckedItems)
            {
                item.Checked = false;
            }
            foreach (ListViewItem item in AntiVirus.CheckedItems)
            {
                item.Checked = false;
            }
            foreach (ListViewItem item in Media.CheckedItems)
            {
                item.Checked = false;
            }
            foreach (ListViewItem item in Other.CheckedItems)
            {
                item.Checked = false;
            }
            foreach (ListViewItem item in Server.CheckedItems)
            {
                item.Checked = false;
            }
            foreach (ListViewItem item in DevTools.CheckedItems)
            {
                item.Checked = false;
            }
        }

        private void Browsers_ItemChecked(object sender, ItemCheckedEventArgs e)
        {

            ListViewItem item = e.Item;
            if (!e.Item.Checked)
            {

                foreach (ListViewItem i in DownloadList.Items)
                {
                    if (i.Text == item.Text)
                    {
                        i.Remove();
                    }
                }
            }
            else
            {

                DownloadList.Items.Add((ListViewItem)item.Clone());

            }


        }

        private void Utilities_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            ListViewItem item = e.Item;
            if (!e.Item.Checked)
            {

                foreach (ListViewItem i in DownloadList.Items)
                {
                    if (i.Text == item.Text)
                    {
                        i.Remove();
                    }
                }
            }
            else
            {

                DownloadList.Items.Add((ListViewItem)item.Clone());

            }
        }

        private void Runtimes_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            ListViewItem item = e.Item;
            if (!e.Item.Checked)
            {

                foreach (ListViewItem i in DownloadList.Items)
                {
                    if (i.Text == item.Text)
                    {
                        i.Remove();
                    }
                }
            }
            else
            {

                DownloadList.Items.Add((ListViewItem)item.Clone());

            }
        }

        

        private void AntiVirus_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            ListViewItem item = e.Item;
            if (!e.Item.Checked)
            {

                foreach (ListViewItem i in DownloadList.Items)
                {
                    if (i.Text == item.Text)
                    {
                        i.Remove();
                    }
                }
            }
            else
            {

                DownloadList.Items.Add((ListViewItem)item.Clone());

            }
        }

        private void Media_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            ListViewItem item = e.Item;
            if (!e.Item.Checked)
            {

                foreach (ListViewItem i in DownloadList.Items)
                {
                    if (i.Text == item.Text)
                    {
                        i.Remove();
                    }
                }
            }
            else
            {

                DownloadList.Items.Add((ListViewItem)item.Clone());

            }
        }

        private void Other_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            ListViewItem item = e.Item;
            if (!e.Item.Checked)
            {

                foreach (ListViewItem i in DownloadList.Items)
                {
                    if (i.Text == item.Text)
                    {
                        i.Remove();
                    }
                }
            }
            else
            {

                DownloadList.Items.Add((ListViewItem)item.Clone());

            }
        }

        private void Server_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            ListViewItem item = e.Item;
            if (!e.Item.Checked)
            {

                foreach (ListViewItem i in DownloadList.Items)
                {
                    if (i.Text == item.Text)
                    {
                        i.Remove();
                    }
                }
            }
            else
            {

                DownloadList.Items.Add((ListViewItem)item.Clone());

            }
        }

        private void DevTools_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            ListViewItem item = e.Item;
            if (!e.Item.Checked)
            {

                foreach (ListViewItem i in DownloadList.Items)
                {
                    if (i.Text == item.Text)
                    {
                        i.Remove();
                    }
                }
            }
            else
            {

                DownloadList.Items.Add((ListViewItem)item.Clone());

            }
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            try
            {
                //string[,] downloadLinks = new string[];
                ArrayList links = new ArrayList();
                foreach (ListViewItem item in DownloadList.Items)
                {
                    links.Add(item.GetSubItemAt(0, 0).Text);
                }
                foreach (string str in links)
                {
                    MessageBox.Show(str);
                }
            } catch (Exception ex)
            {
                Tools.Misc.SaveError(ex.ToString());
            }
        }
    }
}

