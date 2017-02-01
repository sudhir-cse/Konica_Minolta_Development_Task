using System.Drawing;
using System.Web.Services;

namespace ImageServicesProvider
{
    /// <summary>
    /// Provide methods to be consumed by clients
    /// </summary>
    [WebService(Namespace = "http://localhost:49191/imageService.asmx")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]

    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line.
    // [System.Web.Script.Services.ScriptService]

    public class ImageService : System.Web.Services.WebService
    {
        /// <summary>
        /// Converts an image to grayscale
        /// </summary>
        /// <param name="data">Binary representation of an image to be processed</param>
        /// <returns>Binary data equivalents to grayscale image </returns>
        [WebMethod]
        public byte[] toGrayScale(byte[] data)
        {
            HelperClass helper = new HelperClass();

            //convert  imageBase64String to bitmap image
            Image image = helper.convertBinaryToImage(data);

            //convert to grayscale
            Bitmap grayImage = helper.toGrayScale(new Bitmap(image));

            return helper.convertImageToBinary(grayImage);
        }

        /// <summary>
        /// Rotate an image
        /// </summary>
        /// <param name="data">Binary representation of an image to be processed</param>
        /// <returns>Binary data equivalents to fliped-x image </returns>
        [WebMethod]
        public byte[] toFlipImage(byte[] data)
        {
            HelperClass helper = new HelperClass();

            //construct original and image
            Image image = helper.convertBinaryToImage(data);

            //convert to grayscale
            Image flipedImage = helper.rotateImage(image);

            return helper.convertImageToBinary(flipedImage);
        }

        /// <summary>
        /// Converts an image to grayscale and flip it to the x axis
        /// </summary>
        /// <param name="data">Binary representation of an image to be processed</param>
        /// <returns>Binary data equivalents to grayscale fliped-x image </returns>
        [WebMethod]
        public byte[] toFlipAndGrayscale(byte[] data)
        {
            return toGrayScale(toFlipImage(data));
        }

    }
}
