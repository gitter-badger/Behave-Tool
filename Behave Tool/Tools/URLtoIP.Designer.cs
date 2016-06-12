namespace Behave_Tool.Tools
{
    partial class URLtoIP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(URLtoIP));
            this.saveToTXT = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Resolve = new System.Windows.Forms.Button();
            this.URL = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.Close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // saveToTXT
            // 
            this.saveToTXT.BackColor = System.Drawing.Color.Black;
            this.saveToTXT.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("saveToTXT.BackgroundImage")));
            this.saveToTXT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.saveToTXT.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.saveToTXT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveToTXT.ForeColor = System.Drawing.Color.White;
            this.saveToTXT.Location = new System.Drawing.Point(237, 121);
            this.saveToTXT.Name = "saveToTXT";
            this.saveToTXT.Size = new System.Drawing.Size(75, 23);
            this.saveToTXT.TabIndex = 9;
            this.saveToTXT.Text = "Save .txt";
            this.saveToTXT.UseVisualStyleBackColor = false;
            this.saveToTXT.Click += new System.EventHandler(this.saveToTXT_Click);
            // 
            // Clear
            // 
            this.Clear.BackColor = System.Drawing.Color.Black;
            this.Clear.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Clear.BackgroundImage")));
            this.Clear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Clear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Clear.ForeColor = System.Drawing.Color.White;
            this.Clear.Location = new System.Drawing.Point(237, 92);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(75, 23);
            this.Clear.TabIndex = 8;
            this.Clear.Text = "Clear List";
            this.Clear.UseVisualStyleBackColor = false;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-82, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "URL Here";
            // 
            // Resolve
            // 
            this.Resolve.BackColor = System.Drawing.Color.Black;
            this.Resolve.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Resolve.BackgroundImage")));
            this.Resolve.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Resolve.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Resolve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Resolve.ForeColor = System.Drawing.Color.White;
            this.Resolve.Location = new System.Drawing.Point(237, 55);
            this.Resolve.Name = "Resolve";
            this.Resolve.Size = new System.Drawing.Size(75, 23);
            this.Resolve.TabIndex = 6;
            this.Resolve.Text = "Resolve";
            this.Resolve.UseVisualStyleBackColor = false;
            this.Resolve.Click += new System.EventHandler(this.Resolve_Click);
            // 
            // URL
            // 
            this.URL.BackColor = System.Drawing.Color.Black;
            this.URL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.URL.ForeColor = System.Drawing.Color.White;
            this.URL.Location = new System.Drawing.Point(12, 55);
            this.URL.Name = "URL";
            this.URL.Size = new System.Drawing.Size(219, 20);
            this.URL.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(108, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "URL";
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.Black;
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox1.ForeColor = System.Drawing.Color.White;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 92);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(219, 106);
            this.listBox1.TabIndex = 12;
            // 
            // Close
            // 
            this.Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Close.BackColor = System.Drawing.Color.Transparent;
            this.Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Close.Location = new System.Drawing.Point(297, 0);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(24, 24);
            this.Close.TabIndex = 41;
            this.Close.Text = "X";
            this.Close.UseVisualStyleBackColor = false;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // URLtoIP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(321, 209);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.URL);
            this.Controls.Add(this.saveToTXT);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Resolve);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "URLtoIP";
            this.Text = "URLtoIP";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button saveToTXT;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Resolve;
        private System.Windows.Forms.TextBox URL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox1;
        private new System.Windows.Forms.Button Close;
    }
}