﻿namespace Behave_Tool
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.UserName = new System.Windows.Forms.TextBox();
            this.PassWord = new System.Windows.Forms.TextBox();
            this.Log_In = new System.Windows.Forms.Button();
            this.Close = new System.Windows.Forms.Button();
            this.AttemptCount = new System.Windows.Forms.Label();
            this.Error = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(8, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(9, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // UserName
            // 
            this.UserName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UserName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.UserName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UserName.ForeColor = System.Drawing.Color.White;
            this.UserName.Location = new System.Drawing.Point(79, 6);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(94, 13);
            this.UserName.TabIndex = 2;
            // 
            // PassWord
            // 
            this.PassWord.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PassWord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PassWord.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PassWord.ForeColor = System.Drawing.Color.White;
            this.PassWord.Location = new System.Drawing.Point(79, 32);
            this.PassWord.Name = "PassWord";
            this.PassWord.Size = new System.Drawing.Size(94, 13);
            this.PassWord.TabIndex = 3;
            // 
            // Log_In
            // 
            this.Log_In.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Log_In.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Log_In.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Log_In.ForeColor = System.Drawing.Color.White;
            this.Log_In.Image = global::Behave_Tool.Properties.Resources.Button;
            this.Log_In.Location = new System.Drawing.Point(88, 73);
            this.Log_In.Name = "Log_In";
            this.Log_In.Size = new System.Drawing.Size(75, 23);
            this.Log_In.TabIndex = 4;
            this.Log_In.Text = "Log In";
            this.Log_In.UseVisualStyleBackColor = true;
            this.Log_In.Click += new System.EventHandler(this.Log_In_Click);
            // 
            // Close
            // 
            this.Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Close.BackColor = System.Drawing.Color.Transparent;
            this.Close.BackgroundImage = global::Behave_Tool.Properties.Resources.Close;
            this.Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Close.Location = new System.Drawing.Point(353, 0);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(24, 24);
            this.Close.TabIndex = 5;
            this.Close.UseVisualStyleBackColor = false;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // AttemptCount
            // 
            this.AttemptCount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AttemptCount.AutoSize = true;
            this.AttemptCount.BackColor = System.Drawing.Color.Transparent;
            this.AttemptCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.AttemptCount.Location = new System.Drawing.Point(87, 54);
            this.AttemptCount.Name = "AttemptCount";
            this.AttemptCount.Size = new System.Drawing.Size(77, 13);
            this.AttemptCount.TabIndex = 6;
            this.AttemptCount.Text = "Attempts left: 3";
            // 
            // Error
            // 
            this.Error.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Error.AutoSize = true;
            this.Error.BackColor = System.Drawing.Color.Transparent;
            this.Error.ForeColor = System.Drawing.Color.Red;
            this.Error.Location = new System.Drawing.Point(4, 78);
            this.Error.Name = "Error";
            this.Error.Size = new System.Drawing.Size(64, 13);
            this.Error.TabIndex = 7;
            this.Error.Text = "Login Failed";
            this.Error.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = global::Behave_Tool.Properties.Resources.Behave;
            this.pictureBox1.InitialImage = global::Behave_Tool.Properties.Resources.Behave;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(132, 122);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Error, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.UserName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.AttemptCount, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.Log_In, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.PassWord, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(164, 22);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 17F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(180, 100);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(377, 121);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.Opacity = 0.9D;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Log_In;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox PassWord;
        public System.Windows.Forms.TextBox UserName;
        private new System.Windows.Forms.Button Close;
        private System.Windows.Forms.Label AttemptCount;
        private System.Windows.Forms.Label Error;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}