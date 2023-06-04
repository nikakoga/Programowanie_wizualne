using System.Numerics;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace MusicPlayer
{
    using System.Linq.Expressions;
    using WMPLib;
    public partial class Form1 : Form
    {
        WMPLib.WindowsMediaPlayer player = new WMPLib.WindowsMediaPlayer();
        public Form1()
        {
            InitializeComponent();
            TrbVolume.Value = 50;
            lastVolume = 50;

            player.PlayStateChange += new WMPLib._WMPOCXEvents_PlayStateChangeEventHandler(Player_PlayStateChange);
            

        }
        int lastVolume;
        int position_playing = -1;

        string[] files;
        List<string> playlist = new List<string>();

        bool sound = true;
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = true;
            ofd.Filter = "MP3| *.mp3";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                files = ofd.FileNames;
                for (int x = 0; x < files.Length; x++)
                {
                    lbxPlaylist.Items.Add(Path.GetFileName(files[x]));
                    playlist.Add(files[x]);
                }
            }
        }
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (lbxPlaylist.SelectedIndex > -1)
            {
                int toDelete = lbxPlaylist.SelectedIndex;
                DeletingFromPlaylist(toDelete);
            }
        }
        private void BtnPlay_Click(object sender, EventArgs e)
        {
            if (lbxPlaylist.SelectedIndex > -1 && lbxPlaylist.SelectedIndex!= position_playing)
            { 
                 player.URL = playlist[lbxPlaylist.SelectedIndex];
                 position_playing = lbxPlaylist.SelectedIndex;
             
            }
            player.controls.play();
        }
        private void BtnPause_Click(object sender, EventArgs e)
        {
            player.controls.pause();
        }
        private void BtnStop_Click(object sender, EventArgs e)
        {
            player.controls.stop();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (player.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                pBar.Maximum = (int)player.controls.currentItem.duration;
                pBar.Value = (int)player.controls.currentPosition;
            }
            try
            {
                LblTrackStart.Text = player.controls.currentPositionString;
                if (player.controls.currentItem != null)
                {
                    LblTrackEnd.Text = player.controls.currentItem.durationString;
                }

            }
            catch
            {

            }
            
        }
        private void TrbVolume_Scroll(object sender, EventArgs e)
        {
            player.settings.volume = TrbVolume.Value;
            lastVolume = player.settings.volume;

            LblVolume.Text = TrbVolume.Value.ToString() + "%";

        }
        private void BtnMute_Click(object sender, EventArgs e)
        {
            if (sound)
            {
                player.settings.volume = 0;
                LblVolume.Text = "0%";
                sound = false;
            }
            else
            {
                player.settings.volume = lastVolume;
                LblVolume.Text = TrbVolume.Value.ToString() + "%";
                sound = true;
            }

        }
        private void pBar_MouseDown(object sender, MouseEventArgs e)
        {
            if(player.URL!="")
            {
                player.controls.currentPosition = player.currentMedia.duration * e.X / pBar.Width;
            }
        }
        private void DeletingFromPlaylist(int toDelete)
        {
            lbxPlaylist.Items.RemoveAt(toDelete);
            playlist.RemoveAt(toDelete);

            if (toDelete == position_playing)
            {
                position_playing = -1;
                player.controls.stop();
                player.URL = null;
                LblTrackEnd.Text = null;
                pBar.Value = 0;
            }

            //if i deleted sth before currently playing
            else if (toDelete < position_playing)
            {
                position_playing -= 1;
            }
        }

        private void Player_PlayStateChange(int newState)
        {
            if ((WMPPlayState)newState == WMPPlayState.wmppsMediaEnded)
            {
                PlayNextSong();
            }
        }
        private void PlayNextSong()
        {
            if (position_playing < lbxPlaylist.Items.Count - 1)
            {
                //DeletingFromPlaylist(position_playing);
                position_playing++;
                lbxPlaylist.SelectedIndex = position_playing;
                player.URL = playlist[position_playing];
                BeginInvoke(() =>
                player.controls.play());

            }
        
            else
            {
                // no more songs in playlist
                //DeletingFromPlaylist(position_playing);
                position_playing = -1;
                player.controls.stop();
                player.URL = null;
                LblTrackEnd.Text = null;
                pBar.Value = 0;
            }
        }
    }
}

//ZAKAMARKI AMBICJI, ZDUSZONE PRZEZ NADMIAR INNYCH OBOWI¥ZKÓW
//private void BtnPrev_Click(object sender, EventArgs e)
//{
//    if (position_playing > 0)
//    {
//        lbxPlaylist.SelectedIndex = position_playing - 1;
//        player.URL = playlist[lbxPlaylist.SelectedIndex];
//        position_playing = lbxPlaylist.SelectedIndex;
//    }
//}

//private void BtnNext_Click(object sender, EventArgs e)
//{
//    if (position_playing < lbxPlaylist.Items.Count - 1)
//    {
//        lbxPlaylist.SelectedIndex = position_playing + 1;
//        player.URL = playlist[lbxPlaylist.SelectedIndex];
//        position_playing = lbxPlaylist.SelectedIndex;
//    }
//}