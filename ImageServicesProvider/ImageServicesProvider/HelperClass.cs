using System.Drawing;
using System.IO;

// <summary>
/// This class privides general purpose APIs
/// </summary>
namespace ImageServicesProvider
{
    class HelperClass
    {

        //converts binary data (of image) to Image
        public Image convertBinaryToImage(byte[] data)
        {
            using (MemoryStream ms = new MemoryStream(data))
            {
                return Image.FromStream(ms);
            }
        }

        //Converts Image to binary image data
        public byte[] convertImageToBinary(Image image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                return ms.ToArray();
            }
        }

        //Convert an image to grayscale
        public Bitmap toGrayScale(Bitmap image)
        {

            Color p;
            // Process the pixels.
            for (int y = 0; y < image.Height; y++)
            {
                for (int x = 0; x < image.Width; x++)
                {
                    //get pixel value
                    p = image.GetPixel(x, y);

                    //extract pixel component ARGP
                    int a = p.A;
                    int r = p.R;
                    int g = p.G;
                    int b = p.B;

                    //find average
                    int avg = (r + g + b) / 3;

                    //set new pixel value
                    image.SetPixel(x, y, Color.FromArgb(a, avg, avg, avg));

                }
            }

            // Unlock the bitmap.
            return image;
        }

        //Rotate an image
        public Image rotateImage(Image image)
        {
            var bmp = new Bitmap(image);

            using (Graphics gfx = Graphics.FromImage(bmp))
            {
                gfx.Clear(Color.White);
                gfx.DrawImage(image, 0, 0, image.Width, image.Height);
            }

            bmp.RotateFlip(RotateFlipType.RotateNoneFlipX);
            return bmp;
        }

    }
}