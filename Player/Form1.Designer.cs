namespace Player
{
    partial class PlayerWindow
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayerWindow));
            this.layoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.shuffleBtn = new System.Windows.Forms.PictureBox();
            this.addToPlaylistButton = new System.Windows.Forms.PictureBox();
            this.playlistsButton = new System.Windows.Forms.PictureBox();
            this.favoritesButton = new System.Windows.Forms.PictureBox();
            this.aboutPlaybackButton = new System.Windows.Forms.PictureBox();
            this.addFilesButton = new System.Windows.Forms.PictureBox();
            this.clearPlaylist = new System.Windows.Forms.PictureBox();
            this.Playlist = new System.Windows.Forms.ListBox();
            this.playbackPanel = new System.Windows.Forms.Panel();
            this.mediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.splashImage = new System.Windows.Forms.PictureBox();
            this.OpenFileDialogue = new System.Windows.Forms.OpenFileDialog();
            this.TitleBar = new System.Windows.Forms.Panel();
            this.AppTitle = new System.Windows.Forms.Label();
            this.pinWindow = new System.Windows.Forms.PictureBox();
            this.playbackTitlePanel = new System.Windows.Forms.Panel();
            this.playbackTitle = new System.Windows.Forms.Label();
            this.openMenu = new System.Windows.Forms.PictureBox();
            this.GelPlayerToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.closeButton = new System.Windows.Forms.Button();
            this.buttonBrowser = new System.Windows.Forms.Button();
            this.browserDialogue = new System.Windows.Forms.FolderBrowserDialog();
            this.layoutPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shuffleBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addToPlaylistButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playlistsButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.favoritesButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aboutPlaybackButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addFilesButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clearPlaylist)).BeginInit();
            this.playbackPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mediaPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splashImage)).BeginInit();
            this.TitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pinWindow)).BeginInit();
            this.playbackTitlePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.openMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutPanel
            // 
            this.layoutPanel.ColumnCount = 2;
            this.layoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 352F));
            this.layoutPanel.Controls.Add(this.panel1, 1, 0);
            this.layoutPanel.Controls.Add(this.playbackPanel, 0, 0);
            this.layoutPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.layoutPanel.Location = new System.Drawing.Point(0, 42);
            this.layoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.layoutPanel.Name = "layoutPanel";
            this.layoutPanel.RowCount = 1;
            this.layoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutPanel.Size = new System.Drawing.Size(895, 505);
            this.layoutPanel.TabIndex = 0;
            this.layoutPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.layoutPanel_Paint);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.AliceBlue;
            this.panel1.Controls.Add(this.buttonBrowser);
            this.panel1.Controls.Add(this.shuffleBtn);
            this.panel1.Controls.Add(this.addToPlaylistButton);
            this.panel1.Controls.Add(this.playlistsButton);
            this.panel1.Controls.Add(this.favoritesButton);
            this.panel1.Controls.Add(this.aboutPlaybackButton);
            this.panel1.Controls.Add(this.addFilesButton);
            this.panel1.Controls.Add(this.clearPlaylist);
            this.panel1.Controls.Add(this.Playlist);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(546, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(346, 499);
            this.panel1.TabIndex = 1;
            // 
            // shuffleBtn
            // 
            this.shuffleBtn.BackColor = System.Drawing.Color.Transparent;
            this.shuffleBtn.BackgroundImage = global::Player.Properties.Resources.Shuffle;
            this.shuffleBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.shuffleBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.shuffleBtn.Location = new System.Drawing.Point(223, 462);
            this.shuffleBtn.Name = "shuffleBtn";
            this.shuffleBtn.Padding = new System.Windows.Forms.Padding(2);
            this.shuffleBtn.Size = new System.Drawing.Size(30, 30);
            this.shuffleBtn.TabIndex = 12;
            this.shuffleBtn.TabStop = false;
            this.GelPlayerToolTip.SetToolTip(this.shuffleBtn, "Shuffle Playlist");
            this.shuffleBtn.Click += new System.EventHandler(this.shuffleBtn_Click);
            // 
            // addToPlaylistButton
            // 
            this.addToPlaylistButton.BackColor = System.Drawing.Color.Transparent;
            this.addToPlaylistButton.BackgroundImage = global::Player.Properties.Resources.add;
            this.addToPlaylistButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addToPlaylistButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addToPlaylistButton.Location = new System.Drawing.Point(187, 462);
            this.addToPlaylistButton.Name = "addToPlaylistButton";
            this.addToPlaylistButton.Padding = new System.Windows.Forms.Padding(2);
            this.addToPlaylistButton.Size = new System.Drawing.Size(30, 30);
            this.addToPlaylistButton.TabIndex = 11;
            this.addToPlaylistButton.TabStop = false;
            this.GelPlayerToolTip.SetToolTip(this.addToPlaylistButton, "Add Current Item To Playlist");
            // 
            // playlistsButton
            // 
            this.playlistsButton.BackColor = System.Drawing.Color.Transparent;
            this.playlistsButton.BackgroundImage = global::Player.Properties.Resources.img_playlist;
            this.playlistsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.playlistsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.playlistsButton.Location = new System.Drawing.Point(151, 462);
            this.playlistsButton.Name = "playlistsButton";
            this.playlistsButton.Padding = new System.Windows.Forms.Padding(2);
            this.playlistsButton.Size = new System.Drawing.Size(30, 30);
            this.playlistsButton.TabIndex = 10;
            this.playlistsButton.TabStop = false;
            this.GelPlayerToolTip.SetToolTip(this.playlistsButton, "View Playlists");
            // 
            // favoritesButton
            // 
            this.favoritesButton.BackColor = System.Drawing.Color.Transparent;
            this.favoritesButton.BackgroundImage = global::Player.Properties.Resources.star;
            this.favoritesButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.favoritesButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.favoritesButton.Location = new System.Drawing.Point(113, 462);
            this.favoritesButton.Name = "favoritesButton";
            this.favoritesButton.Padding = new System.Windows.Forms.Padding(2);
            this.favoritesButton.Size = new System.Drawing.Size(30, 30);
            this.favoritesButton.TabIndex = 9;
            this.favoritesButton.TabStop = false;
            this.GelPlayerToolTip.SetToolTip(this.favoritesButton, "Favorites");
            this.favoritesButton.Click += new System.EventHandler(this.favoritesButton_Click);
            // 
            // aboutPlaybackButton
            // 
            this.aboutPlaybackButton.BackColor = System.Drawing.Color.Transparent;
            this.aboutPlaybackButton.BackgroundImage = global::Player.Properties.Resources.img_about;
            this.aboutPlaybackButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.aboutPlaybackButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.aboutPlaybackButton.Enabled = false;
            this.aboutPlaybackButton.Location = new System.Drawing.Point(75, 462);
            this.aboutPlaybackButton.Name = "aboutPlaybackButton";
            this.aboutPlaybackButton.Padding = new System.Windows.Forms.Padding(2);
            this.aboutPlaybackButton.Size = new System.Drawing.Size(30, 30);
            this.aboutPlaybackButton.TabIndex = 8;
            this.aboutPlaybackButton.TabStop = false;
            this.GelPlayerToolTip.SetToolTip(this.aboutPlaybackButton, "Playback Info");
            this.aboutPlaybackButton.Click += new System.EventHandler(this.aboutPlaybackButton_Click);
            // 
            // addFilesButton
            // 
            this.addFilesButton.BackColor = System.Drawing.Color.Transparent;
            this.addFilesButton.BackgroundImage = global::Player.Properties.Resources.img_folder;
            this.addFilesButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addFilesButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addFilesButton.Location = new System.Drawing.Point(3, 462);
            this.addFilesButton.Name = "addFilesButton";
            this.addFilesButton.Padding = new System.Windows.Forms.Padding(2);
            this.addFilesButton.Size = new System.Drawing.Size(30, 30);
            this.addFilesButton.TabIndex = 7;
            this.addFilesButton.TabStop = false;
            this.GelPlayerToolTip.SetToolTip(this.addFilesButton, "Replace Playlist Files");
            this.addFilesButton.Click += new System.EventHandler(this.addFilesButton_Click);
            // 
            // clearPlaylist
            // 
            this.clearPlaylist.BackColor = System.Drawing.Color.Transparent;
            this.clearPlaylist.BackgroundImage = global::Player.Properties.Resources.delete;
            this.clearPlaylist.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.clearPlaylist.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearPlaylist.Location = new System.Drawing.Point(39, 462);
            this.clearPlaylist.Name = "clearPlaylist";
            this.clearPlaylist.Padding = new System.Windows.Forms.Padding(2);
            this.clearPlaylist.Size = new System.Drawing.Size(30, 30);
            this.clearPlaylist.TabIndex = 6;
            this.clearPlaylist.TabStop = false;
            this.GelPlayerToolTip.SetToolTip(this.clearPlaylist, "Clear Playlist");
            this.clearPlaylist.Click += new System.EventHandler(this.clearPlaylist_Click);
            // 
            // Playlist
            // 
            this.Playlist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(45)))));
            this.Playlist.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Playlist.Dock = System.Windows.Forms.DockStyle.Top;
            this.Playlist.ForeColor = System.Drawing.Color.AliceBlue;
            this.Playlist.FormattingEnabled = true;
            this.Playlist.ItemHeight = 28;
            this.Playlist.Location = new System.Drawing.Point(0, 0);
            this.Playlist.Margin = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.Playlist.Name = "Playlist";
            this.Playlist.Size = new System.Drawing.Size(346, 448);
            this.Playlist.TabIndex = 0;
            this.Playlist.SelectedIndexChanged += new System.EventHandler(this.Playlist_SelectedIndexChanged);
            this.Playlist.SelectedValueChanged += new System.EventHandler(this.Playlist_SelectedValueChanged);
            // 
            // playbackPanel
            // 
            this.playbackPanel.Controls.Add(this.mediaPlayer);
            this.playbackPanel.Controls.Add(this.splashImage);
            this.playbackPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.playbackPanel.Location = new System.Drawing.Point(3, 3);
            this.playbackPanel.Name = "playbackPanel";
            this.playbackPanel.Size = new System.Drawing.Size(537, 499);
            this.playbackPanel.TabIndex = 2;
            // 
            // mediaPlayer
            // 
            this.mediaPlayer.AllowDrop = true;
            this.mediaPlayer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.mediaPlayer.Enabled = true;
            this.mediaPlayer.Location = new System.Drawing.Point(0, 1);
            this.mediaPlayer.Margin = new System.Windows.Forms.Padding(0);
            this.mediaPlayer.Name = "mediaPlayer";
            this.mediaPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("mediaPlayer.OcxState")));
            this.mediaPlayer.Size = new System.Drawing.Size(537, 498);
            this.mediaPlayer.TabIndex = 1;
            this.mediaPlayer.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.mediaPlayer_PlayStateChange);
            // 
            // splashImage
            // 
            this.splashImage.BackgroundImage = global::Player.Properties.Resources.GelPlayer_SplashImage;
            this.splashImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.splashImage.Location = new System.Drawing.Point(-3, 23);
            this.splashImage.Name = "splashImage";
            this.splashImage.Size = new System.Drawing.Size(537, 425);
            this.splashImage.TabIndex = 0;
            this.splashImage.TabStop = false;
            this.splashImage.Visible = false;
            // 
            // OpenFileDialogue
            // 
            this.OpenFileDialogue.FileName = "Music and Videos";
            this.OpenFileDialogue.InitialDirectory = "Music";
            this.OpenFileDialogue.Multiselect = true;
            this.OpenFileDialogue.RestoreDirectory = true;
            // 
            // TitleBar
            // 
            this.TitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(51)))), ((int)(((byte)(100)))));
            this.TitleBar.Controls.Add(this.closeButton);
            this.TitleBar.Controls.Add(this.AppTitle);
            this.TitleBar.Controls.Add(this.pinWindow);
            this.TitleBar.Controls.Add(this.playbackTitlePanel);
            this.TitleBar.Controls.Add(this.openMenu);
            this.TitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.TitleBar.Location = new System.Drawing.Point(0, 0);
            this.TitleBar.Name = "TitleBar";
            this.TitleBar.Size = new System.Drawing.Size(895, 43);
            this.TitleBar.TabIndex = 1;
            // 
            // AppTitle
            // 
            this.AppTitle.AutoSize = true;
            this.AppTitle.Cursor = System.Windows.Forms.Cursors.NoMove2D;
            this.AppTitle.Font = new System.Drawing.Font("Quicksand", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AppTitle.ForeColor = System.Drawing.Color.AliceBlue;
            this.AppTitle.Location = new System.Drawing.Point(47, 7);
            this.AppTitle.Name = "AppTitle";
            this.AppTitle.Size = new System.Drawing.Size(107, 30);
            this.AppTitle.TabIndex = 9;
            this.AppTitle.Text = "GelPlayer";
            this.AppTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TitleBar_MouseDown);
            this.AppTitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TitleBar_MouseMove);
            this.AppTitle.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TitleBar_MouseUp);
            // 
            // pinWindow
            // 
            this.pinWindow.BackColor = System.Drawing.Color.Transparent;
            this.pinWindow.BackgroundImage = global::Player.Properties.Resources.pin;
            this.pinWindow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pinWindow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pinWindow.Location = new System.Drawing.Point(824, 9);
            this.pinWindow.Name = "pinWindow";
            this.pinWindow.Padding = new System.Windows.Forms.Padding(2);
            this.pinWindow.Size = new System.Drawing.Size(25, 25);
            this.pinWindow.TabIndex = 8;
            this.pinWindow.TabStop = false;
            this.GelPlayerToolTip.SetToolTip(this.pinWindow, "Pin App to Top");
            this.pinWindow.Click += new System.EventHandler(this.pinWindow_Click);
            // 
            // playbackTitlePanel
            // 
            this.playbackTitlePanel.AllowDrop = true;
            this.playbackTitlePanel.BackColor = System.Drawing.Color.Transparent;
            this.playbackTitlePanel.Controls.Add(this.playbackTitle);
            this.playbackTitlePanel.Location = new System.Drawing.Point(163, 3);
            this.playbackTitlePanel.Name = "playbackTitlePanel";
            this.playbackTitlePanel.Size = new System.Drawing.Size(309, 39);
            this.playbackTitlePanel.TabIndex = 7;
            this.GelPlayerToolTip.SetToolTip(this.playbackTitlePanel, "Playback Title");
            // 
            // playbackTitle
            // 
            this.playbackTitle.AutoEllipsis = true;
            this.playbackTitle.AutoSize = true;
            this.playbackTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playbackTitle.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playbackTitle.ForeColor = System.Drawing.Color.AliceBlue;
            this.playbackTitle.Location = new System.Drawing.Point(3, 7);
            this.playbackTitle.Name = "playbackTitle";
            this.playbackTitle.Size = new System.Drawing.Size(191, 24);
            this.playbackTitle.TabIndex = 6;
            this.playbackTitle.Text = "GelPlayer Playback Title";
            // 
            // openMenu
            // 
            this.openMenu.BackgroundImage = global::Player.Properties.Resources.logo;
            this.openMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.openMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.openMenu.Location = new System.Drawing.Point(6, 7);
            this.openMenu.Name = "openMenu";
            this.openMenu.Padding = new System.Windows.Forms.Padding(2);
            this.openMenu.Size = new System.Drawing.Size(35, 30);
            this.openMenu.TabIndex = 3;
            this.openMenu.TabStop = false;
            this.GelPlayerToolTip.SetToolTip(this.openMenu, "Open /Close Playlist");
            this.openMenu.Click += new System.EventHandler(this.openMenu_Click);
            // 
            // GelPlayerToolTip
            // 
            this.GelPlayerToolTip.AutoPopDelay = 5000;
            this.GelPlayerToolTip.InitialDelay = 500;
            this.GelPlayerToolTip.ReshowDelay = 100;
            // 
            // closeButton
            // 
            this.closeButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Font = new System.Drawing.Font("Quicksand", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.ForeColor = System.Drawing.Color.Coral;
            this.closeButton.Location = new System.Drawing.Point(855, 0);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(40, 43);
            this.closeButton.TabIndex = 10;
            this.closeButton.Text = "X";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // buttonBrowser
            // 
            this.buttonBrowser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBrowser.FlatAppearance.BorderSize = 0;
            this.buttonBrowser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBrowser.Image = global::Player.Properties.Resources.img_folder;
            this.buttonBrowser.Location = new System.Drawing.Point(259, 460);
            this.buttonBrowser.Name = "buttonBrowser";
            this.buttonBrowser.Size = new System.Drawing.Size(44, 30);
            this.buttonBrowser.TabIndex = 13;
            this.GelPlayerToolTip.SetToolTip(this.buttonBrowser, "Browser");
            this.buttonBrowser.UseVisualStyleBackColor = true;
            this.buttonBrowser.Click += new System.EventHandler(this.buttonBrowser_Click);
            // 
            // PlayerWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(895, 547);
            this.Controls.Add(this.TitleBar);
            this.Controls.Add(this.layoutPanel);
            this.Font = new System.Drawing.Font("Quicksand", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "PlayerWindow";
            this.Text = "GelPlayer";
            this.Load += new System.EventHandler(this.PlayerWindow_Load);
            this.DoubleClick += new System.EventHandler(this.Player_DoubleClick);
            this.layoutPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.shuffleBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addToPlaylistButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playlistsButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.favoritesButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aboutPlaybackButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addFilesButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clearPlaylist)).EndInit();
            this.playbackPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mediaPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splashImage)).EndInit();
            this.TitleBar.ResumeLayout(false);
            this.TitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pinWindow)).EndInit();
            this.playbackTitlePanel.ResumeLayout(false);
            this.playbackTitlePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.openMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel layoutPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox Playlist;
        private System.Windows.Forms.OpenFileDialog OpenFileDialogue;
        private System.Windows.Forms.PictureBox openMenu;
        private System.Windows.Forms.Panel TitleBar;
        private System.Windows.Forms.PictureBox clearPlaylist;
        private System.Windows.Forms.PictureBox addFilesButton;
        private System.Windows.Forms.Panel playbackTitlePanel;
        private System.Windows.Forms.Label playbackTitle;
        private System.Windows.Forms.PictureBox pinWindow;
        private System.Windows.Forms.ToolTip GelPlayerToolTip;
        private System.Windows.Forms.PictureBox aboutPlaybackButton;
        private System.Windows.Forms.Panel playbackPanel;
        private System.Windows.Forms.PictureBox splashImage;
        private AxWMPLib.AxWindowsMediaPlayer mediaPlayer;
        private System.Windows.Forms.Label AppTitle;
        private System.Windows.Forms.PictureBox favoritesButton;
        private System.Windows.Forms.PictureBox playlistsButton;
        private System.Windows.Forms.PictureBox addToPlaylistButton;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.PictureBox shuffleBtn;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button buttonBrowser;
        private System.Windows.Forms.FolderBrowserDialog browserDialogue;
    }
}

