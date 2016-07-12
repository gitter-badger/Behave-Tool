namespace MassRepo
{
    partial class CpuRam
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.cpuUsage = new System.Windows.Forms.Label();
            this.CPUbar = new System.Windows.Forms.ProgressBar();
            this.RAMbar = new System.Windows.Forms.ProgressBar();
            this.ramUsage = new System.Windows.Forms.Label();
            this.CPU_Label = new System.Windows.Forms.Label();
            this.RAM_Label = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.cpuUsage, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.CPUbar, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.RAMbar, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.ramUsage, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.CPU_Label, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.RAM_Label, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 6);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(215, 52);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // cpuUsage
            // 
            this.cpuUsage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cpuUsage.AutoSize = true;
            this.cpuUsage.BackColor = System.Drawing.Color.Transparent;
            this.cpuUsage.ForeColor = System.Drawing.Color.White;
            this.cpuUsage.Location = new System.Drawing.Point(110, 0);
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
            this.CPUbar.Location = new System.Drawing.Point(77, 16);
            this.CPUbar.Name = "CPUbar";
            this.CPUbar.Size = new System.Drawing.Size(100, 5);
            this.CPUbar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.CPUbar.TabIndex = 7;
            // 
            // RAMbar
            // 
            this.RAMbar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RAMbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.RAMbar.ForeColor = System.Drawing.Color.Red;
            this.RAMbar.Location = new System.Drawing.Point(77, 42);
            this.RAMbar.Name = "RAMbar";
            this.RAMbar.Size = new System.Drawing.Size(100, 5);
            this.RAMbar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.RAMbar.TabIndex = 8;
            // 
            // ramUsage
            // 
            this.ramUsage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ramUsage.AutoSize = true;
            this.ramUsage.BackColor = System.Drawing.Color.Transparent;
            this.ramUsage.ForeColor = System.Drawing.Color.White;
            this.ramUsage.Location = new System.Drawing.Point(109, 24);
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
            this.CPU_Label.Location = new System.Drawing.Point(5, 0);
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
            this.RAM_Label.Location = new System.Drawing.Point(3, 24);
            this.RAM_Label.Name = "RAM_Label";
            this.RAM_Label.Size = new System.Drawing.Size(34, 13);
            this.RAM_Label.TabIndex = 10;
            this.RAM_Label.Text = "RAM:";
            this.RAM_Label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CpuRam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "CpuRam";
            this.Size = new System.Drawing.Size(226, 65);
            this.Load += new System.EventHandler(this.CpuRam_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label cpuUsage;
        private System.Windows.Forms.ProgressBar CPUbar;
        private System.Windows.Forms.ProgressBar RAMbar;
        private System.Windows.Forms.Label ramUsage;
        private System.Windows.Forms.Label CPU_Label;
        private System.Windows.Forms.Label RAM_Label;
    }
}
