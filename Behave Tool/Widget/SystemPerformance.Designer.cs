namespace Behave_Tool.Widget
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
            this.cpuRam1 = new Behave_Tool.CpuRam();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cpuRam1);
            // 
            // cpuRam1
            // 
            this.cpuRam1.BackColor = System.Drawing.Color.Transparent;
            this.cpuRam1.Location = new System.Drawing.Point(7, 12);
            this.cpuRam1.Name = "cpuRam1";
            this.cpuRam1.Size = new System.Drawing.Size(215, 65);
            this.cpuRam1.TabIndex = 0;
            // 
            // SystemPerformance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(245, 138);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "SystemPerformance";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CpuRam cpuRam1;
    }
}