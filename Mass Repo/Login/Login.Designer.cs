namespace MassRepo
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
            this.AttemptCount = new System.Windows.Forms.Label();
            this.Error = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SignupBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.saveLogIn = new System.Windows.Forms.CheckBox();
            this.AutoLogin = new System.Windows.Forms.CheckBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.serverStatus = new System.Windows.Forms.ToolStripLabel();
            this.Close = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.version = new System.Windows.Forms.ToolStripLabel();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(10, 9);
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
            this.label2.Location = new System.Drawing.Point(11, 40);
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
            this.UserName.Location = new System.Drawing.Point(86, 9);
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
            this.PassWord.Location = new System.Drawing.Point(86, 40);
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
            this.Log_In.Image = global::MassRepo.Properties.Resources.Button;
            this.Log_In.Location = new System.Drawing.Point(7, 24);
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
            this.AttemptCount.Location = new System.Drawing.Point(6, 60);
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
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.80582F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.19418F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.UserName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.PassWord, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(214, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(191, 62);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.Error, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.Log_In, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.AttemptCount, 0, 2);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(411, -2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.76471F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.23529F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(89, 82);
            this.tableLayoutPanel2.TabIndex = 41;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.SignupBtn);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.saveLogIn);
            this.panel1.Controls.Add(this.AutoLogin);
            this.panel1.Controls.Add(this.tableLayoutPanel2);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Location = new System.Drawing.Point(-1, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(508, 98);
            this.panel1.TabIndex = 42;
            // 
            // SignupBtn
            // 
            this.SignupBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SignupBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SignupBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SignupBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SignupBtn.ForeColor = System.Drawing.Color.White;
            this.SignupBtn.Image = global::MassRepo.Properties.Resources.Button;
            this.SignupBtn.Location = new System.Drawing.Point(62, 63);
            this.SignupBtn.Name = "SignupBtn";
            this.SignupBtn.Size = new System.Drawing.Size(75, 23);
            this.SignupBtn.TabIndex = 50;
            this.SignupBtn.Text = "Sign Up";
            this.SignupBtn.UseVisualStyleBackColor = true;
            this.SignupBtn.Click += new System.EventHandler(this.SignupBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(159, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 17);
            this.label4.TabIndex = 49;
            this.label4.Text = "Alpha";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(13, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 31);
            this.label3.TabIndex = 48;
            this.label3.Text = "MassRepo";
            // 
            // saveLogIn
            // 
            this.saveLogIn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.saveLogIn.AutoSize = true;
            this.saveLogIn.BackColor = System.Drawing.Color.Transparent;
            this.saveLogIn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.saveLogIn.ForeColor = System.Drawing.Color.White;
            this.saveLogIn.Location = new System.Drawing.Point(209, 69);
            this.saveLogIn.Name = "saveLogIn";
            this.saveLogIn.Size = new System.Drawing.Size(106, 17);
            this.saveLogIn.TabIndex = 43;
            this.saveLogIn.Text = "Remember Login";
            this.saveLogIn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.saveLogIn.UseVisualStyleBackColor = false;
            // 
            // AutoLogin
            // 
            this.AutoLogin.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.AutoLogin.AutoSize = true;
            this.AutoLogin.BackColor = System.Drawing.Color.Transparent;
            this.AutoLogin.Enabled = false;
            this.AutoLogin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.AutoLogin.ForeColor = System.Drawing.Color.White;
            this.AutoLogin.Location = new System.Drawing.Point(321, 69);
            this.AutoLogin.Name = "AutoLogin";
            this.AutoLogin.Size = new System.Drawing.Size(77, 17);
            this.AutoLogin.TabIndex = 44;
            this.AutoLogin.Text = "Auto Login";
            this.AutoLogin.UseVisualStyleBackColor = false;
            // 
            // toolStrip1
            // 
            this.toolStrip1.AllowMerge = false;
            this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.toolStrip1.BackgroundImage = global::MassRepo.Properties.Resources.Button;
            this.toolStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.serverStatus,
            this.Close,
            this.toolStripSeparator1,
            this.version});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.ShowItemToolTips = false;
            this.toolStrip1.Size = new System.Drawing.Size(512, 25);
            this.toolStrip1.TabIndex = 43;
            this.toolStrip1.Text = "Widget";
            this.toolStrip1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.toolStrip1_MouseDown);
            // 
            // serverStatus
            // 
            this.serverStatus.BackColor = System.Drawing.Color.Transparent;
            this.serverStatus.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.serverStatus.ForeColor = System.Drawing.Color.White;
            this.serverStatus.Margin = new System.Windows.Forms.Padding(25, 1, 0, 2);
            this.serverStatus.Name = "serverStatus";
            this.serverStatus.Size = new System.Drawing.Size(74, 22);
            this.serverStatus.Text = "Server Status";
            this.serverStatus.TextChanged += new System.EventHandler(this.serverStatus_TextChanged);
            // 
            // Close
            // 
            this.Close.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.Close.AutoToolTip = false;
            this.Close.BackgroundImage = global::MassRepo.Properties.Resources.Button;
            this.Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Close.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Close.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Close.Image = ((System.Drawing.Image)(resources.GetObject("Close.Image")));
            this.Close.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Close.Margin = new System.Windows.Forms.Padding(0);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(23, 25);
            this.Close.Text = "X";
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // version
            // 
            this.version.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.version.BackColor = System.Drawing.Color.Transparent;
            this.version.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.version.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.version.Name = "version";
            this.version.Size = new System.Drawing.Size(45, 22);
            this.version.Text = "Version";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(512, 131);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.Opacity = 0.9D;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Log_In;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PassWord;
        private System.Windows.Forms.Label AttemptCount;
        private System.Windows.Forms.Label Error;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel serverStatus;
        private new System.Windows.Forms.ToolStripButton Close;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel version;
        private System.Windows.Forms.CheckBox saveLogIn;
        private System.Windows.Forms.CheckBox AutoLogin;
        private System.Windows.Forms.TextBox UserName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button SignupBtn;
    }
}