using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;

namespace IH
{
    public enum IconSizeDimensions
    {
        IconSize16x16Pixels = 16,
        IconSize24x24Pixels = 24,
        IconSize32x32Pixels = 32,
        IconSize48x48Pixels = 48,
        IconSize64x64Pixels = 64,
        IconSize96x96Pixels = 96,
        IconSize128x128Pixels = 128
    }

    public static class ImageHelpers
    {
        private static byte[] pngiconheader =
                     new byte[] { 0, 0, 1, 0, 1, 0, 0, 0, 0, 0, 1, 0, 24, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

        public static Icon PngIconFromImage(Image img, int size = 16)
        {
            using (Bitmap bmp = new Bitmap(img, new Size(size, size)))
            {
                byte[] png;
                using (System.IO.MemoryStream fs = new System.IO.MemoryStream())
                {
                    bmp.Save(fs, System.Drawing.Imaging.ImageFormat.Png);
                    fs.Position = 0;
                    png = fs.ToArray();
                }

                using (System.IO.MemoryStream fs = new System.IO.MemoryStream())
                {
                    if (size >= 256) size = 0;
                    pngiconheader[6] = (byte)size;
                    pngiconheader[7] = (byte)size;
                    pngiconheader[14] = (byte)(png.Length & 255);
                    pngiconheader[15] = (byte)(png.Length / 256);
                    pngiconheader[18] = (byte)(pngiconheader.Length);

                    fs.Write(pngiconheader, 0, pngiconheader.Length);
                    fs.Write(png, 0, png.Length);
                    fs.Position = 0;
                    return new Icon(fs);
                }
            }
        }

        public static Bitmap Format32bppArgbCopy(Bitmap sourceBitmap)
        {
            Bitmap copyBitmap = new Bitmap(sourceBitmap.Width, sourceBitmap.Height, PixelFormat.Format32bppArgb);

            using (Graphics graphicsObject = Graphics.FromImage(copyBitmap))
            {
                graphicsObject.CompositingQuality = CompositingQuality.HighQuality;
                graphicsObject.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphicsObject.PixelOffsetMode = PixelOffsetMode.HighQuality;
                graphicsObject.SmoothingMode = SmoothingMode.HighQuality;

                graphicsObject.DrawImage(sourceBitmap,
                new Rectangle(0, 0, sourceBitmap.Width, sourceBitmap.Height),
                new Rectangle(0, 0, sourceBitmap.Width, sourceBitmap.Height), GraphicsUnit.Pixel);
            }

            return copyBitmap;
        }

        public static Bitmap CopyToSquareCanvas(this Bitmap sourceBitmap, Color canvasBackground)
        {
            int maxSide = sourceBitmap.Width > sourceBitmap.Height ? sourceBitmap.Width : sourceBitmap.Height;

            Bitmap bitmapResult = new Bitmap(maxSide, maxSide, PixelFormat.Format32bppArgb);

            using (Graphics graphicsResult = Graphics.FromImage(bitmapResult))
            {
                graphicsResult.Clear(canvasBackground);

                int xOffset = (sourceBitmap.Width - maxSide) / 2;
                int yOffset = (sourceBitmap.Height - maxSide) / 2;

                graphicsResult.DrawImage(sourceBitmap, new Point(xOffset, xOffset));
            }

            return bitmapResult;
        }

        public static Icon CreateIcon(Bitmap sourceBitmap, IconSizeDimensions iconSize)
        {
            Bitmap squareCanvas = sourceBitmap.CopyToSquareCanvas(Color.Transparent);
            squareCanvas = (Bitmap)squareCanvas.GetThumbnailImage((int)iconSize, (int)iconSize, null, new IntPtr());

            Icon iconResult = Icon.FromHandle(squareCanvas.GetHicon());

            return iconResult;
        }


        // resize an Image to scale
        public static Image ScaleImage(Image image, int maxWidth, int maxHeight)
        {
            var ratioX = (double)maxWidth / image.Width;
            var ratioY = (double)maxHeight / image.Height;
            var ratio = Math.Min(ratioX, ratioY);

            var newWidth = (int)(image.Width * ratio);
            var newHeight = (int)(image.Height * ratio);

            var newImage = new Bitmap(newWidth, newHeight);

            using (var graphics = Graphics.FromImage(newImage))
                graphics.DrawImage(image, 0, 0, newWidth, newHeight);

            return newImage;
        }

        // resize a bitmap
        public static Bitmap ResizeBitmap(Bitmap image, int Width, int Height)
        {
            
            double dblScaleImg = (double)Width / (double)image.Width;

            Bitmap tmpResizedImage = new Bitmap(Convert.ToInt32(dblScaleImg * image.Width), Convert.ToInt32(dblScaleImg * image.Height));

            using (Graphics tmpGraphics = Graphics.FromImage(tmpResizedImage))
            {
                tmpGraphics.CompositingQuality = CompositingQuality.HighSpeed;
                tmpGraphics.SmoothingMode = SmoothingMode.HighSpeed;
                tmpGraphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
                tmpGraphics.DrawImage(image, 0, 0, tmpResizedImage.Width + 1, tmpResizedImage.Height + 1);
            }

            return tmpResizedImage;
        }

        // convert bitmap to byte[]
        public static byte[] ConvertBitmapToBytaArray(Bitmap b)
        {
            MemoryStream ms = new MemoryStream();
            b.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
            byte[] bmpBytes = ms.GetBuffer();
            return bmpBytes;
        }

        // convert byte[] to bitmap
        public static Bitmap ConvertbyteArrayToBitmap(byte[] byteArrayIn)
        {
            var imageConverter = new ImageConverter();
            var image = (Image)imageConverter.ConvertFrom(byteArrayIn);
            return new Bitmap(image);
        }


        // convert byte array to image
        public static Image ConvertbyteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }

