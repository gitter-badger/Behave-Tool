namespace MassRepo.Widget
{
    partial class WidgetAssembly
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ListViewGroup listViewGroup3 = new System.Windows.Forms.ListViewGroup("Performance", System.Windows.Forms.HorizontalAlignment.Center);
            System.Windows.Forms.ListViewGroup listViewGroup4 = new System.Windows.Forms.ListViewGroup("Utilities", System.Windows.Forms.HorizontalAlignment.Center);
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem(new string[] {
            "Clock",
            "Utilities"}, -1);
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem(new string[] {
            "CPU",
            "Performance"}, -1);
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem(new string[] {
            "RAM",
            "Performance"}, -1);
            this.widgetList = new System.Windows.Forms.ListView();
            this.widgetCollectionList = new System.Windows.Forms.ListView();
            this.PresetsList = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.addPresetButton = new System.Windows.Forms.Button();
            this.ClearMakerList = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // widgetList
            // 
            this.widgetList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.widgetList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.widgetList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            listViewGroup3.Header = "Performance";
            listViewGroup3.HeaderAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            listViewGroup3.Name = "Performance";
            listViewGroup4.Header = "Utilities";
            listViewGroup4.HeaderAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            listViewGroup4.Name = "Utilities";
            this.widgetList.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup3,
            listViewGroup4});
            this.widgetList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.widgetList.HoverSelection = true;
            listViewItem4.Group = listViewGroup4;
            listViewItem5.Group = listViewGroup3;
            listViewItem6.Group = listViewGroup3;
            this.widgetList.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem4,
            listViewItem5,
            listViewItem6});
            this.widgetList.Location = new System.Drawing.Point(389, 51);
            this.widgetList.MultiSelect = false;
            this.widgetList.Name = "widgetList";
            this.widgetList.Size = new System.Drawing.Size(179, 245);
            this.widgetList.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.widgetList.TabIndex = 1;
            this.widgetList.UseCompatibleStateImageBehavior = false;
            this.widgetList.View = System.Windows.Forms.View.SmallIcon;
            this.widgetList.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.widgetList_ItemDrag);
            this.widgetList.DragDrop += new System.Windows.Forms.DragEventHandler(this.widgetList_DragDrop);
            this.widgetList.DragEnter += new System.Windows.Forms.DragEventHandler(this.widgetList_DragEnter);
            // 
            // widgetCollectionList
            // 
            this.widgetCollectionList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.widgetCollectionList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.widgetCollectionList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.widgetCollectionList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.widgetCollectionList.HoverSelection = true;
            this.widgetCollectionList.Location = new System.Drawing.Point(189, 51);
            this.widgetCollectionList.MultiSelect = false;
            this.widgetCollectionList.Name = "widgetCollectionList";
            this.widgetCollectionList.Size = new System.Drawing.Size(136, 245);
            this.widgetCollectionList.TabIndex = 2;
            this.widgetCollectionList.UseCompatibleStateImageBehavior = false;
            this.widgetCollectionList.View = System.Windows.Forms.View.List;
            this.widgetCollectionList.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.WidgetCollectionList_ItemDrag);
            this.widgetCollectionList.DragDrop += new System.Windows.Forms.DragEventHandler(this.widgetCollectionList_DragDrop);
            this.widgetCollectionList.DragEnter += new System.Windows.Forms.DragEventHandler(this.widgetCollectionList_DragEnter);
            // 
            // PresetsList
            // 
            this.PresetsList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.PresetsList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PresetsList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.PresetsList.Location = new System.Drawing.Point(12, 51);
            this.PresetsList.MultiSelect = false;
            this.PresetsList.Name = "PresetsList";
            this.PresetsList.Size = new System.Drawing.Size(136, 245);
            this.PresetsList.TabIndex = 3;
            this.PresetsList.UseCompatibleStateImageBehavior = false;
            this.PresetsList.View = System.Windows.Forms.View.List;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(9, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Presets";
            // 
            // addPresetButton
            // 
            this.addPresetButton.Location = new System.Drawing.Point(104, 302);
            this.addPresetButton.Name = "addPresetButton";
            this.addPresetButton.Size = new System.Drawing.Size(44, 23);
            this.addPresetButton.TabIndex = 5;
            this.addPresetButton.Text = "New";
            this.addPresetButton.UseVisualStyleBackColor = true;
            // 
            // ClearMakerList
            // 
            this.ClearMakerList.Location = new System.Drawing.Point(281, 302);
            this.ClearMakerList.Name = "ClearMakerList";
            this.ClearMakerList.Size = new System.Drawing.Size(44, 23);
            this.ClearMakerList.TabIndex = 6;
            this.ClearMakerList.Text = "Clear";
            this.ClearMakerList.UseVisualStyleBackColor = true;
            this.ClearMakerList.Click += new System.EventHandler(this.ClearMakerList_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(186, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Widget Structure";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(386, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Widget List";
            // 
            // WidgetMaker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(596, 418);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ClearMakerList);
            this.Controls.Add(this.addPresetButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PresetsList);
            this.Controls.Add(this.widgetCollectionList);
            this.Controls.Add(this.widgetList);
            this.Name = "WidgetMaker";
            this.Load += new System.EventHandler(this.WidgetMaker_Load);
            this.Controls.SetChildIndex(this.widgetList, 0);
            this.Controls.SetChildIndex(this.widgetCollectionList, 0);
            this.Controls.SetChildIndex(this.PresetsList, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.addPresetButton, 0);
            this.Controls.SetChildIndex(this.ClearMakerList, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView widgetList;
        private System.Windows.Forms.ListView widgetCollectionList;
        private System.Windows.Forms.ListView PresetsList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addPresetButton;
        private System.Windows.Forms.Button ClearMakerList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}