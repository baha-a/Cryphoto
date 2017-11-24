using System.Drawing;
using System.Drawing.Imaging;

namespace Cryphoto.Helper
{
    public class DotNetBitmap : IBitmap
    {
        public DotNetBitmap(Bitmap bitmap)
        {
            Bitmap = bitmap;
        }

        public int Height { get { return Bitmap.Height; } }
        public int Width { get { return Bitmap.Width; } }
        public PixelFormat PixelFormat { get { return Bitmap.PixelFormat; } }


        private Bitmap Bitmap { get; set; }
        public Bitmap ToBitmap()
        {
            return Bitmap;
        }

        public Color GetPixel(int i, int j)
        {
            return Bitmap.GetPixel(i, j);
        }

        public void SetPixel(int i, int j, Color color)
        {
            Bitmap.SetPixel(i, j, color);
        }

        public void Dispose()
        {
            Bitmap?.Dispose();
        }
    }
}
