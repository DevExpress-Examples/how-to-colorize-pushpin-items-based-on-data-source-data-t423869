<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128576191/16.1.5%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T423869)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/ColorPushpinFactory/Form1.cs) (VB: [Form1.vb](./VB/ColorPushpinFactory/Form1.vb))
* [Program.cs](./CS/ColorPushpinFactory/Program.cs) (VB: [Program.vb](./VB/ColorPushpinFactory/Program.vb))
<!-- default file list end -->
# How to colorize Pushpin items based on data source data 


<p>A <a href="https://documentation.devexpress.com/WindowsForms/clsDevExpressXtraMapMapPushpintopic.aspx">MapPushpin</a> item is displayed by a simple image. By default, this image is loaded from the current <a href="https://documentation.devexpress.com/WindowsForms/CustomDocument2534.aspx">Skin</a>. The only way to change the pushpin color is to replace this image with a custom one using the <a href="https://documentation.devexpress.com/WindowsForms/DevExpressXtraMapMapPointer_Imagetopic.aspx">Image</a> property. This example demonstrates how to modify the color of the pushpin image using the <a href="https://msdn.microsoft.com/en-us/library/system.drawing.imaging.colormatrix(v=vs.110).aspx">ColorMatrix Class</a>. For the sake of simplicity, we prepared a clear red custom pushpin. We update and assign it to a certain item from the <a href="https://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapIMapItemFactory_CreateMapItemtopic">IMapItemFactory.CreateMapItem Method</a>.</p>

<br/>


