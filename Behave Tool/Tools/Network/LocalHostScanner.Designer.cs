namespace Behave_Tool.Tools.Network
{
    partial class LocalHostScanner
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LocalHostScanner));
            this.Status = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.SaveToTxt = new System.Windows.Forms.Button();
            this.ClearList = new System.Windows.Forms.Button();
            this.Scan = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // Status
            // 
            this.Status.AutoSize = true;
            this.Status.ForeColor = System.Drawing.Color.Lime;
            this.Status.Location = new System.Drawing.Point(59, 35);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(24, 13);
            this.Status.TabIndex = 47;
            this.Status.Text = "Idle";
            this.Status.Visible = false;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.ForeColor = System.Drawing.Color.White;
            this.label.Location = new System.Drawing.Point(10, 35);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(40, 13);
            this.label.TabIndex = 46;
            this.label.Text = "Status:";
            this.label.Visible = false;
            // 
            // SaveToTxt
            // 
            this.SaveToTxt.BackColor = System.Drawing.Color.Black;
            this.SaveToTxt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SaveToTxt.BackgroundImage")));
            this.SaveToTxt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SaveToTxt.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SaveToTxt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveToTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.SaveToTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.SaveToTxt.Location = new System.Drawing.Point(436, 123);
            this.SaveToTxt.Name = "SaveToTxt";
            this.SaveToTxt.Size = new System.Drawing.Size(87, 23);
            this.SaveToTxt.TabIndex = 45;
            this.SaveToTxt.Text = "Save .txt";
            this.SaveToTxt.UseVisualStyleBackColor = false;
            this.SaveToTxt.Click += new System.EventHandler(this.SaveToTxt_Click);
            // 
            // ClearList
            // 
            this.ClearList.BackColor = System.Drawing.Color.Black;
            this.ClearList.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ClearList.BackgroundImage")));
            this.ClearList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClearList.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClearList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClearList.Location = new System.Drawing.Point(436, 94);
            this.ClearList.Name = "ClearList";
            this.ClearList.Size = new System.Drawing.Size(87, 23);
            this.ClearList.TabIndex = 44;
            this.ClearList.Text = "Clear List";
            this.ClearList.UseVisualStyleBackColor = false;
            this.ClearList.Click += new System.EventHandler(this.ClearList_Click);
            // 
            // Scan
            // 
            this.Scan.BackColor = System.Drawing.Color.Black;
            this.Scan.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Scan.BackgroundImage")));
            this.Scan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Scan.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Scan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Scan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Scan.Location = new System.Drawing.Point(436, 54);
            this.Scan.Name = "Scan";
            this.Scan.Size = new System.Drawing.Size(87, 23);
            this.Scan.TabIndex = 43;
            this.Scan.Text = "Scan\r\n";
            this.Scan.UseVisualStyleBackColor = false;
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.Black;
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox1.ForeColor = System.Drawing.Color.White;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 54);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(418, 223);
            this.listBox1.TabIndex = 42;
            // 
            // cline
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 288);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.label);
            this.Controls.Add(this.SaveToTxt);
            this.Controls.Add(this.ClearList);
            this.Controls.Add(this.Scan);
            this.Controls.Add(this.listBox1);
            this.Name = "cline";
            this.Text = "cline";
            this.Controls.SetChildIndex(this.listBox1, 0);
            this.Controls.SetChildIndex(this.Scan, 0);
            this.Controls.SetChildIndex(this.ClearList, 0);
            this.Controls.SetChildIndex(this.SaveToTxt, 0);
            this.Controls.SetChildIndex(this.label, 0);
            this.Controls.SetChildIndex(this.Status, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Status;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button SaveToTxt;
        private System.Windows.Forms.Button ClearList;
        private System.Windows.Forms.Button Scan;
        private System.Windows.Forms.ListBox listBox1;
    }
}