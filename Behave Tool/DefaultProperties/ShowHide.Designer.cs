namespace Behave_Tool
{
    partial class ShowHide
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowHide));
            this.ShowHideToggle = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.WidgetName = new System.Windows.Forms.ToolStripLabel();
            this.Close = new System.Windows.Forms.ToolStripButton();
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ShowHideToggle
            // 
            this.ShowHideToggle.Appearance = System.Windows.Forms.Appearance.Button;
            this.ShowHideToggle.AutoSize = true;
            this.ShowHideToggle.BackColor = System.Drawing.Color.Black;
            this.ShowHideToggle.BackgroundImage = global::Behave_Tool.Properties.Resources.Button;
            this.ShowHideToggle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ShowHideToggle.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ShowHideToggle.Checked = true;
            this.ShowHideToggle.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ShowHideToggle.Dock = System.Windows.Forms.DockStyle.Right;
            this.ShowHideToggle.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ShowHideToggle.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.ShowHideToggle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShowHideToggle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ShowHideToggle.Location = new System.Drawing.Point(222, 0);
            this.ShowHideToggle.Margin = new System.Windows.Forms.Padding(1);
            this.ShowHideToggle.Name = "ShowHideToggle";
            this.ShowHideToggle.Size = new System.Drawing.Size(23, 111);
            this.ShowHideToggle.TabIndex = 0;
            this.ShowHideToggle.Text = ">";
            this.ShowHideToggle.UseVisualStyleBackColor = false;
            this.ShowHideToggle.CheckStateChanged += new System.EventHandler(this.ShowHideToggle_CheckStateChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.panel1.Controls.Add(this.ShowHideToggle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(245, 111);
            this.panel1.TabIndex = 1;
            // 
            // toolStrip1
            // 
            this.toolStrip1.AllowMerge = false;
            this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.WidgetName,
            this.Close});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.ShowItemToolTips = false;
            this.toolStrip1.Size = new System.Drawing.Size(245, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "Widget";
            this.toolStrip1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.toolStrip1_MouseDown);
            // 
            // WidgetName
            // 
            this.WidgetName.BackColor = System.Drawing.Color.Transparent;
            this.WidgetName.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.WidgetName.ForeColor = System.Drawing.Color.White;
            this.WidgetName.Name = "WidgetName";
            this.WidgetName.Size = new System.Drawing.Size(80, 22);
            this.WidgetName.Text = "Widget Name";
            // 
            // Close
            // 
            this.Close.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.Close.BackgroundImage = global::Behave_Tool.Properties.Resources.Button;
            this.Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Close.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Close.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Close.Image = ((System.Drawing.Image)(resources.GetObject("Close.Image")));
            this.Close.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(23, 22);
            this.Close.Text = "X";
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // ShowHide
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(245, 138);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ShowHide";
            this.Opacity = 0.97D;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Load += new System.EventHandler(this.ShowHide_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox ShowHideToggle;
        protected System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel WidgetName;
        private new System.Windows.Forms.ToolStripButton Close;
    }
}
