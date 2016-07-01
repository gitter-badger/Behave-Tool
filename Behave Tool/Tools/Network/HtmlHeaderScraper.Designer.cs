namespace Behave_Tool.Tools.Network
{
    partial class HtmlHeaderScraper
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HtmlHeaderScraper));
            this.save = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Url = new System.Windows.Forms.TextBox();
            this.ClearList = new System.Windows.Forms.Button();
            this.Fetch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // save
            // 
            this.save.BackColor = System.Drawing.Color.Black;
            this.save.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("save.BackgroundImage")));
            this.save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.save.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.save.Location = new System.Drawing.Point(368, 132);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(75, 23);
            this.save.TabIndex = 48;
            this.save.Text = "Save .txt";
            this.save.UseVisualStyleBackColor = false;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.Black;
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox1.ForeColor = System.Drawing.Color.White;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 92);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(350, 184);
            this.listBox1.TabIndex = 47;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(172, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 46;
            this.label1.Text = "URL";
            // 
            // Url
            // 
            this.Url.BackColor = System.Drawing.Color.Black;
            this.Url.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Url.ForeColor = System.Drawing.Color.White;
            this.Url.Location = new System.Drawing.Point(12, 51);
            this.Url.Name = "Url";
            this.Url.Size = new System.Drawing.Size(350, 20);
            this.Url.TabIndex = 45;
            // 
            // ClearList
            // 
            this.ClearList.BackColor = System.Drawing.Color.Black;
            this.ClearList.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ClearList.BackgroundImage")));
            this.ClearList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClearList.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClearList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClearList.Location = new System.Drawing.Point(368, 92);
            this.ClearList.Name = "ClearList";
            this.ClearList.Size = new System.Drawing.Size(75, 23);
            this.ClearList.TabIndex = 44;
            this.ClearList.Text = "Clear List";
            this.ClearList.UseVisualStyleBackColor = false;
            this.ClearList.Click += new System.EventHandler(this.ClearList_Click);
            // 
            // Fetch
            // 
            this.Fetch.BackColor = System.Drawing.Color.Black;
            this.Fetch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Fetch.BackgroundImage")));
            this.Fetch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Fetch.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Fetch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Fetch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Fetch.Location = new System.Drawing.Point(368, 50);
            this.Fetch.Name = "Fetch";
            this.Fetch.Size = new System.Drawing.Size(75, 23);
            this.Fetch.TabIndex = 43;
            this.Fetch.Text = "Fetch";
            this.Fetch.UseVisualStyleBackColor = false;
            this.Fetch.Click += new System.EventHandler(this.Fetch_Click);
            // 
            // Clone
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 289);
            this.Controls.Add(this.save);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Url);
            this.Controls.Add(this.ClearList);
            this.Controls.Add(this.Fetch);
            this.Name = "Clone";
            this.Text = "Clone";
            this.Controls.SetChildIndex(this.Fetch, 0);
            this.Controls.SetChildIndex(this.ClearList, 0);
            this.Controls.SetChildIndex(this.Url, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.listBox1, 0);
            this.Controls.SetChildIndex(this.save, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button save;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Url;
        private System.Windows.Forms.Button ClearList;
        private System.Windows.Forms.Button Fetch;
    }
}