namespace MassRepo.Tools.Network
{
    partial class LocalPortScanner
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LocalPortScanner));
            this.label6 = new System.Windows.Forms.Label();
            this.SaveToTxt = new System.Windows.Forms.Button();
            this.ScanStatus = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.RangeMax = new System.Windows.Forms.TextBox();
            this.RangeMin = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.ClearList = new System.Windows.Forms.Button();
            this.StopScan = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ScanRange = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SinglePortBox = new System.Windows.Forms.TextBox();
            this.ScanSingle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(32, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 55;
            this.label6.Text = "Open Ports";
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
            this.SaveToTxt.Location = new System.Drawing.Point(291, 191);
            this.SaveToTxt.Name = "SaveToTxt";
            this.SaveToTxt.Size = new System.Drawing.Size(87, 23);
            this.SaveToTxt.TabIndex = 54;
            this.SaveToTxt.Text = "Save .txt";
            this.SaveToTxt.UseVisualStyleBackColor = false;
            this.SaveToTxt.Click += new System.EventHandler(this.SaveToTxt_Click);
            // 
            // ScanStatus
            // 
            this.ScanStatus.BackColor = System.Drawing.Color.Transparent;
            this.ScanStatus.ForeColor = System.Drawing.Color.White;
            this.ScanStatus.Location = new System.Drawing.Point(98, 123);
            this.ScanStatus.Name = "ScanStatus";
            this.ScanStatus.Size = new System.Drawing.Size(178, 13);
            this.ScanStatus.TabIndex = 53;
            this.ScanStatus.Text = "Scan Status";
            // 
            // listBox1
            // 
            this.listBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listBox1.BackColor = System.Drawing.Color.Black;
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox1.ForeColor = System.Drawing.Color.White;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(98, 162);
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBox1.Size = new System.Drawing.Size(178, 145);
            this.listBox1.TabIndex = 52;
            // 
            // RangeMax
            // 
            this.RangeMax.BackColor = System.Drawing.Color.Black;
            this.RangeMax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RangeMax.ForeColor = System.Drawing.Color.White;
            this.RangeMax.Location = new System.Drawing.Point(214, 89);
            this.RangeMax.Name = "RangeMax";
            this.RangeMax.Size = new System.Drawing.Size(62, 20);
            this.RangeMax.TabIndex = 51;
            // 
            // RangeMin
            // 
            this.RangeMin.BackColor = System.Drawing.Color.Black;
            this.RangeMin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RangeMin.ForeColor = System.Drawing.Color.White;
            this.RangeMin.Location = new System.Drawing.Point(98, 89);
            this.RangeMin.Name = "RangeMin";
            this.RangeMin.Size = new System.Drawing.Size(62, 20);
            this.RangeMin.TabIndex = 50;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.BackColor = System.Drawing.Color.Transparent;
            this.label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label.Location = new System.Drawing.Point(52, 123);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(40, 13);
            this.label.TabIndex = 49;
            this.label.Text = "Status:";
            // 
            // ClearList
            // 
            this.ClearList.BackColor = System.Drawing.Color.Black;
            this.ClearList.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ClearList.BackgroundImage")));
            this.ClearList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClearList.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClearList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearList.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.ClearList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClearList.Location = new System.Drawing.Point(291, 162);
            this.ClearList.Name = "ClearList";
            this.ClearList.Size = new System.Drawing.Size(87, 23);
            this.ClearList.TabIndex = 48;
            this.ClearList.Text = "Clear List";
            this.ClearList.UseVisualStyleBackColor = false;
            this.ClearList.Click += new System.EventHandler(this.ClearList_Click);
            // 
            // StopScan
            // 
            this.StopScan.BackColor = System.Drawing.Color.Black;
            this.StopScan.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("StopScan.BackgroundImage")));
            this.StopScan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.StopScan.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.StopScan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StopScan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.StopScan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.StopScan.Location = new System.Drawing.Point(291, 118);
            this.StopScan.Name = "StopScan";
            this.StopScan.Size = new System.Drawing.Size(87, 23);
            this.StopScan.TabIndex = 47;
            this.StopScan.Text = "Stop Scan";
            this.StopScan.UseVisualStyleBackColor = false;
            this.StopScan.Click += new System.EventHandler(this.StopScan_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(233, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 46;
            this.label5.Text = "Max";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(118, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 13);
            this.label4.TabIndex = 45;
            this.label4.Text = "Min";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(175, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 44;
            this.label3.Text = "To";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(10, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 43;
            this.label2.Text = "Scan By Range";
            // 
            // ScanRange
            // 
            this.ScanRange.BackColor = System.Drawing.Color.Black;
            this.ScanRange.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ScanRange.BackgroundImage")));
            this.ScanRange.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ScanRange.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ScanRange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ScanRange.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.ScanRange.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ScanRange.Location = new System.Drawing.Point(291, 89);
            this.ScanRange.Name = "ScanRange";
            this.ScanRange.Size = new System.Drawing.Size(87, 23);
            this.ScanRange.TabIndex = 42;
            this.ScanRange.Text = "Scan";
            this.ScanRange.UseVisualStyleBackColor = false;
            this.ScanRange.Click += new System.EventHandler(this.ScanRange_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(6, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 41;
            this.label1.Text = "Scan Single Port";
            // 
            // SinglePortBox
            // 
            this.SinglePortBox.BackColor = System.Drawing.Color.Black;
            this.SinglePortBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SinglePortBox.ForeColor = System.Drawing.Color.White;
            this.SinglePortBox.Location = new System.Drawing.Point(98, 38);
            this.SinglePortBox.Name = "SinglePortBox";
            this.SinglePortBox.Size = new System.Drawing.Size(178, 20);
            this.SinglePortBox.TabIndex = 40;
            // 
            // ScanSingle
            // 
            this.ScanSingle.BackColor = System.Drawing.Color.Black;
            this.ScanSingle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ScanSingle.BackgroundImage")));
            this.ScanSingle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ScanSingle.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ScanSingle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ScanSingle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.ScanSingle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ScanSingle.Location = new System.Drawing.Point(291, 37);
            this.ScanSingle.Name = "ScanSingle";
            this.ScanSingle.Size = new System.Drawing.Size(87, 23);
            this.ScanSingle.TabIndex = 39;
            this.ScanSingle.Text = "Scan";
            this.ScanSingle.UseVisualStyleBackColor = false;
            this.ScanSingle.Click += new System.EventHandler(this.ScanSingle_Click);
            // 
            // LocalPortScanner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 324);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.SaveToTxt);
            this.Controls.Add(this.ScanStatus);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.RangeMax);
            this.Controls.Add(this.RangeMin);
            this.Controls.Add(this.label);
            this.Controls.Add(this.ClearList);
            this.Controls.Add(this.StopScan);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ScanRange);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SinglePortBox);
            this.Controls.Add(this.ScanSingle);
            this.Name = "LocalPortScanner";
            this.Text = "clone";
            this.Controls.SetChildIndex(this.ScanSingle, 0);
            this.Controls.SetChildIndex(this.SinglePortBox, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.ScanRange, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.StopScan, 0);
            this.Controls.SetChildIndex(this.ClearList, 0);
            this.Controls.SetChildIndex(this.label, 0);
            this.Controls.SetChildIndex(this.RangeMin, 0);
            this.Controls.SetChildIndex(this.RangeMax, 0);
            this.Controls.SetChildIndex(this.listBox1, 0);
            this.Controls.SetChildIndex(this.ScanStatus, 0);
            this.Controls.SetChildIndex(this.SaveToTxt, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button SaveToTxt;
        private System.Windows.Forms.Label ScanStatus;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox RangeMax;
        private System.Windows.Forms.TextBox RangeMin;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button ClearList;
        private System.Windows.Forms.Button StopScan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ScanRange;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SinglePortBox;
        private System.Windows.Forms.Button ScanSingle;
    }
}