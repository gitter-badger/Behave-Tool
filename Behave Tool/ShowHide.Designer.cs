namespace Behave_Tool
{
    partial class ShowHide
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ShowHideToggle = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.cpuUsage = new System.Windows.Forms.Label();
            this.CPUbar = new System.Windows.Forms.ProgressBar();
            this.NetworkTrafficUp = new System.Windows.Forms.Label();
            this.RAMbar = new System.Windows.Forms.ProgressBar();
            this.NetworkTrafficDown = new System.Windows.Forms.Label();
            this.ramUsage = new System.Windows.Forms.Label();
            this.CPU_Label = new System.Windows.Forms.Label();
            this.RAM_Label = new System.Windows.Forms.Label();
            this.Download_Label = new System.Windows.Forms.Label();
            this.Upload_Label = new System.Windows.Forms.Label();
            this.Storage_Label = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ShowHideToggle
            // 
            this.ShowHideToggle.Appearance = System.Windows.Forms.Appearance.Button;
            this.ShowHideToggle.AutoSize = true;
            this.ShowHideToggle.BackColor = System.Drawing.Color.Black;
            this.ShowHideToggle.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ShowHideToggle.Checked = true;
            this.ShowHideToggle.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ShowHideToggle.Dock = System.Windows.Forms.DockStyle.Right;
            this.ShowHideToggle.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ShowHideToggle.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.ShowHideToggle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShowHideToggle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ShowHideToggle.Location = new System.Drawing.Point(222, 0);
            this.ShowHideToggle.Margin = new System.Windows.Forms.Padding(1);
            this.ShowHideToggle.Name = "ShowHideToggle";
            this.ShowHideToggle.Size = new System.Drawing.Size(23, 138);
            this.ShowHideToggle.TabIndex = 0;
            this.ShowHideToggle.Text = ">";
            this.ShowHideToggle.UseVisualStyleBackColor = false;
            this.ShowHideToggle.CheckStateChanged += new System.EventHandler(this.ShowHideToggle_CheckStateChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(222, 138);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseClick);
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
            this.tableLayoutPanel1.Controls.Add(this.NetworkTrafficDown, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.ramUsage, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.CPU_Label, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.RAM_Label, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.Download_Label, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.Upload_Label, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.Storage_Label, 0, 6);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 3);
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
            // ShowHide
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(245, 138);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ShowHideToggle);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ShowHide";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ShowHide_MouseClick);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox ShowHideToggle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label cpuUsage;
        private System.Windows.Forms.ProgressBar CPUbar;
        private System.Windows.Forms.Label NetworkTrafficUp;
        private System.Windows.Forms.ProgressBar RAMbar;
        private System.Windows.Forms.Label NetworkTrafficDown;
        private System.Windows.Forms.Label ramUsage;
        private System.Windows.Forms.Label CPU_Label;
        private System.Windows.Forms.Label RAM_Label;
        private System.Windows.Forms.Label Download_Label;
        private System.Windows.Forms.Label Upload_Label;
        private System.Windows.Forms.Label Storage_Label;
    }
}
