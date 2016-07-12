using System;
using System.Data;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace MassRepo
{
    public partial class StorageDrives : UserControl
    {
        public StorageDrives()
        {
            InitializeComponent();
            AvailableDrives();
        }

        private void AvailableDrives()
        {
            while (true)
            {
                DrivesList.HeaderStyle = ColumnHeaderStyle.None;
                // Here we create a DataTable with four columns.
                DataTable table = new DataTable();

                table.Columns.Add("Drive", typeof(string));
                table.Columns.Add("Using", typeof(string));
                table.Columns.Add("Total", typeof(string));
                table.Columns.Add("seperator", typeof(string));

                // string rowdata;
                string name;
                string usingSpace = null;
                string totalSpace = null;
                string seperator = "/";

                DriveInfo[] allDrives = DriveInfo.GetDrives();

                foreach (DriveInfo d in allDrives)
                {
                    if (d.IsReady == true)
                    {
                        name = d.Name + " ";
                        if ((d.TotalSize / 1024 / 1024 / 1024) - (d.TotalFreeSpace / 1024 / 1024 / 1024) < 1000)
                        {
                            usingSpace = (d.TotalSize / 1024 / 1024 / 1024) - (d.TotalFreeSpace / 1024 / 1024 / 1024) + " GB";
                        }
                        else if ((d.TotalSize / 1024 / 1024 / 1024) - (d.TotalFreeSpace / 1024 / 1024 / 1024) >= 1000)
                        {
                            usingSpace = Math.Round(d.TotalSize / 1024 / 1024 / 1024 / 1024 - (float)(d.TotalFreeSpace / 1024 / 1024 / 1024 / 1024), 2) + " TB";
                        }
                        if ((d.TotalSize / 1024 / 1024 / 1024) < 1000)
                        {
                            totalSpace = (d.TotalSize / 1024 / 1024 / 1024).ToString() + " GB";
                        }
                        else if ((d.TotalSize / 1024 / 1024 / 1024) >= 1000)
                        {
                            totalSpace = Math.Round(((float)d.TotalSize / 1024 / 1024 / 1024 / 1024), 2).ToString() + " TB";
                        }
                        table.Rows.Add(d.Name, usingSpace, seperator, totalSpace);
                    }
                }
                foreach (DataRow d in table.Rows)
                {
                    ListViewItem item = new ListViewItem(d[0].ToString());
                    for (int i = 1; i < table.Columns.Count; i++)
                    {
                        item.SubItems.Add(d[i].ToString());
                    }
                    DrivesList.Items.Add(item);
                }

                Thread.Sleep(5000);
                DrivesList.Items.Clear();
                DrivesList.Update();
                DrivesList.Refresh();
            }
        }

        private void UpdateList(DataTable table)
        {
            //ListView DrivesList3 = new ListView();

            //foreach (DataRow d in table.Rows)
            //{
            //    ListViewItem item = new ListViewItem(d[0].ToString());
            //    for (int i = 1; i < table.Columns.Count; i++)
            //    {
            //        item.SubItems.Add(d[i].ToString());
            //    }
            //    DrivesList2.Items.Add(item);
            //}

            //foreach (DataRow row in table.Rows)
            //{
            //    foreach (DataColumn column in table.Columns)
            //    {
            //        var field1 = row[column].ToString();
            //        if (DrivesList.Items.)
            //    }

            //    foreach (ListView rows in DrivesList.Items)
            //    {
            //        foreach (ListView column in rows.Items)
            //        {
            //        }
            //    }
            //}
        }
    }
}