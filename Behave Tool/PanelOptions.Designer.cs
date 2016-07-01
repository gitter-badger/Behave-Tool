namespace Behave_Tool
{
    partial class PanelOptions
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
            this.Lock = new System.Windows.Forms.CheckBox();
            this.KeepOnTop = new System.Windows.Forms.CheckBox();
            this.Close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lock
            // 
            this.Lock.AutoSize = true;
            this.Lock.BackgroundImage = global::Behave_Tool.Properties.Resources.Button;
            this.Lock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Lock.Dock = System.Windows.Forms.DockStyle.Top;
            this.Lock.FlatAppearance.BorderSize = 0;
            this.Lock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Lock.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lock.ForeColor = System.Drawing.Color.White;
            this.Lock.Location = new System.Drawing.Point(0, 0);
            this.Lock.Margin = new System.Windows.Forms.Padding(0);
            this.Lock.Name = "Lock";
            this.Lock.Size = new System.Drawing.Size(162, 22);
            this.Lock.TabIndex = 0;
            this.Lock.Text = "Lock Panel";
            this.Lock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Lock.UseVisualStyleBackColor = true;
            // 
            // KeepOnTop
            // 
            this.KeepOnTop.AutoSize = true;
            this.KeepOnTop.BackgroundImage = global::Behave_Tool.Properties.Resources.Button;
            this.KeepOnTop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.KeepOnTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.KeepOnTop.FlatAppearance.BorderSize = 0;
            this.KeepOnTop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.KeepOnTop.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeepOnTop.ForeColor = System.Drawing.Color.White;
            this.KeepOnTop.Location = new System.Drawing.Point(0, 22);
            this.KeepOnTop.Margin = new System.Windows.Forms.Padding(0);
            this.KeepOnTop.Name = "KeepOnTop";
            this.KeepOnTop.Size = new System.Drawing.Size(162, 22);
            this.KeepOnTop.TabIndex = 1;
            this.KeepOnTop.Text = "KeepOnTop";
            this.KeepOnTop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.KeepOnTop.UseVisualStyleBackColor = true;
            // 
            // Close
            // 
            this.Close.AutoSize = true;
            this.Close.BackColor = System.Drawing.Color.Black;
            this.Close.BackgroundImage = global::Behave_Tool.Properties.Resources.Button;
            this.Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Close.Dock = System.Windows.Forms.DockStyle.Top;
            this.Close.FlatAppearance.BorderSize = 0;
            this.Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.Close.ForeColor = System.Drawing.Color.White;
            this.Close.Location = new System.Drawing.Point(0, 44);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(162, 25);
            this.Close.TabIndex = 2;
            this.Close.Text = "Close";
            this.Close.UseVisualStyleBackColor = false;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // PanelOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(162, 67);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.KeepOnTop);
            this.Controls.Add(this.Lock);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PanelOptions";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox Lock;
        private System.Windows.Forms.CheckBox KeepOnTop;
        private new System.Windows.Forms.Button Close;
    }
}
