﻿namespace Behave_Tool
{
    partial class Behave
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Behave));
            this.ToolBar = new System.Windows.Forms.ToolStrip();
            this.Menu = new System.Windows.Forms.ToolStripDropDownButton();
            this.stuffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LocalNetworkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tCPConnectionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openPortScannerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.localHostScannerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toysToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entertainMeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.systemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.performanceMonitorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preset1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.IPrefresh = new System.Windows.Forms.ToolStripButton();
            this.IPdisplay = new System.Windows.Forms.ToolStripSplitButton();
            this.releaseIPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renewIPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Close = new System.Windows.Forms.ToolStripButton();
            this.MaximizeNormalize = new System.Windows.Forms.ToolStripButton();
            this.Minimize = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.Settings = new System.Windows.Forms.ToolStripButton();
            this.SessionTimer = new System.Windows.Forms.Label();
            this.TotalSessionTime = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ToolBar.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ToolBar
            // 
            this.ToolBar.BackColor = System.Drawing.Color.Black;
            this.ToolBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ToolBar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.ToolBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu,
            this.toolStripSeparator1,
            this.IPrefresh,
            this.IPdisplay,
            this.Close,
            this.MaximizeNormalize,
            this.Minimize,
            this.toolStripSeparator2,
            this.Settings});
            this.ToolBar.Location = new System.Drawing.Point(0, 0);
            this.ToolBar.Name = "ToolBar";
            this.ToolBar.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.ToolBar.Size = new System.Drawing.Size(1003, 34);
            this.ToolBar.TabIndex = 0;
            this.ToolBar.Text = "toolStrip1";
            // 
            // Menu
            // 
            this.Menu.BackColor = System.Drawing.Color.Black;
            this.Menu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Menu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stuffToolStripMenuItem,
            this.toysToolStripMenuItem,
            this.systemToolStripMenuItem});
            this.Menu.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Menu.ForeColor = System.Drawing.Color.White;
            this.Menu.Image = ((System.Drawing.Image)(resources.GetObject("Menu.Image")));
            this.Menu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Menu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(62, 31);
            this.Menu.Text = "Menu";
            // 
            // stuffToolStripMenuItem
            // 
            this.stuffToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.stuffToolStripMenuItem.BackgroundImage = global::Behave_Tool.Properties.Resources.Button;
            this.stuffToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.stuffToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LocalNetworkToolStripMenuItem});
            this.stuffToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stuffToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.stuffToolStripMenuItem.Name = "stuffToolStripMenuItem";
            this.stuffToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0);
            this.stuffToolStripMenuItem.Size = new System.Drawing.Size(152, 20);
            this.stuffToolStripMenuItem.Text = "Network";
            // 
            // LocalNetworkToolStripMenuItem
            // 
            this.LocalNetworkToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.LocalNetworkToolStripMenuItem.BackgroundImage = global::Behave_Tool.Properties.Resources.Button;
            this.LocalNetworkToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LocalNetworkToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tCPConnectionsToolStripMenuItem,
            this.openPortScannerToolStripMenuItem,
            this.localHostScannerToolStripMenuItem});
            this.LocalNetworkToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.LocalNetworkToolStripMenuItem.Name = "LocalNetworkToolStripMenuItem";
            this.LocalNetworkToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.LocalNetworkToolStripMenuItem.Text = "Local Network";
            this.LocalNetworkToolStripMenuItem.Click += new System.EventHandler(this.localPortScannerToolStripMenuItem_Click);
            // 
            // tCPConnectionsToolStripMenuItem
            // 
            this.tCPConnectionsToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.tCPConnectionsToolStripMenuItem.BackgroundImage = global::Behave_Tool.Properties.Resources.Button;
            this.tCPConnectionsToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tCPConnectionsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.tCPConnectionsToolStripMenuItem.Name = "tCPConnectionsToolStripMenuItem";
            this.tCPConnectionsToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0);
            this.tCPConnectionsToolStripMenuItem.Size = new System.Drawing.Size(175, 20);
            this.tCPConnectionsToolStripMenuItem.Text = "TCP Connections";
            this.tCPConnectionsToolStripMenuItem.Click += new System.EventHandler(this.tCPConnectionsToolStripMenuItem_Click);
            // 
            // openPortScannerToolStripMenuItem
            // 
            this.openPortScannerToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.openPortScannerToolStripMenuItem.BackgroundImage = global::Behave_Tool.Properties.Resources.Button;
            this.openPortScannerToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.openPortScannerToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.openPortScannerToolStripMenuItem.Name = "openPortScannerToolStripMenuItem";
            this.openPortScannerToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.openPortScannerToolStripMenuItem.Text = "Open Port Scanner";
            this.openPortScannerToolStripMenuItem.Click += new System.EventHandler(this.openPortScannerToolStripMenuItem_Click);
            // 
            // localHostScannerToolStripMenuItem
            // 
            this.localHostScannerToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.localHostScannerToolStripMenuItem.BackgroundImage = global::Behave_Tool.Properties.Resources.Button;
            this.localHostScannerToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.localHostScannerToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.localHostScannerToolStripMenuItem.Name = "localHostScannerToolStripMenuItem";
            this.localHostScannerToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0);
            this.localHostScannerToolStripMenuItem.Size = new System.Drawing.Size(175, 20);
            this.localHostScannerToolStripMenuItem.Text = "Local Host Scanner";
            this.localHostScannerToolStripMenuItem.Click += new System.EventHandler(this.localHostScannerToolStripMenuItem_Click);
            // 
            // toysToolStripMenuItem
            // 
            this.toysToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.toysToolStripMenuItem.BackgroundImage = global::Behave_Tool.Properties.Resources.Button;
            this.toysToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.toysToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.entertainMeToolStripMenuItem});
            this.toysToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toysToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.toysToolStripMenuItem.Name = "toysToolStripMenuItem";
            this.toysToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0);
            this.toysToolStripMenuItem.Size = new System.Drawing.Size(152, 20);
            this.toysToolStripMenuItem.Text = "Toys";
            // 
            // entertainMeToolStripMenuItem
            // 
            this.entertainMeToolStripMenuItem.BackgroundImage = global::Behave_Tool.Properties.Resources.Button;
            this.entertainMeToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.entertainMeToolStripMenuItem.Enabled = false;
            this.entertainMeToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.entertainMeToolStripMenuItem.Name = "entertainMeToolStripMenuItem";
            this.entertainMeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.entertainMeToolStripMenuItem.Text = "Entertain Me";
            // 
            // systemToolStripMenuItem
            // 
            this.systemToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.systemToolStripMenuItem.BackgroundImage = global::Behave_Tool.Properties.Resources.Button;
            this.systemToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.systemToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.performanceMonitorToolStripMenuItem});
            this.systemToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.systemToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.systemToolStripMenuItem.Name = "systemToolStripMenuItem";
            this.systemToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0);
            this.systemToolStripMenuItem.Size = new System.Drawing.Size(152, 20);
            this.systemToolStripMenuItem.Text = "System";
            // 
            // performanceMonitorToolStripMenuItem
            // 
            this.performanceMonitorToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.performanceMonitorToolStripMenuItem.BackgroundImage = global::Behave_Tool.Properties.Resources.Button;
            this.performanceMonitorToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.performanceMonitorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.preset1ToolStripMenuItem});
            this.performanceMonitorToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.performanceMonitorToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.performanceMonitorToolStripMenuItem.Name = "performanceMonitorToolStripMenuItem";
            this.performanceMonitorToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.performanceMonitorToolStripMenuItem.Text = "Performance Monitor";
            // 
            // preset1ToolStripMenuItem
            // 
            this.preset1ToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.preset1ToolStripMenuItem.BackgroundImage = global::Behave_Tool.Properties.Resources.Button;
            this.preset1ToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.preset1ToolStripMenuItem.Enabled = false;
            this.preset1ToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.preset1ToolStripMenuItem.Name = "preset1ToolStripMenuItem";
            this.preset1ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.preset1ToolStripMenuItem.Text = "Preset 1";
            this.preset1ToolStripMenuItem.Click += new System.EventHandler(this.preset1ToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 34);
            // 
            // IPrefresh
            // 
            this.IPrefresh.AutoSize = false;
            this.IPrefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.IPrefresh.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.IPrefresh.Image = global::Behave_Tool.Properties.Resources.Behave;
            this.IPrefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.IPrefresh.Name = "IPrefresh";
            this.IPrefresh.Size = new System.Drawing.Size(26, 31);
            this.IPrefresh.Click += new System.EventHandler(this.IPrefresh_Click);
            // 
            // IPdisplay
            // 
            this.IPdisplay.BackColor = System.Drawing.Color.Black;
            this.IPdisplay.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.releaseIPToolStripMenuItem,
            this.renewIPToolStripMenuItem});
            this.IPdisplay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.IPdisplay.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.IPdisplay.Name = "IPdisplay";
            this.IPdisplay.Size = new System.Drawing.Size(72, 31);
            this.IPdisplay.Text = "Public IP:";
            // 
            // releaseIPToolStripMenuItem
            // 
            this.releaseIPToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.releaseIPToolStripMenuItem.BackgroundImage = global::Behave_Tool.Properties.Resources.Button;
            this.releaseIPToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.releaseIPToolStripMenuItem.ForeColor = System.Drawing.Color.Red;
            this.releaseIPToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.releaseIPToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.releaseIPToolStripMenuItem.Name = "releaseIPToolStripMenuItem";
            this.releaseIPToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.releaseIPToolStripMenuItem.Text = "Release IP";
            this.releaseIPToolStripMenuItem.Click += new System.EventHandler(this.releaseIPToolStripMenuItem_Click);
            // 
            // renewIPToolStripMenuItem
            // 
            this.renewIPToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.renewIPToolStripMenuItem.BackgroundImage = global::Behave_Tool.Properties.Resources.Button;
            this.renewIPToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.renewIPToolStripMenuItem.ForeColor = System.Drawing.Color.Lime;
            this.renewIPToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.renewIPToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.renewIPToolStripMenuItem.Name = "renewIPToolStripMenuItem";
            this.renewIPToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.renewIPToolStripMenuItem.Text = "Renew IP";
            this.renewIPToolStripMenuItem.Click += new System.EventHandler(this.renewIPToolStripMenuItem_Click);
            // 
            // Close
            // 
            this.Close.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.Close.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Close.Image = global::Behave_Tool.Properties.Resources.Close;
            this.Close.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(23, 31);
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // MaximizeNormalize
            // 
            this.MaximizeNormalize.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.MaximizeNormalize.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.MaximizeNormalize.Image = ((System.Drawing.Image)(resources.GetObject("MaximizeNormalize.Image")));
            this.MaximizeNormalize.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.MaximizeNormalize.Name = "MaximizeNormalize";
            this.MaximizeNormalize.Size = new System.Drawing.Size(23, 31);
            this.MaximizeNormalize.ToolTipText = " ";
            this.MaximizeNormalize.Visible = false;
            this.MaximizeNormalize.Click += new System.EventHandler(this.MaximizeNormalize_Click);
            // 
            // Minimize
            // 
            this.Minimize.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.Minimize.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Minimize.Image = global::Behave_Tool.Properties.Resources.Minimize;
            this.Minimize.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Minimize.Name = "Minimize";
            this.Minimize.Size = new System.Drawing.Size(23, 31);
            this.Minimize.Click += new System.EventHandler(this.Minimize_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 34);
            // 
            // Settings
            // 
            this.Settings.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.Settings.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Settings.Image = global::Behave_Tool.Properties.Resources.Gear_;
            this.Settings.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(23, 31);
            this.Settings.Click += new System.EventHandler(this.Settings_Click);
            this.Settings.MouseLeave += new System.EventHandler(this.Settings_MouseLeave);
            this.Settings.MouseHover += new System.EventHandler(this.Settings_MouseHover);
            // 
            // SessionTimer
            // 
            this.SessionTimer.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.SessionTimer.AutoSize = true;
            this.SessionTimer.BackColor = System.Drawing.Color.Transparent;
            this.SessionTimer.ForeColor = System.Drawing.Color.White;
            this.SessionTimer.Location = new System.Drawing.Point(71, 33);
            this.SessionTimer.Name = "SessionTimer";
            this.SessionTimer.Size = new System.Drawing.Size(73, 13);
            this.SessionTimer.TabIndex = 5;
            this.SessionTimer.Text = "This Session: ";
            this.SessionTimer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TotalSessionTime
            // 
            this.TotalSessionTime.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.TotalSessionTime.AutoSize = true;
            this.TotalSessionTime.BackColor = System.Drawing.Color.Transparent;
            this.TotalSessionTime.ForeColor = System.Drawing.Color.White;
            this.TotalSessionTime.Location = new System.Drawing.Point(81, 6);
            this.TotalSessionTime.Name = "TotalSessionTime";
            this.TotalSessionTime.Size = new System.Drawing.Size(63, 13);
            this.TotalSessionTime.TabIndex = 6;
            this.TotalSessionTime.Text = "Total Time: ";
            this.TotalSessionTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.Visible = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.TotalSessionTime, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.SessionTimer, 0, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(856, 33);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(147, 53);
            this.tableLayoutPanel2.TabIndex = 10;
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
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
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
            this.tableLayoutPanel1.TabIndex = 0;
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
            this.Storage_Label.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.label5_MouseDoubleClick);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Controls.Add(this.tableLayoutPanel1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(221, 125);
            this.flowLayoutPanel1.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Location = new System.Drawing.Point(0, 101);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(232, 214);
            this.panel1.TabIndex = 11;
            // 
            // Behave
            // 
            this.AccessibleName = "Main";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::Behave_Tool.Properties.Resources.Background_OrangeCore1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1003, 345);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.ToolBar);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Behave";
            this.ToolBar.ResumeLayout(false);
            this.ToolBar.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip ToolBar;
        private new System.Windows.Forms.ToolStripDropDownButton Menu;
        private System.Windows.Forms.ToolStripMenuItem stuffToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private new System.Windows.Forms.ToolStripButton Close;
        private System.Windows.Forms.ToolStripButton Minimize;
        private System.Windows.Forms.ToolStripButton IPrefresh;
        internal System.Windows.Forms.ToolStripSplitButton IPdisplay;
        private System.Windows.Forms.ToolStripMenuItem releaseIPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renewIPToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.Label SessionTimer;
        private System.Windows.Forms.Label TotalSessionTime;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ToolStripButton MaximizeNormalize;
        private System.Windows.Forms.ToolStripButton Settings;
        private System.Windows.Forms.ToolStripMenuItem LocalNetworkToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
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
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ToolStripMenuItem toysToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entertainMeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openPortScannerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem systemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem performanceMonitorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem preset1ToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem localHostScannerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tCPConnectionsToolStripMenuItem;
    }
}
