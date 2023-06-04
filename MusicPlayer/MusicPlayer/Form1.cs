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
            //player.URL = string.Empty;

        }
        string[] paths, files, playlist;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            player.URL = paths[lbxPlaylist.SelectedIndex];
            player.controls.play();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = true;
            ofd.Filter = "MP3| *.mp3";


            if (ofd.ShowDialog() == DialogResult.OK)
            {
                //string path_open = ofd.FileName;
                //string filename = Path.GetFileName(path_open);
                //lbxPlaylist.Items.Insert(0, filename);
                ////player.URL = path_open;
                files = ofd.FileNames;
                paths = ofd.FileNames;
                for (int x = 0; x < files.Length; x++)
                {
                    lbxPlaylist.Items.Add(Path.GetFileName(files[x]));
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
        }
    }
}

//private void BtnPlayPlaylist_Click(object sender, EventArgs e)
//{
//    if (playlist.Count > 0)
//    {
//        currentTrackIndex = 0;
//        PlayTrack(playlist[currentTrackIndex]);
//    }
//}