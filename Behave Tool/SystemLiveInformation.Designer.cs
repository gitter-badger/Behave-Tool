namespace Behave_Tool
{
    partial class SystemLiveInformation
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.cpuUsage = new System.Windows.Forms.Label();
            this.CPUbar = new System.Windows.Forms.ProgressBar();
            this.NetworkTrafficUp = new System.Windows.Forms.Label();
            this.RAMbar = new System.Windows.Forms.ProgressBar();
            this.DrivesList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NetworkTrafficDown = new System.Windows.Forms.Label();
            this.ramUsage = new System.Windows.Forms.Label();
            this.CPU_Label = new System.Windows.Forms.Label();
            this.RAM_Label = new System.Windows.Forms.Label();
            this.Download_Label = new System.Windows.Forms.Label();
            this.Upload_Label = new System.Windows.Forms.Label();
            this.Storage_Label = new System.Windows.Forms.Label();
            this.showHide1 = new Behave_Tool.ShowHide();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Location = new System.Drawing.Point(1, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(214, 121);
            this.panel1.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.cpuUsage, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.CPUbar, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.NetworkTrafficUp, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.RAMbar, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.DrivesList, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.NetworkTrafficDown, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.ramUsage, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.CPU_Label, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.RAM_Label, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.Download_Label, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.Upload_Label, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.Storage_Label, 0, 6);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(215, 119);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // cpuUsage
            // 
            this.cpuUsage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cpuUsage.AutoSize = true;
            this.cpuUsage.BackColor = System.Drawing.Color.Transparent;
            this.cpuUsage.ForeColor = System.Drawing.Color.White;
            this.cpuUsage.Location = new System.Drawing.Point(116, 0);
            this.cpuUsage.Name = "cpuUsage";
            this.cpuUsage.Size = new System.Drawing.Size(35, 13);
            this.cpuUsage.TabIndex = 1;
            this.cpuUsage.Text = "CPU: ";
            this.cpuUsage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CPUbar
            // 
            this.CPUbar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CPUbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CPUbar.ForeColor = System.Drawing.Color.Red;
            this.CPUbar.Location = new System.Drawing.Point(84, 16);
            this.CPUbar.Name = "CPUbar";
            this.CPUbar.Size = new System.Drawing.Size(100, 5);
            this.CPUbar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.CPUbar.TabIndex = 7;
            // 
            // NetworkTrafficUp
            // 
            this.NetworkTrafficUp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NetworkTrafficUp.AutoSize = true;
            this.NetworkTrafficUp.BackColor = System.Drawing.Color.Transparent;
            this.NetworkTrafficUp.ForeColor = System.Drawing.Color.White;
            this.NetworkTrafficUp.Location = new System.Drawing.Point(120, 61);
            this.NetworkTrafficUp.Name = "NetworkTrafficUp";
            this.NetworkTrafficUp.Size = new System.Drawing.Size(27, 13);
            this.NetworkTrafficUp.TabIndex = 4;
            this.NetworkTrafficUp.Text = "Up: ";
            // 
            // RAMbar
            // 
            this.RAMbar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RAMbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.RAMbar.ForeColor = System.Drawing.Color.Red;
            this.RAMbar.Location = new System.Drawing.Point(84, 40);
            this.RAMbar.Name = "RAMbar";
            this.RAMbar.Size = new System.Drawing.Size(100, 5);
            this.RAMbar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.RAMbar.TabIndex = 8;
            // 
            // DrivesList
            // 
            this.DrivesList.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.DrivesList.BackColor = System.Drawing.Color.Black;
            this.DrivesList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DrivesList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.DrivesList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DrivesList.ForeColor = System.Drawing.Color.White;
            this.DrivesList.FullRowSelect = true;
            this.DrivesList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.DrivesList.HoverSelection = true;
            this.DrivesList.Location = new System.Drawing.Point(56, 77);
            this.DrivesList.Name = "DrivesList";
            this.DrivesList.Scrollable = false;
            this.DrivesList.Size = new System.Drawing.Size(156, 39);
            this.DrivesList.TabIndex = 1;
            this.DrivesList.UseCompatibleStateImageBehavior = false;
            this.DrivesList.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Width = 25;
            // 
            // columnHeader2
            // 
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 55;
            // 
            // columnHeader3
            // 
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 20;
            // 
            // columnHeader4
            // 
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 55;
            // 
            // NetworkTrafficDown
            // 
            this.NetworkTrafficDown.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NetworkTrafficDown.AutoSize = true;
            this.NetworkTrafficDown.BackColor = System.Drawing.Color.Transparent;
            this.NetworkTrafficDown.ForeColor = System.Drawing.Color.White;
            this.NetworkTrafficDown.Location = new System.Drawing.Point(113, 48);
            this.NetworkTrafficDown.Name = "NetworkTrafficDown";
            this.NetworkTrafficDown.Size = new System.Drawing.Size(41, 13);
            this.NetworkTrafficDown.TabIndex = 3;
            this.NetworkTrafficDown.Text = "Down: ";
            // 
            // ramUsage
            // 
            this.ramUsage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ramUsage.AutoSize = true;
            this.ramUsage.BackColor = System.Drawing.Color.Transparent;
            this.ramUsage.ForeColor = System.Drawing.Color.White;
            this.ramUsage.Location = new System.Drawing.Point(115, 24);
            this.ramUsage.Name = "ramUsage";
            this.ramUsage.Size = new System.Drawing.Size(37, 13);
            this.ramUsage.TabIndex = 2;
            this.ramUsage.Text = "RAM: ";
            this.ramUsage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CPU_Label
            // 
            this.CPU_Label.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.CPU_Label.AutoSize = true;
            this.CPU_Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.CPU_Label.Location = new System.Drawing.Point(18, 0);
            this.CPU_Label.Name = "CPU_Label";
            this.CPU_Label.Size = new System.Drawing.Size(32, 13);
            this.CPU_Label.TabIndex = 9;
            this.CPU_Label.Text = "CPU:";
            this.CPU_Label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // RAM_Label
            // 
            this.RAM_Label.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.RAM_Label.AutoSize = true;
            this.RAM_Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.RAM_Label.Location = new System.Drawing.Point(16, 24);
            this.RAM_Label.Name = "RAM_Label";
            this.RAM_Label.Size = new System.Drawing.Size(34, 13);
            this.RAM_Label.TabIndex = 10;
            this.RAM_Label.Text = "RAM:";
            this.RAM_Label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Download_Label
            // 
            this.Download_Label.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Download_Label.AutoSize = true;
            this.Download_Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Download_Label.Location = new System.Drawing.Point(12, 48);
            this.Download_Label.Name = "Download_Label";
            this.Download_Label.Size = new System.Drawing.Size(38, 13);
            this.Download_Label.TabIndex = 11;
            this.Download_Label.Text = "Down:";
            this.Download_Label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Upload_Label
            // 
            this.Upload_Label.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Upload_Label.AutoSize = true;
            this.Upload_Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Upload_Label.Location = new System.Drawing.Point(26, 61);
            this.Upload_Label.Name = "Upload_Label";
            this.Upload_Label.Size = new System.Drawing.Size(24, 13);
            this.Upload_Label.TabIndex = 12;
            this.Upload_Label.Text = "Up:";
            this.Upload_Label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Storage_Label
            // 
            this.Storage_Label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Storage_Label.AutoSize = true;
            this.Storage_Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Storage_Label.Location = new System.Drawing.Point(3, 74);
            this.Storage_Label.Name = "Storage_Label";
            this.Storage_Label.Size = new System.Drawing.Size(47, 13);
            this.Storage_Label.TabIndex = 13;
            this.Storage_Label.Text = "Storage:";
            // 
            // showHide1
            // 
            this.showHide1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.showHide1.BackColor = System.Drawing.Color.Fuchsia;
            this.showHide1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.showHide1.ForeColor = System.Drawing.Color.White;
            this.showHide1.Location = new System.Drawing.Point(0, 0);
            this.showHide1.Name = "showHide1";
            this.showHide1.Size = new System.Drawing.Size(241, 125);
            this.showHide1.TabIndex = 1;
            this.showHide1.Load += new System.EventHandler(this.showHide1_Load);
            // 
            // SystemLiveInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(241, 125);
            this.Controls.Add(this.showHide1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SystemLiveInformation";
            this.Opacity = 0.9D;
            this.ShowInTaskbar = false;
            this.Text = "SystemLiveInformation";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.Load += new System.EventHandler(this.SystemLiveInformation_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ShowHide showHide1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label cpuUsage;
        private System.Windows.Forms.ProgressBar CPUbar;
        private System.Windows.Forms.Label NetworkTrafficUp;
        private System.Windows.Forms.ProgressBar RAMbar;
        private System.Windows.Forms.ListView DrivesList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label NetworkTrafficDown;
        private System.Windows.Forms.Label ramUsage;
        private System.Windows.Forms.Label CPU_Label;
        private System.Windows.Forms.Label RAM_Label;
        private System.Windows.Forms.Label Download_Label;
        private System.Windows.Forms.Label Upload_Label;
        private System.Windows.Forms.Label Storage_Label;
    }
}