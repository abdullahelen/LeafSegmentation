using Accord.Math;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using ZedGraph;

namespace PetioleBorder.Methods
{
    public class Marker
    {
        public TextObj Label { get; }
        public Location Point { get; }
        public PointPairList Line { get; }

        public Marker(string text, Location point, Size imgSize, bool isYaxis)
        {
            Point = point;

            // Adjust label position by image size.
            var posLabel = AdjustLabelPosition(isYaxis, point, imgSize);

            double x = posLabel.X, y = posLabel.Y;

            Label = new TextObj(text, x, y < 0 ? 0 : y, CoordType.AxisXYScale)
            {
                FontSpec = new FontSpec("Arial", 14, Color.Blue, false, false, false),
                IsClippedToChartRect = true
            };

            Line = new PointPairList()
            {
                { Label.Location.X1, Label.Location.Y1 },
                { point.X, point.Y }
            };
        }

        private Accord.Point AdjustLabelPosition(bool isYaxis, Location point, Size imgSize)
        {
            double x, y;

            if (isYaxis)
            {
                if (point.X > imgSize.Height / 2.0)
                {
                    x = point.X - (imgSize.Height - point.X) / 2.0;

                    x = x > imgSize.Height ? imgSize.Height : x;
                }
                else
                {
                    x = point.X + (imgSize.Height - point.X) / 2.0;

                    x = x < 0 ? 0 : x;
                }

                y = point.Y + (imgSize.Width - point.Y) / 2.0;
            }
            else
            {
                if (point.X > imgSize.Width / 2.0)
                {
                    x = point.X - (imgSize.Width - point.X) / 2.0;

                    x = x > imgSize.Width ? imgSize.Width : x;
                }
                else
                {
                    x = point.X + (imgSize.Width - point.X) / 2.0;

                    x = x < 0 ? 0 : x;
                }


                y = point.Y + (imgSize.Height - point.Y) / 2.0;
            }

            return
                new Accord.Point((float)x, (float)y);
        }
    }

    public class ImageProcessing
    {
        /// <summary>
        ///    Get image histogram.
        /// </summary>
        /// <param name="bmp"></param>
        /// <returns></returns>
        public unsafe static double[] HistogramX(Bitmap bmp)
        {
            var result = new double[bmp.Width];

            var bmpData = bmp.LockBits(
                new Rectangle(0, 0, bmp.Width, bmp.Height),
                ImageLockMode.ReadWrite, bmp.PixelFormat);

            try
            {
                var ptr = (byte*)bmpData.Scan0;

                for (int i = 0; i < bmpData.Height; i++)
                {
                    for (int j = 0; j < bmpData.Width; j++)
                    {
                        if (*ptr != 0) result[j]++;

                        ptr++;
                    }

                    ptr += bmpData.Stride - bmpData.Width;
                }

                return
                    result;
            }
            finally
            {
                bmp.UnlockBits(bmpData);
            }
        }

        public unsafe static double[] HistogramY(Bitmap bmp)
        {
            var result = new double[bmp.Height];

            var bmpData = bmp.LockBits(
                new Rectangle(0, 0, bmp.Width, bmp.Height),
                ImageLockMode.ReadWrite, bmp.PixelFormat);

            try
            {
                var ptr = (byte*)bmpData.Scan0;

                for (int i = 0; i < bmpData.Height; i++)
                {
                    for (int j = 0; j < bmpData.Width; j++)
                    {
                        if (*ptr != 0) result[i]++;

                        ptr++;
                    }

                    ptr += bmpData.Stride - bmpData.Width;
                }

                return
                    result;
            }
            finally
            {
                bmp.UnlockBits(bmpData);
            }
        }

        /// <summary>
        ///    Triangle (Zack's) method.
        /// </summary>
        /// <param name="dataHistogram"></param>
        /// <returns></returns>
        public int Zack(double[] dataHistogram)
        {
            int minLeft = 0, minRight = 0;

            var histLen = dataHistogram.Length;

            // Find the minimum from the left.
            for (int i = 0; i < histLen; i++)
            {
                if (dataHistogram[i] > 0)
                {
                    minLeft = i;
                    break;
                }
            }

            if (minLeft > 0) minLeft--;

            // Find the minimum from the right.
            for (int i = histLen - 1; i > 0; i--)
            {
                if (dataHistogram[i] > 0)
                {
                    minRight = i;
                    break;
                }
            }

            if (minRight < histLen - 1) minRight++;

            // Find max.
            var dmax = dataHistogram.Max();
            int maxIndx = dataHistogram.IndexOf(dmax);

            // Is the graph inverted?
            // That is, is the minimum point to the right of the maximum point?
            var inverted = false;

            if ((maxIndx - minLeft) < (minRight - maxIndx))
            {
                inverted = true;

                int left = 0;
                int right = histLen - 1;

                while (left < right)
                {
                    (dataHistogram[right], dataHistogram[left]) =
                        (dataHistogram[left], dataHistogram[right]);

                    left++; right--;
                }

                maxIndx = histLen - (maxIndx + 1);
                minLeft = histLen - (minRight + 1);
            }

            if (minLeft == maxIndx) return minLeft;

            double nx, ny, d;

            nx = dataHistogram[maxIndx];
            ny = minLeft - maxIndx;
            d = Math.Sqrt(nx * nx + ny * ny);
            nx /= d; // Sin@
            ny /= d; // Cos@
            d = nx * minLeft + ny * dataHistogram[minLeft];

            int split = minLeft;
            double splitDistance = 0;

            for (int i = minLeft + 1; i <= maxIndx; i++)
            {
                double newDistance =
                    nx * i + ny * dataHistogram[i] - d;

                if (newDistance > splitDistance)
                {
                    split = i;
                    splitDistance = newDistance;
                }
            }

            split--;

            var result = split;

            if (inverted)
            {
                int left = 0;
                int right = histLen - 1;

                while (left < right)
                {
                    (dataHistogram[right], dataHistogram[left]) =
                        (dataHistogram[left], dataHistogram[right]);

                    left++; right--;
                }

                result = histLen - (result + 1);

                return
                    result;
            }
            else
            {
                return
                    result;
            }
        }

        public static Accord.Range GetPetioleRange(double[] dataHistogram)
        {
            var maxValue = dataHistogram.Max();
            var maxIndex = dataHistogram.IndexOf(maxValue);

            var rightPoint = 0;
            var leftPoint = dataHistogram.Length;

            // Max index to right.
            for (int i = maxIndex; i < dataHistogram.Length; i++)
            {
                if (dataHistogram[i] <= 0) break;
                if (i > rightPoint) rightPoint = i;
            }

            // Max index to left.
            for (int i = maxIndex; i > 0; i--)
            {
                if (dataHistogram[i] <= 0) break;
                if (i < leftPoint) leftPoint = i;
            }

            return
                new Accord.Range(leftPoint, rightPoint);
        }
    }
}