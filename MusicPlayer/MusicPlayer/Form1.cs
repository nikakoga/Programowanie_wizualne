namespace MusicPlayer
{
    using WMPLib;
    public partial class Form1 : Form
    {
        WMPLib.WindowsMediaPlayer plzyer = new WMPLib.WindowsMediaPlayer();
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

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "MP3| *.mp3";


            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string path_open = ofd.FileName;
                string extension = Path.GetExtension(ofd.FileName).ToLower();
            }
        }
    }
}