using DevExpress.Utils.Svg;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Utilitarios
{
    public class Imagem
    {
        public static byte[] ImageToByte(Image imageIn)
        {
            if (imageIn != null)
            {
                MemoryStream ms = new MemoryStream();
                imageIn.Save(ms, ImageFormat.Gif);
                //ms.SetLength(4000);
                return ms.ToArray();
            }
            return null;
        }
        public static byte[] ImageToByte(SvgImage imageIn)
        {
            if (imageIn != null)
            {
                MemoryStream ms = new MemoryStream();
                imageIn.Save(ms);
                return ms.ToArray();
            }
            return null;
        }

        public static Image ByteToImage(byte[] byteArrayIn)
        {
            Image returnImage = null;
            try
            {
                MemoryStream ms = new MemoryStream(byteArrayIn);
                returnImage = Image.FromStream(ms);
                return returnImage;

            }
            catch (Exception)
            {
                return returnImage;
            }
        }

        public static SvgImage ByteToSvgImage(byte[] byteArrayIn)
        {
            SvgImage returnImage = null;
            try
            {
                MemoryStream ms = new MemoryStream(byteArrayIn);
                returnImage = SvgImage.FromStream(ms);
                return returnImage;

            }
            catch (Exception)
            {
                return returnImage;
            }
        }

        public static void InserirImagem(PictureEdit picImage, byte[] imagem)
        {
            if (!Util.ObjectoNulo(imagem))
            {
                picImage.Image = ByteToImage(imagem);
                if (Util.ObjectoNulo(picImage.Image))
                {
                    picImage.SvgImage = ByteToSvgImage(imagem);
                }
            }
        }
        public static Image RedimensionarImagem(Image image, int width, int height)
        {
            var destinationRect = new Rectangle(0, 0, width, height);
            var destinationImage = new Bitmap(width, height);

            destinationImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(destinationImage))
            {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;

                using (var wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destinationRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }

            return (Image)destinationImage;
        }
    }
}
