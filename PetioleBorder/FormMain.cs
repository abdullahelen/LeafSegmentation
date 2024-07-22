using Accord.Imaging.Filters;
using Accord.Math;
using PetioleBorder.Methods;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using ZedGraph;

namespace PetioleBorder
{
    public partial class FormMain : Form
    {
        private Bitmap imgSource;
        private int imgWidth;
        private int imgHeight;
        private int imgIndexOfMaxY;

        private PointPairList xPoints;
        private PointPairList yPoints;

        private Location locationZack;
        private Location locationCmin;
        private int zackValue;

        public FormMain()
        {
            InitializeComponent();

            xPoints = new PointPairList();
            yPoints = new PointPairList();

            picOriginalLeaf.BackColor = Color.Black;
            picLamina.BackColor = Color.Black;
            picPetiole.BackColor = Color.Black;
            picProximal.BackColor = Color.Black;
            picDistal.BackColor = Color.Black;
            picResults.BackColor = Color.Black;

            
            // Get base directory.
            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;

            // To go up two levels, call Directory.GetParent twice.
            var parentDir = Directory.GetParent(baseDirectory);
            parentDir = Directory.GetParent(parentDir.FullName);
            parentDir = Directory.GetParent(parentDir.FullName);

            string initialDir = Path.Combine(parentDir.FullName, "SampleImages");
            openFileDialog.InitialDirectory = initialDir;
        }

        public void RefreshGraph(ZedGraphControl zedGraph)
        {
            zedGraph.AxisChange();
            zedGraph.Invalidate();
        }

        public void DrawGraph(ZedGraphControl zedGraph,
            PointPairList pointPairs, string gTitle, string xTitle, List<Marker> markers = null)
        {
            InitGraph(zedGraph, pointPairs, gTitle, xTitle, markers);

            RefreshGraph(zedGraph);
        }

        public void InitGraph(ZedGraphControl zedGraph,
            PointPairList pointPairs, string gTitle, string xTitle, List<Marker> markers = null)
        {
            var myPane = zedGraph.GraphPane;

            myPane.CurveList.Clear();
            myPane.GraphObjList.Clear();

            // Set the titles
            myPane.Title.Text = gTitle;
            myPane.XAxis.Title.Text = xTitle;
            myPane.YAxis.Title.Text = "Frequency";
            myPane.XAxis.IsAxisSegmentVisible = false;
            myPane.YAxis.IsAxisSegmentVisible = false;

            // Fill the background of the chart rect and pane
            myPane.Fill = new Fill(Color.WhiteSmoke);

            if (markers != null)
            {
                foreach (var marker in markers)
                {
                    myPane.GraphObjList.Add(marker.Label);
                    var curveMarker = myPane.AddCurve("", marker.Line, Color.Blue, SymbolType.None);
                    curveMarker.Line.Width = 2;
                }
            }

            // Channel-0
            var curve = myPane.AddCurve("", pointPairs, Color.Red, SymbolType.None);
            curve.Line.Width = 2;
            curve.Line.IsVisible = true;
            curve.Symbol.Border.IsVisible = false;
            curve.Symbol.Fill = new Fill(Color.Red);
        }

        public List<Bitmap> SplitLeaf(Bitmap img, int height, int maxY)
        {
            var result = new List<Bitmap>();

            // Crop leaf-blade (Lamina)
            var rectLamina = new Rectangle(0, 0, imgWidth, height);
            var leafBlade = new Crop(rectLamina)
                .Apply(img);

            picLamina.Image = leafBlade;


            // Crop petiole
            var petiole = new Crop(new Rectangle(
                0, height, imgWidth, imgHeight - height))
                .Apply(img);

            picPetiole.Image = petiole;
            result.Add(petiole);



            // Crop proximal
            // Measured from the leaf-base to the point of maximum leaf width.
            var proximal = new Crop(
                new Rectangle(0, maxY, imgWidth, height - maxY))
                .Apply(img);

            picProximal.Image = proximal;
            result.Add(proximal);



            // Crop distal
            // Measured from the point of maximum leaf width to the apex.
            var distal = new Crop(new Rectangle(0, 0, imgWidth, maxY))
                .Apply(img);

            picDistal.Image = distal;

            return
                result;
        }

