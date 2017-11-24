using System.Drawing;
using System.Drawing.Imaging;

namespace Cryphoto.Helper
{
    public unsafe class FastBitmap : IBitmap
    {
        BitmapData data;
        int BytesForPixel;

        public FastBitmap(int width, int height, PixelFormat px) : this(new Bitmap(width, height,px)) { }
        public FastBitmap(Bitmap bitmap)
        {
            Bitmap = bitmap;
            data = Bitmap.LockBits(new Rectangle(0, 0, Bitmap.Width, Bitmap.Height), ImageLockMode.ReadWrite, Bitmap.PixelFormat);

            BytesForPixel = Image.GetPixelFormatSize(Bitmap.PixelFormat) / 8;
        }

        public PixelFormat PixelFormat { get { return Bitmap.PixelFormat; } }
        public int Height { get { return Bitmap.Height; } }
        public int Width { get { return Bitmap.Width; } }

        private Bitmap Bitmap { get; set; }

        public Bitmap ToBitmap()
        {
            Bitmap.UnlockBits(data);
            return Bitmap;
        }
        public void Dispose()
        {
            Bitmap.Dispose();
        }

        public Color GetPixel(int i, int j)
        {
            byte* srcPointer = getIndex(i, j);

            if (BytesForPixel == 4)
                return Color.FromArgb(
                    srcPointer[3],
                    srcPointer[2],
                    srcPointer[1],
                    srcPointer[0]);

            return Color.FromArgb(
                srcPointer[2],
                srcPointer[1],
                srcPointer[0]);
        }

        private byte* getIndex(int i, int j)
        {
            return(byte*)(data.Scan0 + (j * data.Width + i) * BytesForPixel);
        }

        public void SetPixel(int i, int j, Color color)
        {
            byte* srcPointer = getIndex(i,j);

            if (BytesForPixel == 4)
                srcPointer[3] = color.A;

            srcPointer[2] = color.R;
            srcPointer[1] = color.G;
            srcPointer[0] = color.B;
        }
    }
}
