using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ImageClient
{
    public partial class MainForm : Form
    {
        localhost.ImageService service; //proxy class for SOAP servies consumption
        HelperClass helperObject;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            service = new localhost.ImageService(); //object of proxy class
            helperObject = new HelperClass();
            this.AllowDrop = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void MainForm_DragDrop(object sender, DragEventArgs e)
        {
            int x = this.PointToClient(new Point(e.X, e.Y)).X;

            int y = this.PointToClient(new Point(e.X, e.Y)).Y;

            if (x >= sourcePictureBox.Location.X && x <= sourcePictureBox.Location.X + sourcePictureBox.Width && y >= sourcePictureBox.Location.Y && y <= sourcePictureBox.Location.Y + sourcePictureBox.Height)

            {

                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

                sourcePictureBox.Image = Image.FromFile(files[0]);

            }
        }

        private void distPictureBox_Click(object sender, EventArgs e)
        {

        }
        
        private void convertButton_Click(object sender, EventArgs e)
        {

            if (sourcePictureBox.Image != null)
            {
                //convert image to binary
                byte[] imageBytes = helperObject.convertImageToBinary(sourcePictureBox.Image);

                //Holds processed image binary data
                byte[] processedImageData;

                if (grayScaleCheckBox.Checked && flipImageCheckBox.Checked)
                {
                    //consume SOAP method using proxy object 'service'
                    processedImageData = service.toFlipAndGrayscale(imageBytes);
                    distPictureBox.Image = helperObject.convertBinaryToImage(processedImageData);
                }
                else if (grayScaleCheckBox.Checked)
                {
                    //consume SOAP method
                    processedImageData = service.toGrayScale(imageBytes);
                    distPictureBox.Image = helperObject.convertBinaryToImage(processedImageData);
                }
                else if (flipImageCheckBox.Checked)
                {
                    //consume SOAP method
                    processedImageData = service.toFlipImage(imageBytes);
                    distPictureBox.Image = helperObject.convertBinaryToImage(processedImageData);
                }
                else
                {
                    MessageBox.Show("Please choose one among available servies.");
                }

            }
            else
                MessageBox.Show("You forgot to Drop an Image.");
               
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            sourcePictureBox.Image = null;

            //Browse file functionalies 
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Images only. |*.jpg; *.jpeg; *.png; *.gif ";

            DialogResult dr = ofd.ShowDialog();
            sourcePictureBox.Image = Image.FromFile(ofd.FileName);
        }

        private void grayScaleCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
