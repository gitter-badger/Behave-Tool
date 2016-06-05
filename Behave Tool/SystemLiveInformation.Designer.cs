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
            this.showHide1 = new Behave_Tool.ShowHide();
            this.SuspendLayout();
            // 
            // showHide1
            // 
            this.showHide1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.showHide1.BackColor = System.Drawing.Color.Black;
            this.showHide1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.showHide1.ForeColor = System.Drawing.Color.White;
            this.showHide1.Location = new System.Drawing.Point(0, 0);
            this.showHide1.Name = "showHide1";
            this.showHide1.Size = new System.Drawing.Size(227, 125);
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
            this.ClientSize = new System.Drawing.Size(227, 125);
            this.Controls.Add(this.showHide1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SystemLiveInformation";
            this.Opacity = 0.9D;
            this.ShowInTaskbar = false;
            this.Text = "SystemLiveInformation";
            this.Load += new System.EventHandler(this.SystemLiveInformation_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ShowHide showHide1;
    }
}