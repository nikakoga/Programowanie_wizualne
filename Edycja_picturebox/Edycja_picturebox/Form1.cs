using System.Drawing;
using System.Windows.Forms;

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

        private void TurnButton_Click(object sender, EventArgs e)
        {
            Bitmap bmp = (Bitmap)pictureBox1.Image;
            if (bmp != null)
            {
                bmp.RotateFlip(RotateFlipType.Rotate90FlipXY);
                pictureBox1.Image = bmp;
            }

        }

        private void VerticalMirrorButton_Click(object sender, EventArgs e)
        {
            Bitmap bmp = (Bitmap)pictureBox1.Image;
            if (bmp != null)
            {
                bmp.RotateFlip(RotateFlipType.Rotate180FlipY);
                pictureBox1.Image = bmp;
            }
        }

        private void HorizontalMirrorButton_Click(object sender, EventArgs e)
        {
            Bitmap bmp = (Bitmap)pictureBox1.Image;
            if (bmp != null)
            {
                bmp.RotateFlip(RotateFlipType.Rotate180FlipX);
                pictureBox1.Image = bmp;
            }
        }
    }
}