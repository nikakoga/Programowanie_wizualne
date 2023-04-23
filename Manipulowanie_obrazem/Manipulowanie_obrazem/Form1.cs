namespace Manipulowanie_obrazem
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
                string extension = Path.GetExtension(ofd.FileName).ToLower();

                switch (extension)
                {
                    case ".png":
                        {
                            try
                            {

                                pictureBox1.Load(path_open);

                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.ToString());
                            }
                            break;
                        }


                    case ".jpg":
                        {
                            try
                            {
                                pictureBox1.Load(path_open);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.ToString());
                            }
                            break;
                        }
                    default:
                        MessageBox.Show("Wrong file type");
                        break;

                }


            }
        }
    }
}