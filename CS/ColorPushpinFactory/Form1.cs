using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraMap;
using System.Drawing.Imaging;

namespace ColorPushpinFactory {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            PopulateTable(10);
            listSourceDataAdapter1.SetMapItemFactory(new PushpinFactory((Image)ColorPushpinFactory.Properties.Resources.ResourceManager.GetObject("pushpin_red"), Color.FromArgb(254, 22, 131)));
        }

        private void Form1_Load(object sender, EventArgs e) {
        }

        void PopulateTable(int pointCount) {
            GeoPoint centerPoint = (GeoPoint)mapControl1.CenterPoint;
            Random r = new Random();
            for (int i = 0; i < pointCount; i++) {
                tablePoints.Rows.Add(new Object[] { centerPoint.Latitude + ( (double)r.Next(600) - 300 )/ 100,                
                    centerPoint.Longitude + ( (double)r.Next(1000) - 500 )/ 100,
                    "P" + i,
                    r.Next(3),
                    Color.FromArgb(r.Next(255),r.Next(255),r.Next(255))
                });
            }
            tablePoints.Rows.Add(new Object[] { centerPoint.Latitude + 1, centerPoint.Longitude - 1,
                    "R",  r.Next(3),  Color.Red   });
            tablePoints.Rows.Add(new Object[] { centerPoint.Latitude + 1, centerPoint.Longitude + 1,
                    "G",  r.Next(3),  Color.Green   });
            tablePoints.Rows.Add(new Object[] { centerPoint.Latitude - 1, centerPoint.Longitude + 1,
                    "B",  r.Next(3),  Color.Blue   });
            tablePoints.Rows.Add(new Object[] { centerPoint.Latitude - 1, centerPoint.Longitude - 1,
                    "Y",  r.Next(3),  Color.Yellow   });
        }
    }

    public class PushpinFactory : IMapItemFactory {
        Image baseImage;
        Color baseColor;
        public PushpinFactory(Image baseImage, Color baseColor) {
            this.baseImage = baseImage;
            this.baseColor = baseColor;
        }
        #region IMapItemFactory Members

        public MapItem CreateMapItem(MapItemType type, object obj) {
            DataRowView rowView = (DataRowView)obj;
            Color newColor = (Color)rowView["Color"];
            Image image = (Image)baseImage.Clone();
            ImageAttributes imageAttributes = GetImageAttributes(newColor);
            
            Rectangle rect = new Rectangle(0, 0, image.Width, image.Height);
            Graphics g = Graphics.FromImage(image);
            g.DrawImage(image, rect, 0, 0, rect.Width, rect.Height, GraphicsUnit.Pixel,  imageAttributes);


            MapPushpin pushpin = new MapPushpin();
            pushpin.Image = image;
            pushpin.RenderOrigin = new MapPoint(0.5, 0.8);
            pushpin.TextOrigin = new Point(22, 14);
            return pushpin;

        }

        private ImageAttributes GetImageAttributes(Color newColor) {
            ImageAttributes imageAttributes = new ImageAttributes();
            float[][] colorMatrixElements = { 
               new float[] {(float)newColor.R / 255f + 0.5f,  (float)newColor.G / 255f + 0.5f,  (float)newColor.B / 255f + 0.5f,  0, 0},        // red scaling factor
               new float[] {0.5f, 0.5f,  0.5f,  0, 0},        // green scaling factor
               new float[] {0.5f,  0.5f,  0.5f,  0, 0},        // blue scaling factor
               new float[] {0,  0,  0,  1, 0},        // alpha scaling factor
               new float[] {-0.5f,  -0.5f,  -0.5f,  0, 1}};    // three translations

            ColorMatrix colorMatrix = new ColorMatrix(colorMatrixElements);

            imageAttributes.SetColorMatrix(
               colorMatrix,
               ColorMatrixFlag.Default,
               ColorAdjustType.Bitmap);
            return imageAttributes;
        }

        #endregion
    }
}
