namespace MassRepo.Tools.Network
{
    partial class Network
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Network));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.MAC = new System.Windows.Forms.TextBox();
            this.IPv6 = new System.Windows.Forms.TextBox();
            this.IPv4 = new System.Windows.Forms.TextBox();
            this.gateway = new System.Windows.Forms.TextBox();
            this.IP = new System.Windows.Forms.TextBox();
            this.web_Refresh = new System.Windows.Forms.Button();
            this.gateway_Refresh = new System.Windows.Forms.Button();
            this.gateLabel = new System.Windows.Forms.Label();
            this.MAC_Refresh = new System.Windows.Forms.Button();
            this.MAC_Label = new System.Windows.Forms.Label();
            this.IPv6_Refresh = new System.Windows.Forms.Button();
            this.IPv4_Refresh = new System.Windows.Forms.Button();
            this.IP_Refresh = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Ipv4Label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.WebLabel = new System.Windows.Forms.Label();
            this.WebConnection = new System.Windows.Forms.Label();
            this.All_Refresh = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.28572F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 77.71428F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel1.Controls.Add(this.MAC, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.IPv6, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.IPv4, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.gateway, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.IP, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.web_Refresh, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.gateway_Refresh, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.gateLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.MAC_Refresh, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.MAC_Label, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.IPv6_Refresh, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.IPv4_Refresh, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.IP_Refresh, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.Ipv4Label, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.WebLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.WebConnection, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 38);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(229, 127);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // MAC
            // 
            this.MAC.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MAC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.MAC.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MAC.ForeColor = System.Drawing.Color.Orange;
            this.MAC.Location = new System.Drawing.Point(47, 109);
            this.MAC.Name = "MAC";
            this.MAC.ReadOnly = true;
            this.MAC.Size = new System.Drawing.Size(144, 13);
            this.MAC.TabIndex = 13;
            this.MAC.Text = "0.0.0.0";
            // 
            // IPv6
            // 
            this.IPv6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.IPv6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.IPv6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.IPv6.ForeColor = System.Drawing.Color.Orange;
            this.IPv6.Location = new System.Drawing.Point(47, 87);
            this.IPv6.Name = "IPv6";
            this.IPv6.ReadOnly = true;
            this.IPv6.Size = new System.Drawing.Size(144, 13);
            this.IPv6.TabIndex = 12;
            this.IPv6.Text = "0.0.0.0";
            // 
            // IPv4
            // 
            this.IPv4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.IPv4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.IPv4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.IPv4.ForeColor = System.Drawing.Color.Orange;
            this.IPv4.Location = new System.Drawing.Point(47, 66);
            this.IPv4.Name = "IPv4";
            this.IPv4.ReadOnly = true;
            this.IPv4.Size = new System.Drawing.Size(144, 13);
            this.IPv4.TabIndex = 11;
            this.IPv4.Text = "0.0.0.0";
            // 
            // gateway
            // 
            this.gateway.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gateway.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.gateway.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gateway.ForeColor = System.Drawing.Color.Orange;
            this.gateway.Location = new System.Drawing.Point(47, 45);
            this.gateway.Name = "gateway";
            this.gateway.ReadOnly = true;
            this.gateway.Size = new System.Drawing.Size(144, 13);
            this.gateway.TabIndex = 10;
            this.gateway.Text = "0.0.0.0";
            // 
            // IP
            // 
            this.IP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.IP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.IP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.IP.ForeColor = System.Drawing.Color.Orange;
            this.IP.Location = new System.Drawing.Point(47, 25);
            this.IP.Name = "IP";
            this.IP.ReadOnly = true;
            this.IP.Size = new System.Drawing.Size(144, 13);
            this.IP.TabIndex = 9;
            this.IP.Text = "0.0.0.0";
            // 
            // web_Refresh
            // 
            this.web_Refresh.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.web_Refresh.AutoSize = true;
            this.web_Refresh.BackColor = System.Drawing.Color.Black;
            this.web_Refresh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("web_Refresh.BackgroundImage")));
            this.web_Refresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.web_Refresh.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.web_Refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.web_Refresh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.web_Refresh.Location = new System.Drawing.Point(202, 0);
            this.web_Refresh.Margin = new System.Windows.Forms.Padding(0);
            this.web_Refresh.Name = "web_Refresh";
            this.web_Refresh.Size = new System.Drawing.Size(27, 21);
            this.web_Refresh.TabIndex = 10;
            this.web_Refresh.Text = "R";
            this.web_Refresh.UseVisualStyleBackColor = false;
            this.web_Refresh.Click += new System.EventHandler(this.WebConnection_TextChanged);
            // 
            // gateway_Refresh
            // 
            this.gateway_Refresh.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.gateway_Refresh.AutoSize = true;
            this.gateway_Refresh.BackColor = System.Drawing.Color.Black;
            this.gateway_Refresh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gateway_Refresh.BackgroundImage")));
            this.gateway_Refresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gateway_Refresh.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.gateway_Refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gateway_Refresh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.gateway_Refresh.Location = new System.Drawing.Point(202, 42);
            this.gateway_Refresh.Margin = new System.Windows.Forms.Padding(0);
            this.gateway_Refresh.Name = "gateway_Refresh";
            this.gateway_Refresh.Size = new System.Drawing.Size(27, 20);
            this.gateway_Refresh.TabIndex = 14;
            this.gateway_Refresh.Text = "R";
            this.gateway_Refresh.UseVisualStyleBackColor = false;
            this.gateway_Refresh.Click += new System.EventHandler(this.gateway_Refresh_Click);
            // 
            // gateLabel
            // 
            this.gateLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.gateLabel.AutoSize = true;
            this.gateLabel.BackColor = System.Drawing.Color.Transparent;
            this.gateLabel.ForeColor = System.Drawing.Color.Orange;
            this.gateLabel.Location = new System.Drawing.Point(10, 45);
            this.gateLabel.Name = "gateLabel";
            this.gateLabel.Size = new System.Drawing.Size(30, 13);
            this.gateLabel.TabIndex = 9;
            this.gateLabel.Text = "Gate";
            this.gateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MAC_Refresh
            // 
            this.MAC_Refresh.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.MAC_Refresh.AutoSize = true;
            this.MAC_Refresh.BackColor = System.Drawing.Color.Black;
            this.MAC_Refresh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MAC_Refresh.BackgroundImage")));
            this.MAC_Refresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MAC_Refresh.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.MAC_Refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MAC_Refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MAC_Refresh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.MAC_Refresh.Location = new System.Drawing.Point(202, 104);
            this.MAC_Refresh.Margin = new System.Windows.Forms.Padding(0);
            this.MAC_Refresh.Name = "MAC_Refresh";
            this.MAC_Refresh.Size = new System.Drawing.Size(27, 23);
            this.MAC_Refresh.TabIndex = 12;
            this.MAC_Refresh.Text = "R";
            this.MAC_Refresh.UseVisualStyleBackColor = false;
            this.MAC_Refresh.Click += new System.EventHandler(this.MAC_Refresh_Click);
            // 
            // MAC_Label
            // 
            this.MAC_Label.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.MAC_Label.AutoSize = true;
            this.MAC_Label.BackColor = System.Drawing.Color.Transparent;
            this.MAC_Label.ForeColor = System.Drawing.Color.Orange;
            this.MAC_Label.Location = new System.Drawing.Point(10, 109);
            this.MAC_Label.Name = "MAC_Label";
            this.MAC_Label.Size = new System.Drawing.Size(30, 13);
            this.MAC_Label.TabIndex = 12;
            this.MAC_Label.Text = "MAC";
            this.MAC_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // IPv6_Refresh
            // 
            this.IPv6_Refresh.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.IPv6_Refresh.AutoSize = true;
            this.IPv6_Refresh.BackColor = System.Drawing.Color.Black;
            this.IPv6_Refresh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("IPv6_Refresh.BackgroundImage")));
            this.IPv6_Refresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.IPv6_Refresh.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.IPv6_Refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IPv6_Refresh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.IPv6_Refresh.Location = new System.Drawing.Point(202, 83);
            this.IPv6_Refresh.Margin = new System.Windows.Forms.Padding(0);
            this.IPv6_Refresh.Name = "IPv6_Refresh";
            this.IPv6_Refresh.Size = new System.Drawing.Size(27, 21);
            this.IPv6_Refresh.TabIndex = 11;
            this.IPv6_Refresh.Text = "R";
            this.IPv6_Refresh.UseVisualStyleBackColor = false;
            this.IPv6_Refresh.Click += new System.EventHandler(this.IPv6_Refresh_Click);
            // 
            // IPv4_Refresh
            // 
            this.IPv4_Refresh.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.IPv4_Refresh.AutoSize = true;
            this.IPv4_Refresh.BackColor = System.Drawing.Color.Black;
            this.IPv4_Refresh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("IPv4_Refresh.BackgroundImage")));
            this.IPv4_Refresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.IPv4_Refresh.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.IPv4_Refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IPv4_Refresh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.IPv4_Refresh.Location = new System.Drawing.Point(202, 62);
            this.IPv4_Refresh.Margin = new System.Windows.Forms.Padding(0);
            this.IPv4_Refresh.Name = "IPv4_Refresh";
            this.IPv4_Refresh.Size = new System.Drawing.Size(27, 21);
            this.IPv4_Refresh.TabIndex = 10;
            this.IPv4_Refresh.Text = "R";
            this.IPv4_Refresh.UseVisualStyleBackColor = false;
            this.IPv4_Refresh.Click += new System.EventHandler(this.IPv4_Refresh_Click);
            // 
            // IP_Refresh
            // 
            this.IP_Refresh.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.IP_Refresh.AutoSize = true;
            this.IP_Refresh.BackColor = System.Drawing.Color.Black;
            this.IP_Refresh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("IP_Refresh.BackgroundImage")));
            this.IP_Refresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.IP_Refresh.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.IP_Refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IP_Refresh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.IP_Refresh.Location = new System.Drawing.Point(202, 21);
            this.IP_Refresh.Margin = new System.Windows.Forms.Padding(0);
            this.IP_Refresh.Name = "IP_Refresh";
            this.IP_Refresh.Size = new System.Drawing.Size(27, 21);
            this.IP_Refresh.TabIndex = 9;
            this.IP_Refresh.Text = "R";
            this.IP_Refresh.UseVisualStyleBackColor = false;
            this.IP_Refresh.Click += new System.EventHandler(this.IP_Refresh_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.Orange;
            this.label3.Location = new System.Drawing.Point(11, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "IPv6";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Ipv4Label
            // 
            this.Ipv4Label.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Ipv4Label.AutoSize = true;
            this.Ipv4Label.BackColor = System.Drawing.Color.Transparent;
            this.Ipv4Label.ForeColor = System.Drawing.Color.Orange;
            this.Ipv4Label.Location = new System.Drawing.Point(11, 66);
            this.Ipv4Label.Name = "Ipv4Label";
            this.Ipv4Label.Size = new System.Drawing.Size(29, 13);
            this.Ipv4Label.TabIndex = 1;
            this.Ipv4Label.Text = "IPv4";
            this.Ipv4Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.Orange;
            this.label1.Location = new System.Drawing.Point(23, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WebLabel
            // 
            this.WebLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.WebLabel.AutoSize = true;
            this.WebLabel.BackColor = System.Drawing.Color.Transparent;
            this.WebLabel.ForeColor = System.Drawing.Color.Orange;
            this.WebLabel.Location = new System.Drawing.Point(10, 4);
            this.WebLabel.Name = "WebLabel";
            this.WebLabel.Size = new System.Drawing.Size(30, 13);
            this.WebLabel.TabIndex = 6;
            this.WebLabel.Text = "Web";
            this.WebLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WebConnection
            // 
            this.WebConnection.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.WebConnection.AutoSize = true;
            this.WebConnection.BackColor = System.Drawing.Color.Transparent;
            this.WebConnection.ForeColor = System.Drawing.Color.Orange;
            this.WebConnection.Location = new System.Drawing.Point(46, 4);
            this.WebConnection.Name = "WebConnection";
            this.WebConnection.Size = new System.Drawing.Size(65, 13);
            this.WebConnection.TabIndex = 7;
            this.WebConnection.Text = "Connected?";
            this.WebConnection.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // All_Refresh
            // 
            this.All_Refresh.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.All_Refresh.BackColor = System.Drawing.Color.Black;
            this.All_Refresh.BackgroundImage = global::MassRepo.Properties.Resources.Button;
            this.All_Refresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.All_Refresh.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.All_Refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.All_Refresh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.All_Refresh.Location = new System.Drawing.Point(204, 168);
            this.All_Refresh.Margin = new System.Windows.Forms.Padding(0);
            this.All_Refresh.Name = "All_Refresh";
            this.All_Refresh.Size = new System.Drawing.Size(37, 26);
            this.All_Refresh.TabIndex = 10;
            this.All_Refresh.Text = "ALL";
            this.All_Refresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.All_Refresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.All_Refresh.UseVisualStyleBackColor = false;
            this.All_Refresh.Click += new System.EventHandler(this.ALL_Refresh_Click);
            // 
            // Network
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(251, 202);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.All_Refresh);
            this.Name = "Network";
            this.Text = "clone";
            this.Load += new System.EventHandler(this.IndepthIPinfo_Load);
            this.Controls.SetChildIndex(this.All_Refresh, 0);
            this.Controls.SetChildIndex(this.tableLayoutPanel1, 0);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox MAC;
        private System.Windows.Forms.TextBox IPv6;
        private System.Windows.Forms.TextBox IPv4;
        private System.Windows.Forms.TextBox gateway;
        private System.Windows.Forms.TextBox IP;
        private System.Windows.Forms.Button web_Refresh;
        private System.Windows.Forms.Button gateway_Refresh;
        private System.Windows.Forms.Label gateLabel;
        private System.Windows.Forms.Button MAC_Refresh;
        private System.Windows.Forms.Label MAC_Label;
        private System.Windows.Forms.Button IPv6_Refresh;
        private System.Windows.Forms.Button IPv4_Refresh;
        private System.Windows.Forms.Button IP_Refresh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Ipv4Label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label WebLabel;
        private System.Windows.Forms.Label WebConnection;
        private System.Windows.Forms.Button All_Refresh;
    }
}