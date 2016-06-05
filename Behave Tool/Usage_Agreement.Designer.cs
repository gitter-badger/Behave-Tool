namespace Behave_Tool
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.Agree = new System.Windows.Forms.Button();
            this.Disagree = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.Black;
            this.richTextBox1.ForeColor = System.Drawing.Color.White;
            this.richTextBox1.Location = new System.Drawing.Point(12, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(681, 245);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "Usage Agreement";
            // 
            // Agree
            // 
            this.Agree.BackColor = System.Drawing.Color.Black;
            this.Agree.ForeColor = System.Drawing.Color.White;
            this.Agree.Location = new System.Drawing.Point(537, 263);
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
            this.Disagree.ForeColor = System.Drawing.Color.White;
            this.Disagree.Location = new System.Drawing.Point(618, 263);
            this.Disagree.Name = "Disagree";
            this.Disagree.Size = new System.Drawing.Size(75, 23);
            this.Disagree.TabIndex = 2;
            this.Disagree.Text = "I Disagree";
            this.Disagree.UseVisualStyleBackColor = false;
            this.Disagree.Click += new System.EventHandler(this.Disagree_Click);
            // 
            // Usage_Agreement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(705, 294);
            this.Controls.Add(this.Disagree);
            this.Controls.Add(this.Agree);
            this.Controls.Add(this.richTextBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Usage_Agreement";
            this.Text = "Usage_Agreement";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button Agree;
        private System.Windows.Forms.Button Disagree;
    }
}