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
            ofd.Filter = "PNG|*.png|JPG|*.jpg;*.jpeg";

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
        private void NegativeButton_Click(object sender, EventArgs e)
        {
            Bitmap bmp = (Bitmap)pictureBox1.Image;

            if (bmp != null)
            {
                int width = bmp.Width;
                int height = bmp.Height;


                for (int y = 0; y < height; y++)
                {
                    for (int x = 0; x < width; x++)
                    {
                        //get pixel value
                        Color p = bmp.GetPixel(x, y);

                        //extract ARGB
                        int a = p.A;
                        int r = p.R;
                        int g = p.G;
                        int b = p.B;

                        //convert to negative
                        r = 255 - r;
                        g = 255 - g;
                        b = 255 - b;

                        //set new ARGB for pixel
                        bmp.SetPixel(x, y, Color.FromArgb(a, r, g, b));
                    }
                }

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
        
        private void OnlyGreenButton_Click(object sender, EventArgs e)
        {
            Bitmap bmp = (Bitmap)pictureBox1.Image;
            
            if (bmp != null)
            {
                Graphics graphics = Graphics.FromImage(bmp);
                graphics.DrawImage(pictureBox1.Image, 0, 0);

                int width = bmp.Width;
                int height = bmp.Height;

                graphics.FillRectangle(new SolidBrush(Color.FromArgb(100, Color.Green)), 0, 0, width, height);
                pictureBox1.Image = bmp;
            }
        }            
    }
}