        public float PetioleSegmentation(List<Bitmap> bitmaps)
        {
            var petiole = bitmaps[0];
            var proximal = bitmaps[1];

            // Petiole: cumulative pixel distribution along the x-axis.
            var dataPetiole = ImageProcessing.HistogramX(petiole);

            // Determining borders (range) in the cropped Petiole image.
            var rangePetiole = ImageProcessing.GetPetioleRange(dataPetiole);

            // Proximal: cumulative pixel distribution along the x-axis.
            var dataProximal = ImageProcessing.HistogramX(proximal);

            xPoints = new PointPairList();
            for (int i = 0; i < dataProximal.Length; i++)
                xPoints.Add(i, dataProximal[i]);

            DrawGraph(graphProximalX, xPoints,
                "Cumulative pixel distribution along the X-axis.", "Image columns");

            var maxProximal = dataProximal.Max();

            for (int i = 0; i < dataProximal.Length; i++)
            {
                if (i < rangePetiole.Min) dataProximal[i] = maxProximal;
                if (i > rangePetiole.Max) dataProximal[i] = maxProximal;
            }

            var minProximal = dataProximal.Min();
            float Cmin = proximal.Height - (float)minProximal;

            return
                Cmin;
        }

        public void StartLeafSegmentation()
        {
            var height = zackValue;
            var maxY = imgIndexOfMaxY;

            // Convert the image to grayscale format.
            var rect = new Rectangle(0, 0, imgSource.Width, imgSource.Height);
            var tmpImage = imgSource.Clone(rect, PixelFormat.Format8bppIndexed);

            // Splits leaf image.
            var imgParts = SplitLeaf(tmpImage, height, maxY);
            var petiole = imgParts[0];
            var proximal = imgParts[1];

            //PetioleSegmentation(imgParts);

            // Petiole: cumulative pixel distribution along the x-axis.
            var dataPetiole = ImageProcessing.HistogramX(petiole);

            // C:\Users\Superuser\Desktop\LeafClassification\Images\p5\Populus alba 14.png
            xPoints = new PointPairList();
            for (int i = 0; i < dataPetiole.Length; i++)
            {
                xPoints.Add(i, dataPetiole[i]);
            }

            DrawGraph(graphPetioleX, xPoints,
                "Cumulative pixel distribution along the X-axis.", "Image columns");

            // Proximal: cumulative pixel distribution along the x-axis.
            var dataProximal = ImageProcessing.HistogramX(proximal);
            var maxProximal = dataProximal.Max();

            // Determining range in the cropped Petiole image.
            // The widest range represented on the X-axis of the petiole where pixels are greater than zero.
            var rangePetiole = ImageProcessing.GetPetioleRange(dataPetiole);

            // Set the positions we are not interested in to the maximum value.
            for (int i = 0; i < dataProximal.Length; i++)
            {
                if (i < rangePetiole.Min || i > rangePetiole.Max)
                {
                    dataProximal[i] = maxProximal;
                }
            }

            // Find minimum value from proximal data (Real Cmin).
            var Cmin = (float)dataProximal.Min();
            var CminIndex = dataProximal.IndexOf(Cmin);
            // Find difference between the Cmin and height of the proximal image.
            var diffCmin = proximal.Height - Cmin;


            // Convert Cmin value to a Location for display in ZedGraph.
            locationCmin = new Location(CminIndex, Cmin, CoordType.AxisXY2Scale);

            // Convert dataProximal to a PointPairList for display in ZedGraph.
            xPoints = new PointPairList();
            for (int i = 0; i < dataProximal.Length; i++)
                xPoints.Add(i, dataProximal[i]);

            // Draw Proximal
            DrawGraph(graphProximalX, xPoints,
                "Cumulative pixel distribution along the X-axis.", "Image columns",
                new List<Marker>() {
                    new Marker("Cmin", locationCmin, picProximal.Image.Size, false)
                });

            // Draw results.
            DrawResults(tmpImage, height, diffCmin, dataProximal);
        }

        public void DrawResults(Bitmap img,
            float height, float diffCmin, double[] dataProximal)
        {
            var bmpResult = new Bitmap(img);

            using (var gSub = Graphics.FromImage(bmpResult))
            {
                var lineWidth = imgWidth / 3.0f;
                var lineThickness = Math.Max(imgHeight / 200.0f, 1.0f);

                float pX = lineWidth;
                float pY = height + lineThickness;
                float pH = pY;
                float pW = 2 * lineWidth;

                // Plotting the proposed method.
                gSub.DrawLine(new Pen(new SolidBrush(Color.Red),
                    lineThickness * 1.5f), pX, pY - diffCmin, pW, pH - diffCmin);

                // Plotting Zack's line (Topt)
                gSub.DrawLine(new Pen(new SolidBrush(Color.Yellow),
                    lineThickness), pX, pY, pW, pH);
            }

            picResults.Image = bmpResult;
        }

