using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;

namespace Cryphoto.Helper
{
    public interface IBitmap : IDisposable
    {
        int Height { get; }
        int Width { get; }
        PixelFormat PixelFormat { get; }

        Color GetPixel(int i, int j);
        void SetPixel(int i, int j, Color color);

        Bitmap ToBitmap();
    }
}
