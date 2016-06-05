namespace Behave_Tool
{
    partial class Behave_Settings
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Text2_Label = new System.Windows.Forms.Label();
            this.Text2_Colour = new System.Windows.Forms.TextBox();
            this.Text1_Label = new System.Windows.Forms.Label();
            this.Text1_Colour = new System.Windows.Forms.TextBox();
            this.SaveSettings = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(522, 217);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Black;
            this.tabPage2.Controls.Add(this.trackBar1);
            this.tabPage2.Controls.Add(this.checkBox1);
            this.tabPage2.Controls.Add(this.Text2_Label);
            this.tabPage2.Controls.Add(this.Text2_Colour);
            this.tabPage2.Controls.Add(this.Text1_Label);
            this.tabPage2.Controls.Add(this.Text1_Colour);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(514, 191);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Personalise";
            // 
            // Text2_Label
            // 
            this.Text2_Label.AutoSize = true;
            this.Text2_Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Text2_Label.Location = new System.Drawing.Point(18, 51);
            this.Text2_Label.Name = "Text2_Label";
            this.Text2_Label.Size = new System.Drawing.Size(76, 13);
            this.Text2_Label.TabIndex = 4;
            this.Text2_Label.Text = "Text 2 Colour: ";
            // 
            // Text2_Colour
            // 
            this.Text2_Colour.BackColor = System.Drawing.Color.Black;
            this.Text2_Colour.ForeColor = System.Drawing.Color.White;
            this.Text2_Colour.Location = new System.Drawing.Point(100, 48);
            this.Text2_Colour.Name = "Text2_Colour";
            this.Text2_Colour.Size = new System.Drawing.Size(100, 20);
            this.Text2_Colour.TabIndex = 3;
            // 
            // Text1_Label
            // 
            this.Text1_Label.AutoSize = true;
            this.Text1_Label.ForeColor = System.Drawing.Color.White;
            this.Text1_Label.Location = new System.Drawing.Point(18, 25);
            this.Text1_Label.Name = "Text1_Label";
            this.Text1_Label.Size = new System.Drawing.Size(76, 13);
            this.Text1_Label.TabIndex = 1;
            this.Text1_Label.Text = "Text 1 Colour: ";
            // 
            // Text1_Colour
            // 
            this.Text1_Colour.BackColor = System.Drawing.Color.Black;
            this.Text1_Colour.ForeColor = System.Drawing.Color.White;
            this.Text1_Colour.Location = new System.Drawing.Point(100, 22);
            this.Text1_Colour.Name = "Text1_Colour";
            this.Text1_Colour.Size = new System.Drawing.Size(100, 20);
            this.Text1_Colour.TabIndex = 0;
            // 
            // SaveSettings
            // 
            this.SaveSettings.Location = new System.Drawing.Point(435, 235);
            this.SaveSettings.Name = "SaveSettings";
            this.SaveSettings.Size = new System.Drawing.Size(75, 23);
            this.SaveSettings.TabIndex = 2;
            this.SaveSettings.Text = "Apply";
            this.SaveSettings.UseVisualStyleBackColor = true;
            this.SaveSettings.Click += new System.EventHandler(this.SaveSettings_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.Transparent;
            this.checkBox1.ForeColor = System.Drawing.Color.White;
            this.checkBox1.Location = new System.Drawing.Point(21, 110);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(90, 17);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "Keep On Top";
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // trackBar1
            // 
            this.trackBar1.Enabled = false;
            this.trackBar1.LargeChange = 1;
            this.trackBar1.Location = new System.Drawing.Point(404, 150);
            this.trackBar1.Minimum = 3;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(104, 45);
            this.trackBar1.TabIndex = 10;
            this.trackBar1.Value = 3;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // Behave_Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(546, 267);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.SaveSettings);
            this.Name = "Behave_Settings";
            this.Text = "Behave_Settings";
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label Text2_Label;
        private System.Windows.Forms.TextBox Text2_Colour;
        private System.Windows.Forms.Label Text1_Label;
        private System.Windows.Forms.TextBox Text1_Colour;
        private System.Windows.Forms.Button SaveSettings;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TrackBar trackBar1;
    }
}