        private void DrawAxisX(double[] data)
        {
            xPoints = new PointPairList();

            for (int i = 0; i < data.Length; i++)
            {
                xPoints.Add(i, data[i]);
            }

            DrawGraph(graphX, xPoints,
                "Cumulative pixel distribution along the X-axis.",
                "Image columns");
        }

        private void DrawAxisY(double[] data, bool zackIsReady = false)
        {
            yPoints = new PointPairList();

            for (int i = 0; i < data.Length; i++)
            {
                yPoints.Add(i, data[i]);
            }

            if (zackIsReady)
                DrawGraph(graphY, yPoints,
                    "Cumulative pixel distribution along the Y-axis.", "Image rows",
                    new List<Marker>() { new Marker("Zack", locationZack, imgSource.Size, true) });
            else
                DrawGraph(graphY, yPoints,
                    "Cumulative pixel distribution along the Y-axis.", "Image rows");
        }



        private void btnLoadImage_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                // Load image.
                string fullFileName = openFileDialog.FileName;
                imgSource = (Bitmap)Bitmap.FromFile(fullFileName);

                labLeafName.Text = System.IO.Path
                    .GetFileNameWithoutExtension(fullFileName);

                // Save original size of the image.
                imgWidth = imgSource.Width;
                imgHeight = imgSource.Height;

                // Convert the image to 8bpp format.
                var rect = new Rectangle(0, 0, imgWidth, imgHeight);
                var tmpImage = imgSource.Clone(rect, PixelFormat.Format8bppIndexed);

                // Set Picturebox image.
                picOriginalLeaf.Image = tmpImage;

                // Get histogram data of the original image with respect to X and Y-axes.
                var dataX = ImageProcessing.HistogramX(tmpImage);
                var dataY = ImageProcessing.HistogramY(tmpImage);

                // Draw X-axis.
                DrawAxisX(dataX);

                // Apply Zack's triangle method to the Y-axis.
                zackValue = new ImageProcessing().Zack((double[])dataY.Clone());

                // Convert Zack's value to a Location for display in ZedGraph.
                locationZack = new Location(zackValue, dataY[zackValue], CoordType.AxisXY2Scale);

                // Draw Y-axis.
                DrawAxisY(dataY, true);

                // Find and save the index of maximum value on the Y-axis.
                imgIndexOfMaxY = dataY.IndexOf(dataY.Max());

                btnSegmentation.Enabled = true;
            }
            else
            {
                btnSegmentation.Enabled = false;
            }
        }

        private void btnSegmentation_Click(object sender, EventArgs e)
        {
            try
            {
                StartLeafSegmentation();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void graphX_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            new FormShowGraph("The Original Leaf Image",
                graphX.GraphPane.Clone())
                .ShowDialog();
        }

        private void graphY_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            new FormShowGraph("The Original Leaf Image",
                graphY.GraphPane.Clone())
                .ShowDialog();
        }

        private void graphProximalX_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            new FormShowGraph("The Proximal Image",
                graphProximalX.GraphPane.Clone())
                .ShowDialog();
        }

        private void graphPetioleX_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            new FormShowGraph("The Petiole Image",
                graphPetioleX.GraphPane.Clone())
                .ShowDialog();
        }

        private void picLeafSource_MouseMove(object sender, MouseEventArgs e)
        {
            statusLabelXY.Text =
                "X: " + (int)((float)e.X / picOriginalLeaf.Width * 100) +
                ", Y: " + (int)((float)e.Y / picOriginalLeaf.Height *
                (picOriginalLeaf.Height / (float)picOriginalLeaf.Width) * 100);
        }

        private void picLeafSource_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (picOriginalLeaf.Image != null)
                new FormShowImage(picOriginalLeaf.Image as Bitmap)
                    .ShowDialog();
        }

        private void picLamina_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (picLamina.Image != null)
                new FormShowImage(picLamina.Image as Bitmap, "Lamina")
                .ShowDialog();
        }

        private void picPetiole_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (picPetiole.Image != null)
                new FormShowImage(picPetiole.Image as Bitmap, "Petiole")
                .ShowDialog();
        }

        private void picProximal_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (picProximal.Image != null)
                new FormShowImage(picProximal.Image as Bitmap, "Proximal")
                .ShowDialog();
        }

        private void picDistal_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (picDistal.Image != null)
                new FormShowImage(picDistal.Image as Bitmap, "Distal")
                .ShowDialog();
        }

        private void picResults_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (picResults.Image != null)
                new FormShowImage(picResults.Image as Bitmap, "Results")
                .ShowDialog();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            new FormAboutBox().ShowDialog();
        }

        private void linkGitHub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/abdullahelen?tab=repositories");
        }
    }
}
