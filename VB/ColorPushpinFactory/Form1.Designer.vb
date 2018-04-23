Namespace ColorPushpinFactory
    Partial Public Class Form1
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Form1))
            Me.imageLayer1 = New DevExpress.XtraMap.ImageLayer()
            Me.vectorItemsLayer1 = New DevExpress.XtraMap.VectorItemsLayer()
            Me.listSourceDataAdapter1 = New DevExpress.XtraMap.ListSourceDataAdapter()
            Me.bsPoints = New System.Windows.Forms.BindingSource(Me.components)
            Me.dataSet1 = New System.Data.DataSet()
            Me.tablePoints = New System.Data.DataTable()
            Me.dataColumn1 = New System.Data.DataColumn()
            Me.dataColumn2 = New System.Data.DataColumn()
            Me.dataColumn3 = New System.Data.DataColumn()
            Me.dataColumn4 = New System.Data.DataColumn()
            Me.dataColumn5 = New System.Data.DataColumn()
            Me.imageCollection1 = New DevExpress.Utils.ImageCollection(Me.components)
            Me.mapControl1 = New DevExpress.XtraMap.MapControl()
            Me.bingMapDataProvider1 = New DevExpress.XtraMap.BingMapDataProvider()
            DirectCast(Me.bsPoints, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.dataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.tablePoints, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.imageCollection1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.mapControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' imageTilesLayer1
            ' 
            Me.imageLayer1.DataProvider = Me.bingMapDataProvider1
            ' 
            ' vectorItemsLayer1
            ' 
            Me.vectorItemsLayer1.Data = Me.listSourceDataAdapter1
            Me.vectorItemsLayer1.HighlightedItemStyle.Font = New System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
            Me.vectorItemsLayer1.HighlightedItemStyle.TextColor = System.Drawing.Color.Red
            Me.vectorItemsLayer1.ItemStyle.Font = New System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
            Me.vectorItemsLayer1.ItemStyle.TextColor = System.Drawing.Color.Red
            Me.vectorItemsLayer1.SelectedItemStyle.Fill = System.Drawing.Color.Yellow
            Me.vectorItemsLayer1.SelectedItemStyle.Font = New System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
            Me.vectorItemsLayer1.SelectedItemStyle.TextColor = System.Drawing.Color.Red
            ' 
            ' listSourceDataAdapter1
            ' 
            Me.listSourceDataAdapter1.DataSource = Me.bsPoints
            Me.listSourceDataAdapter1.DefaultMapItemType = DevExpress.XtraMap.MapItemType.Pushpin
            Me.listSourceDataAdapter1.Mappings.Latitude = "Latitude"
            Me.listSourceDataAdapter1.Mappings.Longitude = "Longitude"
            Me.listSourceDataAdapter1.Mappings.Text = "Value"
            ' 
            ' bsPoints
            ' 
            Me.bsPoints.DataMember = "Points"
            Me.bsPoints.DataSource = Me.dataSet1
            ' 
            ' dataSet1
            ' 
            Me.dataSet1.DataSetName = "NewDataSet"
            Me.dataSet1.Tables.AddRange(New System.Data.DataTable() { Me.tablePoints})
            ' 
            ' tablePoints
            ' 
            Me.tablePoints.Columns.AddRange(New System.Data.DataColumn() { Me.dataColumn1, Me.dataColumn2, Me.dataColumn3, Me.dataColumn4, Me.dataColumn5})
            Me.tablePoints.TableName = "Points"
            ' 
            ' dataColumn1
            ' 
            Me.dataColumn1.ColumnName = "Latitude"
            Me.dataColumn1.DataType = GetType(Double)
            ' 
            ' dataColumn2
            ' 
            Me.dataColumn2.ColumnName = "Longitude"
            Me.dataColumn2.DataType = GetType(Double)
            ' 
            ' dataColumn3
            ' 
            Me.dataColumn3.ColumnName = "Value"
            ' 
            ' dataColumn4
            ' 
            Me.dataColumn4.ColumnName = "ImageIndex"
            Me.dataColumn4.DataType = GetType(Integer)
            ' 
            ' dataColumn5
            ' 
            Me.dataColumn5.ColumnName = "Color"
            Me.dataColumn5.DataType = GetType(Object)
            ' 
            ' imageCollection1
            ' 
            Me.imageCollection1.ImageStream = (DirectCast(resources.GetObject("imageCollection1.ImageStream"), DevExpress.Utils.ImageCollectionStreamer))
            Me.imageCollection1.InsertGalleryImage("apply_16x16.png", "images/actions/apply_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/apply_16x16.png"), 0)
            Me.imageCollection1.Images.SetKeyName(0, "apply_16x16.png")
            Me.imageCollection1.InsertGalleryImage("remove_16x16.png", "images/actions/remove_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/remove_16x16.png"), 1)
            Me.imageCollection1.Images.SetKeyName(1, "remove_16x16.png")
            Me.imageCollection1.InsertGalleryImage("cancel_16x16.png", "images/actions/cancel_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/cancel_16x16.png"), 2)
            Me.imageCollection1.Images.SetKeyName(2, "cancel_16x16.png")
            ' 
            ' mapControl1
            ' 
            Me.mapControl1.CenterPoint = New DevExpress.XtraMap.GeoPoint(34R, -118R)
            Me.mapControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.mapControl1.ImageList = Me.imageCollection1
            Me.mapControl1.Layers.Add(Me.imageLayer1)
            Me.mapControl1.Layers.Add(Me.vectorItemsLayer1)
            Me.mapControl1.Location = New System.Drawing.Point(0, 0)
            Me.mapControl1.Name = "mapControl1"
            Me.mapControl1.Size = New System.Drawing.Size(830, 444)
            Me.mapControl1.TabIndex = 0
            Me.mapControl1.ZoomLevel = 6R
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(830, 444)
            Me.Controls.Add(Me.mapControl1)
            Me.Name = "Form1"
            Me.Text = "Form1"
            DirectCast(Me.bsPoints, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.dataSet1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.tablePoints, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.imageCollection1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.mapControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private dataSet1 As System.Data.DataSet
        Private tablePoints As System.Data.DataTable
        Private dataColumn1 As System.Data.DataColumn
        Private dataColumn2 As System.Data.DataColumn
        Private dataColumn3 As System.Data.DataColumn
        Private imageCollection1 As DevExpress.Utils.ImageCollection
        Private dataColumn4 As System.Data.DataColumn
        Private mapControl1 As DevExpress.XtraMap.MapControl
        Private bsPoints As System.Windows.Forms.BindingSource
        Private imageLayer1 As DevExpress.XtraMap.ImageLayer
        Private vectorItemsLayer1 As DevExpress.XtraMap.VectorItemsLayer
        Private listSourceDataAdapter1 As DevExpress.XtraMap.ListSourceDataAdapter
        Private dataColumn5 As System.Data.DataColumn
        Private bingMapDataProvider1 As DevExpress.XtraMap.BingMapDataProvider
    End Class
End Namespace

