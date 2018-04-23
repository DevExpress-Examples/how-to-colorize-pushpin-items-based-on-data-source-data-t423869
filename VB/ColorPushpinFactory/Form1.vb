Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraMap
Imports System.Drawing.Imaging

Namespace ColorPushpinFactory
    Partial Public Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
            PopulateTable(10)
            listSourceDataAdapter1.SetMapItemFactory(New PushpinFactory(CType(My.Resources.ResourceManager.GetObject("pushpin_red"), Image), Color.FromArgb(254, 22, 131)))
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        End Sub

        Private Sub PopulateTable(ByVal pointCount As Integer)
            Dim centerPoint As GeoPoint = CType(mapControl1.CenterPoint, GeoPoint)
            Dim r As New Random()
            For i As Integer = 0 To pointCount - 1
                tablePoints.Rows.Add(New Object() { centerPoint.Latitude + (CDbl(r.Next(600)) - 300)/ 100, centerPoint.Longitude + (CDbl(r.Next(1000)) - 500)/ 100, "P" & i, r.Next(3), Color.FromArgb(r.Next(255),r.Next(255),r.Next(255)) })
            Next i
            tablePoints.Rows.Add(New Object() { centerPoint.Latitude + 1, centerPoint.Longitude - 1, "R", r.Next(3), Color.Red })
            tablePoints.Rows.Add(New Object() { centerPoint.Latitude + 1, centerPoint.Longitude + 1, "G", r.Next(3), Color.Green })
            tablePoints.Rows.Add(New Object() { centerPoint.Latitude - 1, centerPoint.Longitude + 1, "B", r.Next(3), Color.Blue })
            tablePoints.Rows.Add(New Object() { centerPoint.Latitude - 1, centerPoint.Longitude - 1, "Y", r.Next(3), Color.Yellow })
        End Sub
    End Class

    Public Class PushpinFactory
        Implements IMapItemFactory

        Private baseImage As Image
        Private baseColor As Color
        Public Sub New(ByVal baseImage As Image, ByVal baseColor As Color)
            Me.baseImage = baseImage
            Me.baseColor = baseColor
        End Sub
#Region "IMapItemFactory Members"

        Public Function CreateMapItem(ByVal type As MapItemType, ByVal obj As Object) As MapItem Implements IMapItemFactory.CreateMapItem
            Dim rowView As DataRowView = DirectCast(obj, DataRowView)
            Dim newColor As Color = DirectCast(rowView("Color"), Color)
            Dim image As Image = DirectCast(baseImage.Clone(), Image)
            Dim imageAttributes As ImageAttributes = GetImageAttributes(newColor)

            Dim rect As New Rectangle(0, 0, image.Width, image.Height)
            Dim g As Graphics = Graphics.FromImage(image)
            g.DrawImage(image, rect, 0, 0, rect.Width, rect.Height, GraphicsUnit.Pixel, imageAttributes)


            Dim pushpin As New MapPushpin()
            pushpin.Image = image
            pushpin.RenderOrigin = New MapPoint(0.5, 0.8)
            pushpin.TextOrigin = New Point(22, 14)
            Return pushpin

        End Function

        Private Function GetImageAttributes(ByVal newColor As Color) As ImageAttributes
            Dim imageAttributes As New ImageAttributes()
            Dim colorMatrixElements()() As Single = { _
                New Single() {CSng(newColor.R) / 255F + 0.5F, CSng(newColor.G) / 255F + 0.5F, CSng(newColor.B) / 255F + 0.5F, 0, 0}, _
                New Single() {0.5F, 0.5F, 0.5F, 0, 0}, _
                New Single() {0.5F, 0.5F, 0.5F, 0, 0}, _
                New Single() {0, 0, 0, 1, 0}, _
                New Single() {-0.5F, -0.5F, -0.5F, 0, 1} _
            }

            Dim colorMatrix As New ColorMatrix(colorMatrixElements)

            imageAttributes.SetColorMatrix(colorMatrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap)
            Return imageAttributes
        End Function

        #End Region
    End Class
End Namespace
