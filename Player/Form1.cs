using AxWMPLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace Player
{
    public partial class PlayerWindow : Form
    {
        public PlayerWindow()
        {
            InitializeComponent();
            InitialiseScrollTimer();
            StartPosition = FormStartPosition.CenterScreen;
        }

        string[] files = new string[100];
        string[] path = new string[100];
        string[] playlists;
        string[] favorites;
        bool isPlaylistOpen = true;
        bool isMoving;
        bool isWindowTopmost = false;
        bool playlistIsEmpty = true;
        bool playbackInfoVisible = false;
        bool isShuffle = false;
        public readonly int x, y;

        //TITLE SCROLLING EFFECT
        private Timer scrollTimer = new Timer();
        private int scrollSpeed = 1;

        private void InitialiseScrollTimer()
        {
            scrollTimer.Start();
            scrollTimer.Interval = 1;
            scrollTimer.Tick += ScrollTimer_Tick;
        }

        private void ScrollTimer_Tick(object sender, EventArgs e)
        {
            if(playbackTitle.Width >= playbackTitlePanel.Width)
            {
                playbackTitle.Left -= scrollSpeed;
                if(playbackTitle.Left <= playbackTitlePanel.Left)
                {
                    playbackTitle.Left += scrollSpeed;
                }
                else
                {
                    playbackTitle.Left += scrollSpeed;
                }
            }
        }


        // Generating a random Number for shuffle
        private void shuffleBtn_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int randomNumber = random.Next(0, files.Length - 1);


            if (!isShuffle)
            {
                isShuffle = true;
                shuffleBtn.BackColor = Color.PaleVioletRed;
                Playlist.SelectedIndex = randomNumber;
            }
            else
            {
                isShuffle = false;
                shuffleBtn.BackColor = Color.AliceBlue;
            }
        }



        private void Playlist_SelectedValueChanged(object sender, EventArgs e)
        {
            mediaPlayer.Visible = true;
            splashImage.Visible = false;

            if (Playlist.SelectedIndex < files.Length)
            {
                mediaPlayer.URL = path[Playlist.SelectedIndex];
                playbackTitle.Text = mediaPlayer.currentMedia.name.ToUpper();

            }
            scrollTimer.Stop();

            InitialiseScrollTimer();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            Random random = new Random();
            int randomNumber = random.Next(0, files.Length - 1);

            if (OpenFileDialogue.ShowDialog() == DialogResult.OK)
            {
                files = OpenFileDialogue.SafeFileNames;
                path = OpenFileDialogue.FileNames;


                for (int i = 0; i < files.Length; i++)
                {

                    Playlist.Items.Add(files[i]);
                    playlistIsEmpty = false;

                    if (isShuffle)
                    {
                        Playlist.SelectedIndex = randomNumber;
                    }
                    else
                    {
                        Playlist.SelectedIndex = 0;
                    }
                }

                InitialiseScrollTimer();

            }
        }

        private void openMenu_Click(object sender, EventArgs e)
        {

            if (isPlaylistOpen)
            {
                layoutPanel.ColumnCount = 1;
                isPlaylistOpen = false;
            }
            else
            {
                layoutPanel.ColumnCount = 2;
                isPlaylistOpen = true;
            }

        }


        private void Player_DoubleClick(object sender, EventArgs e)
        {
            if (isPlaylistOpen)
            {
                layoutPanel.ColumnCount = 1;
                isPlaylistOpen = false;
            }
            else
            {
                layoutPanel.ColumnCount = 2;
                isPlaylistOpen = true;
            }

        }

        private void closeButton_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }

        private void TitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            isMoving = true;
        }

        private void TitleBar_MouseUp(object sender, MouseEventArgs e)
        {
            isMoving = false;
        }

        private void clearPlaylist_Click(object sender, EventArgs e)
        {
            Playlist.Items.Clear();
        }

        private void addFilesButton_Click(object sender, EventArgs e)
        {

            Playlist.Items.Clear();

            if (OpenFileDialogue.ShowDialog() == DialogResult.OK)
            {
                files = OpenFileDialogue.SafeFileNames;
                path = OpenFileDialogue.FileNames;


                for (int i = 0; i < files.Length; i++)
                {

                    Playlist.Items.Add(files[i]);
                    Playlist.SelectedIndex = 0;

                }

            }
        }

        private void pinWindow_Click(object sender, EventArgs e)
        {
            if (!isWindowTopmost)
            {
                TopMost = true;
                isWindowTopmost = true;
                pinWindow.BackColor = Color.PaleVioletRed;
            }
            else
            {
                TopMost = false;
                isWindowTopmost = false;
                pinWindow.BackColor = Color.Transparent;
            }
        }

        private void PlayerWindow_Load(object sender, EventArgs e)
        {
            fetchFiles();
            playbackTitle.Text = "";
            if(playlistIsEmpty)
            {
                mediaPlayer.Visible = false;
                splashImage.Visible = true;
            }
            else
            {
                mediaPlayer.Visible = true;
                splashImage.Visible = false;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void aboutPlaybackButton_Click(object sender, EventArgs e)
        {
            PlaybackInfo playbackInfo = new PlaybackInfo();

            if (!playbackInfoVisible)
            {
                playbackInfo.Show();
                playbackInfoVisible = true;
            }
            else
            {
                playbackInfo.Hide();
                playbackInfoVisible = false;
            }
        }

        private void Playlist_SelectedIndexChanged(object sender, EventArgs e)
        {
            mediaPlayer.URL = path[Playlist.SelectedIndex];
            mediaPlayer.Ctlcontrols.play();
            InitialiseScrollTimer();
        }

        private void fetchFiles()
        {
            string musicFolderPath = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic);
            string[] musicFiles = Directory.GetFiles(musicFolderPath, "*.mp3, *.mp4, *.avi, *.m4a, *.wav", SearchOption.AllDirectories);

            foreach (string musicFile in musicFiles)
            {
                Playlist.Items.Add(musicFile);
            }
        }
        private void mediaPlayer_PlayStateChange(object sender, _WMPOCXEvents_PlayStateChangeEvent e)
        {

            int currentMedia = Playlist.SelectedIndex;
            Random random = new Random();
            int randomNumber = random.Next(0, files.Length - 1);

            if (mediaPlayer.playState == WMPPlayState.wmppsMediaEnded)
            {
                if (Playlist.SelectedIndex < files.Length - 1)
                {

                    if (isShuffle)
                    {
                        Playlist.SelectedIndex = randomNumber;
                    }
                    else
                    {
                        currentMedia++;
                        Playlist.SelectedIndex = currentMedia;
                        mediaPlayer.Ctlcontrols.play();
                    }
                    

                }
                else
                {
                    Playlist.SelectedIndex = 0;
                }

            }
            else if(mediaPlayer.playState == WMPPlayState.wmppsStopped)
            {
                mediaPlayer.Visible = false;
                splashImage.Visible = true;
            }
        }

        private void favoritesButton_Click(object sender, EventArgs e)
        {
           // favorites.Append(Playlist.SelectedItem);
        }

        private void layoutPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonBrowser_Click(object sender, EventArgs e)
        {
            if(browserDialogue.ShowDialog() == DialogResult.OK)
            {
                files = OpenFileDialogue.SafeFileNames;
                path = OpenFileDialogue.FileNames;


                for (int i = 0; i < files.Length; i++)
                {

                    Playlist.Items.Add(files[i]);
                    Playlist.SelectedIndex = 0;

                }
            }
        }

        private void TitleBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMoving)
            {
                SetDesktopLocation(MousePosition.X - x, MousePosition.Y - y);
            }
        }
    }
}
