﻿namespace Behave_Tool
{
    partial class ActiveTcpConnections
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ActiveTcpConnections));
            this.SaveToTxt = new System.Windows.Forms.Button();
            this.ClearList = new System.Windows.Forms.Button();
            this.Scan = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.Close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SaveToTxt
            // 
            this.SaveToTxt.BackColor = System.Drawing.Color.Black;
            this.SaveToTxt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SaveToTxt.BackgroundImage")));
            this.SaveToTxt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SaveToTxt.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SaveToTxt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveToTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.SaveToTxt.ForeColor = System.Drawing.Color.White;
            this.SaveToTxt.Location = new System.Drawing.Point(436, 100);
            this.SaveToTxt.Name = "SaveToTxt";
            this.SaveToTxt.Size = new System.Drawing.Size(87, 23);
            this.SaveToTxt.TabIndex = 42;
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
            this.ClearList.ForeColor = System.Drawing.Color.White;
            this.ClearList.Location = new System.Drawing.Point(436, 71);
            this.ClearList.Name = "ClearList";
            this.ClearList.Size = new System.Drawing.Size(87, 23);
            this.ClearList.TabIndex = 41;
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
            this.Scan.ForeColor = System.Drawing.Color.White;
            this.Scan.Location = new System.Drawing.Point(436, 31);
            this.Scan.Name = "Scan";
            this.Scan.Size = new System.Drawing.Size(87, 23);
            this.Scan.TabIndex = 40;
            this.Scan.Text = "Scan\r\n";
            this.Scan.UseVisualStyleBackColor = false;
            this.Scan.Click += new System.EventHandler(this.Scan_Click);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.Black;
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox1.ForeColor = System.Drawing.Color.White;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 31);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(418, 223);
            this.listBox1.TabIndex = 39;
            // 
            // Close
            // 
            this.Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Close.BackColor = System.Drawing.Color.Transparent;
            this.Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Close.Location = new System.Drawing.Point(510, 0);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(24, 24);
            this.Close.TabIndex = 43;
            this.Close.Text = "X";
            this.Close.UseVisualStyleBackColor = false;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // ActiveTcpConnections
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(534, 268);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.SaveToTxt);
            this.Controls.Add(this.ClearList);
            this.Controls.Add(this.Scan);
            this.Controls.Add(this.listBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ActiveTcpConnections";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ActiveTcpConnections";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SaveToTxt;
        private System.Windows.Forms.Button ClearList;
        private System.Windows.Forms.Button Scan;
        private System.Windows.Forms.ListBox listBox1;
        private new System.Windows.Forms.Button Close;
    }
}