        // convert image to byte array
        public static byte[] ConvertImageToByteArray(System.Drawing.Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
            return ms.ToArray();
        }

        //Convert icon to byte array
        public static byte[] ConvertIconToByteArray(Icon icon)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                icon.Save(ms);
                return ms.ToArray();
            }
        }

        //Convert byte array to icon
        public static Icon ConvertByteArrayToIcon(byte[] bytes)
        {
            using (MemoryStream ms = new MemoryStream(bytes))
            {
                return new Icon(ms);
            }
        }

        // enlarge image
        public static Image EnlargeImage(Image img, int factor)
        {
            int pct = (factor * 100) / 100;

            var newW = img.Size.Width * pct;
            var newH = img.Size.Height * pct;
            return ResizeImage(img, new Size(newW, newH));
        }

        public static Image EnlargeImage(Image img, int wfactor, int hfactor)
        {
            int wpct = (wfactor * 100) / 100;
            int hpct = (hfactor * 100) / 100;

            var newW = img.Size.Width * wpct;
            var newH = img.Size.Height * hpct;
            return ResizeImage(img, new Size(newW, newH));
        }

        // reduce image
        public static Image ReduceImage(Image img, int factor)
        {
            int pct = (factor * 100) / 100;

            var newW = img.Size.Width / pct;
            var newH = img.Size.Height / pct;

            return ResizeImage(img, new Size(newW, newH));
        }

        public static Image ReduceImage(Image img, int wfactor, int hfactor)
        {
            int wpct = (wfactor * 100) / 100;
            int hpct = (hfactor * 100) / 100;

            var newW = img.Size.Width / wpct;
            var newH = img.Size.Height / hpct;

            return ResizeImage(img, new Size(newW, newH));
        }

        // resize Image
        public static Image ResizeImage(Image imgToResize, Size size)
        {
            return (Image)(new Bitmap(imgToResize, size));
        }

        /// <summary>
        /// Converts a PNG image to a icon (ico)
        /// </summary>
        /// <param name="input">The input stream</param>
        /// <param name="output">The output stream</param>
        /// <param name="size">The size (16x16 px by default)</param>
        /// <param name="preserveAspectRatio">Preserve the aspect ratio</param>
        /// <returns>Wether or not the icon was succesfully generated</returns>
        public static bool ConvertToIcon(Stream input, Stream output, int size = 16, bool preserveAspectRatio = false)
        {
            var inputBitmap = (Bitmap)Bitmap.FromStream(input);
            if (inputBitmap == null)
                return false;

            int width = size, height = size;
            if (preserveAspectRatio)
            {
                width = size;
                height = inputBitmap.Height / inputBitmap.Width * size;
            }

            var newBitmap = new Bitmap(inputBitmap, new Size(width, height));
            if (newBitmap == null)
                return false;

            // save the resized png into a memory stream for future use
            using (MemoryStream memoryStream = new MemoryStream())
            {
                newBitmap.Save(memoryStream, ImageFormat.Png);

                var iconWriter = new BinaryWriter(output);
                if (output == null || iconWriter == null)
                    return false;

                // 0-1 reserved, 0
                iconWriter.Write((byte)0);
                iconWriter.Write((byte)0);

                // 2-3 image type, 1 = icon, 2 = cursor
                iconWriter.Write((short)1);

                // 4-5 number of images
                iconWriter.Write((short)1);

                // image entry 1
                // 0 image width
                iconWriter.Write((byte)width);
                // 1 image height
                iconWriter.Write((byte)height);

                // 2 number of colors
                iconWriter.Write((byte)0);

                // 3 reserved
                iconWriter.Write((byte)0);

                // 4-5 color planes
                iconWriter.Write((short)0);

                // 6-7 bits per pixel
                iconWriter.Write((short)32);

                // 8-11 size of image data
                iconWriter.Write((int)memoryStream.Length);

                // 12-15 offset of image data
                iconWriter.Write((int)(6 + 16));

                // write image data
                // png data must contain the whole png data file
                iconWriter.Write(memoryStream.ToArray());

                iconWriter.Flush();
            }

            return true;
        }
    }
}
