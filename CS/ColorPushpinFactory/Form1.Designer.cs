namespace ColorPushpinFactory {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.imageLayer1 = new DevExpress.XtraMap.ImageLayer();
            this.vectorItemsLayer1 = new DevExpress.XtraMap.VectorItemsLayer();
            this.listSourceDataAdapter1 = new DevExpress.XtraMap.ListSourceDataAdapter();
            this.bsPoints = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new System.Data.DataSet();
            this.tablePoints = new System.Data.DataTable();
            this.dataColumn1 = new System.Data.DataColumn();
            this.dataColumn2 = new System.Data.DataColumn();
            this.dataColumn3 = new System.Data.DataColumn();
            this.dataColumn4 = new System.Data.DataColumn();
            this.dataColumn5 = new System.Data.DataColumn();
            this.imageCollection1 = new DevExpress.Utils.ImageCollection(this.components);
            this.mapControl1 = new DevExpress.XtraMap.MapControl();
            this.bingMapDataProvider1 = new DevExpress.XtraMap.BingMapDataProvider();
            ((System.ComponentModel.ISupportInitialize)(this.bsPoints)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePoints)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // imageTilesLayer1
            // 
            this.imageLayer1.DataProvider = this.bingMapDataProvider1;
            // 
            // vectorItemsLayer1
            // 
            this.vectorItemsLayer1.Data = this.listSourceDataAdapter1;
            this.vectorItemsLayer1.HighlightedItemStyle.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vectorItemsLayer1.HighlightedItemStyle.TextColor = System.Drawing.Color.Red;
            this.vectorItemsLayer1.ItemStyle.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vectorItemsLayer1.ItemStyle.TextColor = System.Drawing.Color.Red;
            this.vectorItemsLayer1.SelectedItemStyle.Fill = System.Drawing.Color.Yellow;
            this.vectorItemsLayer1.SelectedItemStyle.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vectorItemsLayer1.SelectedItemStyle.TextColor = System.Drawing.Color.Red;
            // 
            // listSourceDataAdapter1
            // 
            this.listSourceDataAdapter1.DataSource = this.bsPoints;
            this.listSourceDataAdapter1.DefaultMapItemType = DevExpress.XtraMap.MapItemType.Pushpin;
            this.listSourceDataAdapter1.Mappings.Latitude = "Latitude";
            this.listSourceDataAdapter1.Mappings.Longitude = "Longitude";
            this.listSourceDataAdapter1.Mappings.Text = "Value";
            // 
            // bsPoints
            // 
            this.bsPoints.DataMember = "Points";
            this.bsPoints.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "NewDataSet";
            this.dataSet1.Tables.AddRange(new System.Data.DataTable[] {
            this.tablePoints});
            // 
            // tablePoints
            // 
            this.tablePoints.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn1,
            this.dataColumn2,
            this.dataColumn3,
            this.dataColumn4,
            this.dataColumn5});
            this.tablePoints.TableName = "Points";
            // 
            // dataColumn1
            // 
            this.dataColumn1.ColumnName = "Latitude";
            this.dataColumn1.DataType = typeof(double);
            // 
            // dataColumn2
            // 
            this.dataColumn2.ColumnName = "Longitude";
            this.dataColumn2.DataType = typeof(double);
            // 
            // dataColumn3
            // 
            this.dataColumn3.ColumnName = "Value";
            // 
            // dataColumn4
            // 
            this.dataColumn4.ColumnName = "ImageIndex";
            this.dataColumn4.DataType = typeof(int);
            // 
            // dataColumn5
            // 
            this.dataColumn5.ColumnName = "Color";
            this.dataColumn5.DataType = typeof(object);
            // 
            // imageCollection1
            // 
            this.imageCollection1.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection1.ImageStream")));
            this.imageCollection1.InsertGalleryImage("apply_16x16.png", "images/actions/apply_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/apply_16x16.png"), 0);
            this.imageCollection1.Images.SetKeyName(0, "apply_16x16.png");
            this.imageCollection1.InsertGalleryImage("remove_16x16.png", "images/actions/remove_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/remove_16x16.png"), 1);
            this.imageCollection1.Images.SetKeyName(1, "remove_16x16.png");
            this.imageCollection1.InsertGalleryImage("cancel_16x16.png", "images/actions/cancel_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/cancel_16x16.png"), 2);
            this.imageCollection1.Images.SetKeyName(2, "cancel_16x16.png");
            // 
            // mapControl1
            // 
            this.mapControl1.CenterPoint = new DevExpress.XtraMap.GeoPoint(34D, -118D);
            this.mapControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mapControl1.ImageList = this.imageCollection1;
            this.mapControl1.Layers.Add(this.imageLayer1);
            this.mapControl1.Layers.Add(this.vectorItemsLayer1);
            this.mapControl1.Location = new System.Drawing.Point(0, 0);
            this.mapControl1.Name = "mapControl1";
            this.mapControl1.Size = new System.Drawing.Size(830, 444);
            this.mapControl1.TabIndex = 0;
            this.mapControl1.ZoomLevel = 6D;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 444);
            this.Controls.Add(this.mapControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsPoints)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePoints)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Data.DataSet dataSet1;
        private System.Data.DataTable tablePoints;
        private System.Data.DataColumn dataColumn1;
        private System.Data.DataColumn dataColumn2;
        private System.Data.DataColumn dataColumn3;
        private DevExpress.Utils.ImageCollection imageCollection1;
        private System.Data.DataColumn dataColumn4;
        private DevExpress.XtraMap.MapControl mapControl1;
        private System.Windows.Forms.BindingSource bsPoints;
        private DevExpress.XtraMap.ImageLayer imageLayer1;
        private DevExpress.XtraMap.VectorItemsLayer vectorItemsLayer1;
        private DevExpress.XtraMap.ListSourceDataAdapter listSourceDataAdapter1;
        private System.Data.DataColumn dataColumn5;
        private DevExpress.XtraMap.BingMapDataProvider bingMapDataProvider1;
    }
}

