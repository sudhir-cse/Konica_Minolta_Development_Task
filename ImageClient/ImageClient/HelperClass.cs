using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// This class privides apis for genaral operations
/// </summary>

namespace ImageClient
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
    }
}
