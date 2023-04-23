namespace Edycja_picturebox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LoadPictureButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string path_open = ofd.FileName;

                try
                {
                    pictureBox1.Load(path_open);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }

        }
    }
}