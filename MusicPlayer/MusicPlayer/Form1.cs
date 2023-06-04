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


        }
        int lastVolume;
        string[] paths, files;
        List<string> playlist = new List<string>();



        bool sound = true;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbxPlaylist.SelectedIndex > -1)
            {
                player.URL = playlist[lbxPlaylist.SelectedIndex];
                //player.controls.play();
            }

        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = true;
            ofd.Filter = "MP3| *.mp3";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                files = ofd.FileNames;
                paths = ofd.FileNames;
                for (int x = 0; x < files.Length; x++)
                {
                    lbxPlaylist.Items.Add(Path.GetFileName(files[x]));
                    playlist.Add(paths[x]);
                }


            }
        }

        private void BtnPlay_Click(object sender, EventArgs e)
        {
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

        private void BtnNext_Click(object sender, EventArgs e)
        {
            if (lbxPlaylist.SelectedIndex < lbxPlaylist.Items.Count - 1)
            {
                lbxPlaylist.SelectedIndex = lbxPlaylist.SelectedIndex + 1;
            }
        }

        private void BtnPrev_Click(object sender, EventArgs e)
        {
            if (lbxPlaylist.SelectedIndex > 0)
            {
                lbxPlaylist.SelectedIndex = lbxPlaylist.SelectedIndex - 1;
            }
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

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if(lbxPlaylist.SelectedIndex>-1)
            {
                int toDelete = lbxPlaylist.SelectedIndex;
                lbxPlaylist.Items.RemoveAt(toDelete);
                playlist.RemoveAt(toDelete);

            }
        }
    }
}
