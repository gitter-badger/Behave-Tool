namespace MassRepo.Widget
{
    partial class WidgetList
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
            this.List = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // List
            // 
            this.List.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.List.Dock = System.Windows.Forms.DockStyle.Fill;
            this.List.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.List.Location = new System.Drawing.Point(0, 0);
            this.List.Name = "List";
            this.List.Size = new System.Drawing.Size(127, 248);
            this.List.TabIndex = 0;
            this.List.UseCompatibleStateImageBehavior = false;
            this.List.View = System.Windows.Forms.View.Tile;
            this.List.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.List_ItemDrag);
            this.List.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DragDrop_MouseClick);
            // 
            // WidgetList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.List);
            this.Name = "WidgetList";
            this.Size = new System.Drawing.Size(127, 248);
            this.Load += new System.EventHandler(this.ListViewDragDrop_Load);
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.ListView List;
    }
}
