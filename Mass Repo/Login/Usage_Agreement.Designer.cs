namespace MassRepo
{
    partial class Usage_Agreement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Usage_Agreement));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.Agree = new System.Windows.Forms.Button();
            this.Disagree = new System.Windows.Forms.Button();
            this.Checkbox = new System.Windows.Forms.CheckBox();
            this.label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.ForeColor = System.Drawing.Color.White;
            this.richTextBox1.Location = new System.Drawing.Point(12, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.richTextBox1.Size = new System.Drawing.Size(681, 245);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "Usage Agreement\n\n\n\n\nYou are beautiful no matter what they say!";
            // 
            // Agree
            // 
            this.Agree.BackColor = System.Drawing.Color.Black;
            this.Agree.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Agree.BackgroundImage")));
            this.Agree.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Agree.Enabled = false;
            this.Agree.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Agree.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Agree.ForeColor = System.Drawing.Color.Lime;
            this.Agree.Location = new System.Drawing.Point(537, 292);
            this.Agree.Name = "Agree";
            this.Agree.Size = new System.Drawing.Size(75, 23);
            this.Agree.TabIndex = 1;
            this.Agree.Text = "I Agree";
            this.Agree.UseVisualStyleBackColor = false;
            this.Agree.Click += new System.EventHandler(this.Agree_Click);
            // 
            // Disagree
            // 
            this.Disagree.BackColor = System.Drawing.Color.Black;
            this.Disagree.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Disagree.BackgroundImage")));
            this.Disagree.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Disagree.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Disagree.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Disagree.ForeColor = System.Drawing.Color.Red;
            this.Disagree.Location = new System.Drawing.Point(618, 292);
            this.Disagree.Name = "Disagree";
            this.Disagree.Size = new System.Drawing.Size(75, 23);
            this.Disagree.TabIndex = 2;
            this.Disagree.Text = "I Disagree";
            this.Disagree.UseVisualStyleBackColor = false;
            this.Disagree.Click += new System.EventHandler(this.Disagree_Click);
            // 
            // Checkbox
            // 
            this.Checkbox.AutoSize = true;
            this.Checkbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Checkbox.Location = new System.Drawing.Point(387, 269);
            this.Checkbox.Name = "Checkbox";
            this.Checkbox.Size = new System.Drawing.Size(121, 17);
            this.Checkbox.TabIndex = 3;
            this.Checkbox.Text = "I have read the ToS";
            this.Checkbox.UseVisualStyleBackColor = true;
            this.Checkbox.CheckStateChanged += new System.EventHandler(this.Checkbox_CheckStateChanged);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label.Location = new System.Drawing.Point(548, 270);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(140, 13);
            this.label.TabIndex = 4;
            this.label.Text = "Do you agree with the ToS?";
            // 
            // Usage_Agreement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(705, 327);
            this.Controls.Add(this.label);
            this.Controls.Add(this.Checkbox);
            this.Controls.Add(this.Disagree);
            this.Controls.Add(this.Agree);
            this.Controls.Add(this.richTextBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Usage_Agreement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usage_Agreement";
            this.Load += new System.EventHandler(this.Usage_Agreement_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button Agree;
        private System.Windows.Forms.Button Disagree;
        private System.Windows.Forms.CheckBox Checkbox;
        private System.Windows.Forms.Label label;
    }
}