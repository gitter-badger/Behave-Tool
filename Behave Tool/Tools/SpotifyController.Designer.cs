namespace Behave_Tool
{
    partial class SpotifyController
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
            this.bigAlbumPicture = new System.Windows.Forms.PictureBox();
            this.skipBtn = new System.Windows.Forms.Button();
            this.prevBtn = new System.Windows.Forms.Button();
            this.playBtn = new System.Windows.Forms.Button();
            this.timeProgressBar = new System.Windows.Forms.ProgressBar();
            this.Volume = new System.Windows.Forms.TrackBar();
            this.clientVersionLabel = new System.Windows.Forms.Label();
            this.versionLabel = new System.Windows.Forms.Label();
            this.artistLinkLabel = new System.Windows.Forms.LinkLabel();
            this.titleLinkLabel = new System.Windows.Forms.LinkLabel();
            this.albumLinkLabel = new System.Windows.Forms.LinkLabel();
            this.trackInfoBox = new System.Windows.Forms.Label();
            this.volumeLabel = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.isPlayingLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bigAlbumPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Volume)).BeginInit();
            this.SuspendLayout();
            // 
            // bigAlbumPicture
            // 
            this.bigAlbumPicture.Location = new System.Drawing.Point(12, 65);
            this.bigAlbumPicture.Name = "bigAlbumPicture";
            this.bigAlbumPicture.Size = new System.Drawing.Size(102, 92);
            this.bigAlbumPicture.TabIndex = 1;
            this.bigAlbumPicture.TabStop = false;
            // 
            // skipBtn
            // 
            this.skipBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.skipBtn.BackColor = System.Drawing.Color.Black;
            this.skipBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.skipBtn.FlatAppearance.BorderSize = 2;
            this.skipBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.skipBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.skipBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.skipBtn.Location = new System.Drawing.Point(213, 135);
            this.skipBtn.Name = "skipBtn";
            this.skipBtn.Size = new System.Drawing.Size(28, 23);
            this.skipBtn.TabIndex = 2;
            this.skipBtn.Text = ">";
            this.skipBtn.UseVisualStyleBackColor = false;
            this.skipBtn.Click += new System.EventHandler(this.skipBtn_Click);
            // 
            // prevBtn
            // 
            this.prevBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.prevBtn.BackColor = System.Drawing.Color.Black;
            this.prevBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.prevBtn.FlatAppearance.BorderSize = 2;
            this.prevBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.prevBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.prevBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.prevBtn.Location = new System.Drawing.Point(145, 135);
            this.prevBtn.Name = "prevBtn";
            this.prevBtn.Size = new System.Drawing.Size(28, 23);
            this.prevBtn.TabIndex = 3;
            this.prevBtn.Text = "<";
            this.prevBtn.UseVisualStyleBackColor = false;
            this.prevBtn.Click += new System.EventHandler(this.prevBtn_Click);
            // 
            // playBtn
            // 
            this.playBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.playBtn.BackColor = System.Drawing.Color.Black;
            this.playBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.playBtn.FlatAppearance.BorderSize = 2;
            this.playBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.playBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.playBtn.Location = new System.Drawing.Point(179, 135);
            this.playBtn.Name = "playBtn";
            this.playBtn.Size = new System.Drawing.Size(28, 23);
            this.playBtn.TabIndex = 4;
            this.playBtn.Text = "| |";
            this.playBtn.UseVisualStyleBackColor = false;
            this.playBtn.Click += new System.EventHandler(this.playBtn_Click);
            // 
            // timeProgressBar
            // 
            this.timeProgressBar.BackColor = System.Drawing.Color.Black;
            this.timeProgressBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.timeProgressBar.Location = new System.Drawing.Point(123, 118);
            this.timeProgressBar.Name = "timeProgressBar";
            this.timeProgressBar.Size = new System.Drawing.Size(269, 10);
            this.timeProgressBar.TabIndex = 5;
            // 
            // Volume
            // 
            this.Volume.Location = new System.Drawing.Point(288, 134);
            this.Volume.Name = "Volume";
            this.Volume.Size = new System.Drawing.Size(104, 45);
            this.Volume.TabIndex = 7;
            // 
            // clientVersionLabel
            // 
            this.clientVersionLabel.AutoSize = true;
            this.clientVersionLabel.BackColor = System.Drawing.Color.Transparent;
            this.clientVersionLabel.ForeColor = System.Drawing.Color.White;
            this.clientVersionLabel.Location = new System.Drawing.Point(9, 9);
            this.clientVersionLabel.Name = "clientVersionLabel";
            this.clientVersionLabel.Size = new System.Drawing.Size(71, 13);
            this.clientVersionLabel.TabIndex = 8;
            this.clientVersionLabel.Text = "Client Version";
            // 
            // versionLabel
            // 
            this.versionLabel.AutoSize = true;
            this.versionLabel.BackColor = System.Drawing.Color.Transparent;
            this.versionLabel.ForeColor = System.Drawing.Color.White;
            this.versionLabel.Location = new System.Drawing.Point(9, 25);
            this.versionLabel.Name = "versionLabel";
            this.versionLabel.Size = new System.Drawing.Size(42, 13);
            this.versionLabel.TabIndex = 9;
            this.versionLabel.Text = "Version";
            // 
            // artistLinkLabel
            // 
            this.artistLinkLabel.AutoSize = true;
            this.artistLinkLabel.LinkColor = System.Drawing.Color.White;
            this.artistLinkLabel.Location = new System.Drawing.Point(121, 77);
            this.artistLinkLabel.Name = "artistLinkLabel";
            this.artistLinkLabel.Size = new System.Drawing.Size(30, 13);
            this.artistLinkLabel.TabIndex = 11;
            this.artistLinkLabel.TabStop = true;
            this.artistLinkLabel.Text = "Artist";
            // 
            // titleLinkLabel
            // 
            this.titleLinkLabel.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.titleLinkLabel.AutoSize = true;
            this.titleLinkLabel.BackColor = System.Drawing.Color.Transparent;
            this.titleLinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLinkLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.titleLinkLabel.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.titleLinkLabel.Location = new System.Drawing.Point(121, 48);
            this.titleLinkLabel.Name = "titleLinkLabel";
            this.titleLinkLabel.Size = new System.Drawing.Size(40, 18);
            this.titleLinkLabel.TabIndex = 12;
            this.titleLinkLabel.TabStop = true;
            this.titleLinkLabel.Text = "Title";
            // 
            // albumLinkLabel
            // 
            this.albumLinkLabel.AutoSize = true;
            this.albumLinkLabel.LinkColor = System.Drawing.Color.White;
            this.albumLinkLabel.Location = new System.Drawing.Point(121, 102);
            this.albumLinkLabel.Name = "albumLinkLabel";
            this.albumLinkLabel.Size = new System.Drawing.Size(36, 13);
            this.albumLinkLabel.TabIndex = 13;
            this.albumLinkLabel.TabStop = true;
            this.albumLinkLabel.Text = "Album";
            // 
            // trackInfoBox
            // 
            this.trackInfoBox.AutoSize = true;
            this.trackInfoBox.BackColor = System.Drawing.Color.Transparent;
            this.trackInfoBox.ForeColor = System.Drawing.Color.White;
            this.trackInfoBox.Location = new System.Drawing.Point(9, 52);
            this.trackInfoBox.Name = "trackInfoBox";
            this.trackInfoBox.Size = new System.Drawing.Size(56, 13);
            this.trackInfoBox.TabIndex = 14;
            this.trackInfoBox.Text = "Track Info";
            // 
            // volumeLabel
            // 
            this.volumeLabel.AutoSize = true;
            this.volumeLabel.BackColor = System.Drawing.Color.Transparent;
            this.volumeLabel.ForeColor = System.Drawing.Color.White;
            this.volumeLabel.Location = new System.Drawing.Point(247, 139);
            this.volumeLabel.Name = "volumeLabel";
            this.volumeLabel.Size = new System.Drawing.Size(42, 13);
            this.volumeLabel.TabIndex = 15;
            this.volumeLabel.Text = "Volume";
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.BackColor = System.Drawing.Color.Transparent;
            this.timeLabel.ForeColor = System.Drawing.Color.White;
            this.timeLabel.Location = new System.Drawing.Point(398, 115);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(28, 13);
            this.timeLabel.TabIndex = 16;
            this.timeLabel.Text = "0:00";
            // 
            // isPlayingLabel
            // 
            this.isPlayingLabel.AutoSize = true;
            this.isPlayingLabel.BackColor = System.Drawing.Color.Transparent;
            this.isPlayingLabel.ForeColor = System.Drawing.Color.White;
            this.isPlayingLabel.Location = new System.Drawing.Point(120, 9);
            this.isPlayingLabel.Name = "isPlayingLabel";
            this.isPlayingLabel.Size = new System.Drawing.Size(52, 13);
            this.isPlayingLabel.TabIndex = 17;
            this.isPlayingLabel.Text = "Is Playing";
            // 
            // Spotify_Controler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(429, 170);
            this.Controls.Add(this.isPlayingLabel);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.volumeLabel);
            this.Controls.Add(this.trackInfoBox);
            this.Controls.Add(this.albumLinkLabel);
            this.Controls.Add(this.titleLinkLabel);
            this.Controls.Add(this.artistLinkLabel);
            this.Controls.Add(this.versionLabel);
            this.Controls.Add(this.clientVersionLabel);
            this.Controls.Add(this.Volume);
            this.Controls.Add(this.timeProgressBar);
            this.Controls.Add(this.playBtn);
            this.Controls.Add(this.prevBtn);
            this.Controls.Add(this.skipBtn);
            this.Controls.Add(this.bigAlbumPicture);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Spotify_Controler";
            ((System.ComponentModel.ISupportInitialize)(this.bigAlbumPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Volume)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox bigAlbumPicture;
        private System.Windows.Forms.Button skipBtn;
        private System.Windows.Forms.Button prevBtn;
        private System.Windows.Forms.Button playBtn;
        private System.Windows.Forms.ProgressBar timeProgressBar;
        private System.Windows.Forms.TrackBar Volume;
        private System.Windows.Forms.Label clientVersionLabel;
        private System.Windows.Forms.Label versionLabel;
        private System.Windows.Forms.LinkLabel artistLinkLabel;
        private System.Windows.Forms.LinkLabel titleLinkLabel;
        private System.Windows.Forms.LinkLabel albumLinkLabel;
        private System.Windows.Forms.Label trackInfoBox;
        private System.Windows.Forms.Label volumeLabel;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label isPlayingLabel;
    }
}