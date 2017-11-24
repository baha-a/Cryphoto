using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Drawing.Imaging;

namespace Cryphoto.Helper
{
    public static class BitmapExtenison
    {
        public static Func<Bitmap, IBitmap> HowToCreateNewIBitmap = x => new FastBitmap(x);

        public static IBitmap CreateIBitmap(this Bitmap source)
        {
            return HowToCreateNewIBitmap(source);
        }
        public static IBitmap CreateIBitmap(int width, int height, PixelFormat pixelFormat)
        {
            return CreateIBitmap(new Bitmap(width, height, pixelFormat));
        }


        public static Bitmap HideIn(this Bitmap secret, Bitmap container, Action progressBar = null)
        {
            return CreateIBitmap(secret).HideIn(CreateIBitmap(container), progressBar).ToBitmap();
        }
        public static Bitmap GetHidden(this Bitmap container, Action progressBar = null)
        {
            return CreateIBitmap(container).GetHidden(progressBar).ToBitmap();
        }
        public static Bitmap GetSource(this Bitmap container, Action progressBar = null)
        {
            return CreateIBitmap(container).GetSource(progressBar).ToBitmap();
        }


        public static IBitmap HideIn(this IBitmap secret, IBitmap container, Action progressBar = null)
        {
            if (container.Width < secret.Width && container.Height < secret.Height)
                throw new Exception("Dimention Not Same");

            return doWork(secret, HideIn, container, progressBar);
        }
        public static IBitmap GetHidden(this IBitmap container, Action progressBar = null)
        {
            return doWork(GetHiddenFrom, container, progressBar);
        }
        public static IBitmap GetSource(this IBitmap container, Action progressBar = null)
        {
            return doWork(GetSourceFrom, container, progressBar);
        }


        private static IBitmap doWork(IBitmap secret, Func<byte, byte, int> filter,  IBitmap container, Action progressBar)
        {
            return doDirtyWork(container, progressBar, (i, j) => secret.GetPixel(i, j).FilterBy(filter, container.GetPixel(i, j)));
        }

        private static IBitmap doWork(Func<byte, int> filter, IBitmap container, Action progressBar)
        {
            return doDirtyWork(container, progressBar, (i, j) => container.GetPixel(i, j).FilterBy(filter));
        }

        private static IBitmap doDirtyWork(IBitmap container, Action progressBar, Func<int, int, Color> predicate)
        {
            IBitmap result = CreateIBitmap(container.Width, container.Height, container.PixelFormat);

            for (int i = 0; i < container.Width; i++)
                for (int j = 0; j < container.Height; j++)
                {
                    if (progressBar != null)
                        progressBar();

                    result.SetPixel(i, j, predicate(i, j));
                }

            return result;
        }

        private static Color FilterBy(this Color color, Func<byte, int> filter)
        {
            return Color.FromArgb(filter(color.R), filter(color.G), filter(color.B));
        }
        private static Color FilterBy(this Color secret, Func<byte,byte, int> filter, Color container)
        {
            return Color.FromArgb(filter(secret.R,container.R), filter(secret.G, container.G), filter(secret.B,container.B));
        }
        private static int HideIn(this byte x, byte y)
        {
            return y.GetSourceFrom() | (x >> 6);
        }
        private static int GetHiddenFrom(this byte x)
        {
            // x & 3  ---> remove all bits exept least two bits
            // x * 60 ---> make image Lighter
            return (x & 3) * 60;
        }
        private static int GetSourceFrom(this byte x)
        {
            return x & -4;
        }
    }
}
