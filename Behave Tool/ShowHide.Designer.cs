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
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(222, 138);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseClick);
            // 
            // ShowHide
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(245, 138);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ShowHideToggle);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ShowHide";
            this.Opacity = 0.95D;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ShowHide_MouseClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox ShowHideToggle;
        protected System.Windows.Forms.Panel panel1;
    }
}
