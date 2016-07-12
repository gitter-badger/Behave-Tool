namespace MassRepo
{
    partial class StorageDrives
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
            this.DrivesList = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // DrivesList
            // 
            this.DrivesList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.DrivesList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DrivesList.ForeColor = System.Drawing.Color.White;
            this.DrivesList.GridLines = true;
            this.DrivesList.Location = new System.Drawing.Point(0, 0);
            this.DrivesList.Name = "DrivesList";
            this.DrivesList.Size = new System.Drawing.Size(186, 130);
            this.DrivesList.TabIndex = 0;
            this.DrivesList.UseCompatibleStateImageBehavior = false;
            this.DrivesList.View = System.Windows.Forms.View.List;
            // 
            // StorageDrives
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.DrivesList);
            this.Name = "StorageDrives";
            this.Size = new System.Drawing.Size(186, 130);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView DrivesList;
    }
}
