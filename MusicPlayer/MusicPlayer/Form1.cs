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

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "MP3| *.mp3";


            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string path_open = ofd.FileName;
                string filename = Path.GetFileName(path_open);
                lbxPlaylist.Items.Insert(0, filename);
                player.URL = path_open;
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
    }
}