namespace Behave_Tool
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.UserName = new System.Windows.Forms.TextBox();
            this.PassWord = new System.Windows.Forms.TextBox();
            this.Log_In = new System.Windows.Forms.Button();
            this.AttemptCount = new System.Windows.Forms.Label();
            this.Error = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.saveLogIn = new System.Windows.Forms.CheckBox();
            this.AutoLogin = new System.Windows.Forms.CheckBox();
            this.serverStatus = new System.Windows.Forms.Label();
            this.Close = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 5);
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
            this.label2.Location = new System.Drawing.Point(4, 29);
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
            this.UserName.Location = new System.Drawing.Point(73, 5);
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
            this.PassWord.Location = new System.Drawing.Point(73, 29);
            this.PassWord.Name = "PassWord";
            this.PassWord.Size = new System.Drawing.Size(94, 13);
            this.PassWord.TabIndex = 3;
            this.PassWord.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PassWord_KeyDown);
            // 
            // Log_In
            // 
            this.Log_In.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Log_In.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Log_In.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Log_In.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Log_In.ForeColor = System.Drawing.Color.White;
            this.Log_In.Image = global::Behave_Tool.Properties.Resources.Button;
            this.Log_In.Location = new System.Drawing.Point(7, 25);
            this.Log_In.Name = "Log_In";
            this.Log_In.Size = new System.Drawing.Size(75, 23);
            this.Log_In.TabIndex = 4;
            this.Log_In.Text = "Log In";
            this.Log_In.UseVisualStyleBackColor = true;
            this.Log_In.Click += new System.EventHandler(this.Log_In_Click);
            // 
            // AttemptCount
            // 
            this.AttemptCount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AttemptCount.AutoSize = true;
            this.AttemptCount.BackColor = System.Drawing.Color.Transparent;
            this.AttemptCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.AttemptCount.Location = new System.Drawing.Point(6, 63);
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
            this.Error.Location = new System.Drawing.Point(12, 3);
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
            this.pictureBox1.Location = new System.Drawing.Point(6, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(159, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.44444F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.55556F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.UserName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.PassWord, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.saveLogIn, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.AutoLogin, 1, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(171, 8);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(180, 95);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // saveLogIn
            // 
            this.saveLogIn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.saveLogIn.AutoSize = true;
            this.saveLogIn.BackColor = System.Drawing.Color.Transparent;
            this.saveLogIn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.saveLogIn.ForeColor = System.Drawing.Color.White;
            this.saveLogIn.Location = new System.Drawing.Point(64, 51);
            this.saveLogIn.Name = "saveLogIn";
            this.saveLogIn.Size = new System.Drawing.Size(106, 17);
            this.saveLogIn.TabIndex = 41;
            this.saveLogIn.Text = "Remember Login";
            this.saveLogIn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.saveLogIn.UseVisualStyleBackColor = false;
            this.saveLogIn.CheckedChanged += new System.EventHandler(this.saveLogIn_CheckedChanged);
            // 
            // AutoLogin
            // 
            this.AutoLogin.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.AutoLogin.AutoSize = true;
            this.AutoLogin.BackColor = System.Drawing.Color.Transparent;
            this.AutoLogin.Enabled = false;
            this.AutoLogin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.AutoLogin.ForeColor = System.Drawing.Color.White;
            this.AutoLogin.Location = new System.Drawing.Point(64, 74);
            this.AutoLogin.Name = "AutoLogin";
            this.AutoLogin.Size = new System.Drawing.Size(77, 17);
            this.AutoLogin.TabIndex = 42;
            this.AutoLogin.Text = "Auto Login";
            this.AutoLogin.UseVisualStyleBackColor = false;
            // 
            // serverStatus
            // 
            this.serverStatus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.serverStatus.AutoSize = true;
            this.serverStatus.BackColor = System.Drawing.Color.Transparent;
            this.serverStatus.ForeColor = System.Drawing.Color.White;
            this.serverStatus.Location = new System.Drawing.Point(47, 90);
            this.serverStatus.Name = "serverStatus";
            this.serverStatus.Size = new System.Drawing.Size(68, 13);
            this.serverStatus.TabIndex = 10;
            this.serverStatus.Text = "ServerStatus";
            this.serverStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.serverStatus.TextChanged += new System.EventHandler(this.serverStatus_TextChanged);
            // 
            // Close
            // 
            this.Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Close.BackColor = System.Drawing.Color.Transparent;
            this.Close.BackgroundImage = global::Behave_Tool.Properties.Resources.Button;
            this.Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Close.Location = new System.Drawing.Point(430, 0);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(24, 24);
            this.Close.TabIndex = 40;
            this.Close.Text = "X";
            this.Close.UseVisualStyleBackColor = false;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.Error, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.Log_In, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.AttemptCount, 0, 2);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(357, 13);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.76471F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.23529F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(89, 86);
            this.tableLayoutPanel2.TabIndex = 41;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel2);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.serverStatus);
            this.panel1.Location = new System.Drawing.Point(-1, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(453, 118);
            this.panel1.TabIndex = 42;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(454, 152);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.Opacity = 0.9D;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Log_In;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox PassWord;
        public System.Windows.Forms.TextBox UserName;
        private System.Windows.Forms.Label AttemptCount;
        private System.Windows.Forms.Label Error;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label serverStatus;
        private new System.Windows.Forms.Button Close;
        private System.Windows.Forms.CheckBox saveLogIn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox AutoLogin;
    }
}