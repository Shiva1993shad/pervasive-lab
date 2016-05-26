using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;

namespace azmayeshgah
{
    public class ImageHandler
    {
        public static string CompressAndResizeImage(Bitmap image, int maxWidth, int maxHeight, int quality, string imageType)
        {
            // Get the image's original width and height
            int originalWidth = image.Width;
            int originalHeight = image.Height;

            // To preserve the aspect ratio
            float ratioX = (float)maxWidth / (float)originalWidth;
            float ratioY = (float)maxHeight / (float)originalHeight;
            float ratio = Math.Min(ratioX, ratioY);

            // New width and height based on aspect ratio
            int newWidth = (int)(originalWidth * ratio);
            int newHeight = (int)(originalHeight * ratio);

            // Convert other formats (including CMYK) to RGB.
            Bitmap newImage = new Bitmap(newWidth, newHeight, PixelFormat.Format24bppRgb);

            // Draws the image in the specified size with quality mode set to HighQuality
            using (Graphics graphics = Graphics.FromImage(newImage))
            {
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.DrawImage(image, 0, 0, newWidth, newHeight);
            }

            // Get an ImageCodecInfo object that represents the JPEG codec.
            ImageCodecInfo imageCodecInfo = GetEncoderInfo(ImageFormat.Jpeg);

            // Create an Encoder object for the Quality parameter.
            Encoder encoder = Encoder.Quality;

            // Create an EncoderParameters object. 
            EncoderParameters encoderParameters = new EncoderParameters(1);

            // Save the image as a JPEG file with quality level.
            EncoderParameter encoderParameter = new EncoderParameter(encoder, quality);
            encoderParameters.Param[0] = encoderParameter;


            // Create Address
            string address = "";
            string folder = DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString() + "";
           if (imageType == "item")
            {
                if (!Directory.Exists(HttpContext.Current.Server.MapPath("~/") + "Picture\\" + folder))
                {
                    Directory.CreateDirectory(HttpContext.Current.Server.MapPath("~/") + "Picture\\" + folder);
                }
                address = "Picture\\" + folder + "\\" + Guid.NewGuid().ToString() + ".jpg";
            }
            /* 
            else if (imageType == "slideshow")
            {
                address = "SlideshowImages\\" + Guid.NewGuid().ToString() + ".jpg";
            }
            else if (imageType == "magazine")
            {
                if (!Directory.Exists(HttpContext.Current.Server.MapPath("~/") + "MagazineImages\\" + folder))
                {
                    Directory.CreateDirectory(HttpContext.Current.Server.MapPath("~/") + "MagazineImages\\" + folder);
                }
                address = "MagazineImages\\" + folder + "\\" + Guid.NewGuid().ToString() + ".jpg";
            }*/
            string filePath = HttpContext.Current.Server.MapPath("~/") + address;

            newImage.Save(filePath, imageCodecInfo, encoderParameters);

            return HttpContext.Current.Request.Url.GetLeftPart(UriPartial.Authority) + "/" + address.Replace("\\", "/");
        }

        //public static string CompressAndResizeImage(Bitmap image, int quality, string imageType, bool isThumbnail)
        //{
        //    var bmp = new Bitmap(image, image.Width, image.Height);

        //    // Convert other formats (including CMYK) to RGB.
        //    Bitmap NewImage = new Bitmap(image.Width, image.Height, PixelFormat.Format24bppRgb);

        //    // Draws the image in the specified size with quality mode set to HighQuality
        //    using (Graphics graphics = Graphics.FromImage(NewImage))
        //    {
        //        graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
        //        graphics.SmoothingMode = SmoothingMode.HighQuality;
        //        graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
        //        graphics.CompositingQuality = CompositingQuality.HighQuality;
        //        graphics.DrawImage(bmp, 0, 0, image.Width, image.Height);
        //    }

        //    // Get an ImageCodecInfo object that represents the JPEG codec.
        //    ImageCodecInfo imageCodecInfo = GetEncoderInfo(ImageFormat.Jpeg);

        //    // Create an Encoder object for the Quality parameter.
        //    Encoder encoder = Encoder.Quality;

        //    // Create an EncoderParameters object. 
        //    EncoderParameters encoderParameters = new EncoderParameters(1);

        //    // Save the image as a JPEG file with quality level.
        //    EncoderParameter encoderParameter = new EncoderParameter(encoder, quality);
        //    encoderParameters.Param[0] = encoderParameter;

        //    string address = "";
        //    string folder = DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString() + "";
        //    if (imageType == "item")
        //    {
        //        if (!Directory.Exists(HttpContext.Current.Server.MapPath("~/") + "ItemImages\\" + folder))
        //        {
        //            Directory.CreateDirectory(HttpContext.Current.Server.MapPath("~/") + "ItemImages\\" + folder);
        //        }
        //        address = "ItemImages\\" + folder + "\\" + Guid.NewGuid().ToString() + ".jpg";
        //    }
        //    else if (imageType == "slideshow")
        //    {
        //        address = "SlideshowImages\\" + Guid.NewGuid().ToString() + ".jpg";
        //    }
        //    else if (imageType == "magazine")
        //    {
        //        if (!Directory.Exists(HttpContext.Current.Server.MapPath("~/") + "MagazineImages\\" + folder))
        //        {
        //            Directory.CreateDirectory(HttpContext.Current.Server.MapPath("~/") + "MagazineImages\\" + folder);
        //        }
        //        address = "MagazineImages\\" + folder + "\\" + Guid.NewGuid().ToString() + ".jpg";
        //    }

        //    using (var memory = new MemoryStream())
        //    {
        //        NewImage.Save(memory, imageCodecInfo, encoderParameters);
        //        var img = Image.FromStream(memory);
        //        img.Save(HttpContext.Current.Server.MapPath("~/") + address);
        //    }
        //    return HttpContext.Current.Request.Url.GetLeftPart(UriPartial.Authority) + "/" + address.Replace("\\", "/");
        //}

        private static ImageCodecInfo GetEncoderInfo(ImageFormat format)
        {
            return ImageCodecInfo.GetImageDecoders().FirstOrDefault(c => c.FormatID == format.Guid);
        }

    }
}