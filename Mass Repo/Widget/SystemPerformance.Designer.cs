namespace MassRepo.Widget
{
    partial class SystemPerformance
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
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(cpuRam1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.None;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Size = new System.Drawing.Size(227, 62);
            this.panel1.Controls.SetChildIndex(cpuRam1, 0);
            // 
            // cpuRam1
            // 
            this.cpuRam1.BackColor = System.Drawing.Color.Transparent;
            this.cpuRam1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cpuRam1.Location = new System.Drawing.Point(0, 0);
            this.cpuRam1.Name = "cpuRam1";
            this.cpuRam1.Size = new System.Drawing.Size(204, 62);
            this.cpuRam1.TabIndex = 0;
            this.cpuRam1.MouseDown += new System.Windows.Forms.MouseEventHandler(cpuRam1_MouseDown);
            // 
            // SystemPerformance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(230, 90);
            this.Name = "SystemPerformance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CpuRam cpuRam1;
    }
}