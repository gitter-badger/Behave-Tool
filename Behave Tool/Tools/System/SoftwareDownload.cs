using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Xml;
using System.Reflection;
using System.IO;

namespace Behave_Tool
{
    public partial class SoftwareDownload : Form
    {
        public SoftwareDownload()
        {
            InitializeComponent();
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in Browsers.CheckedItems)
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
            foreach (ListViewItem item in Benchmark.CheckedItems)
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
            getLinks();
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
            }
            catch (Exception ex)
            {
                Tools.Misc.SaveError(ex.ToString());
            }
        }

        private void Benchmark_ItemChecked(object sender, ItemCheckedEventArgs e)
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
        private void getLinks()
        {
            Assembly a = Assembly.GetExecutingAssembly();
         

            List<string> links = new List<string>();

            XmlDocument xmlDoc = new XmlDocument();
            try
            {

                xmlDoc.Load(a.GetManifestResourceStream("SoftwareDownloadLinks.xml"));
                XmlNodeList nodeList = xmlDoc.SelectNodes("//SoftwareDownload");
                foreach (XmlNode node in nodeList)
                {
                    foreach (XmlNode childNode in node.ChildNodes)
                    {
                        links.Add(childNode.Value.ToString());
                    }
                }
                string link = string.Join(",", links.ToArray());
                MessageBox.Show(link);
            } catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
                    
        }
    }
}

