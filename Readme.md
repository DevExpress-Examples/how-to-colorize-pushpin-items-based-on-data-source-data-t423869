# How to colorize Pushpin items based on data source data 


<p>A <a href="https://documentation.devexpress.com/WindowsForms/clsDevExpressXtraMapMapPushpintopic.aspx">MapPushpin</a> item is displayed by a simple image. By default, this image is loaded from the current <a href="https://documentation.devexpress.com/WindowsForms/CustomDocument2534.aspx">Skin</a>. The only way to change the pushpin color is to replace this image with a custom one using the <a href="https://documentation.devexpress.com/WindowsForms/DevExpressXtraMapMapPointer_Imagetopic.aspx">Image</a> property. This example demonstrates how to modify the color of the pushpin image using the <a href="https://msdn.microsoft.com/en-us/library/system.drawing.imaging.colormatrix(v=vs.110).aspx">ColorMatrix Class</a>. For the sake of simplicity, we prepared a clear red custom pushpin. We update and assign it to a certain item from the <a href="https://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapIMapItemFactory_CreateMapItemtopic">IMapItemFactory.CreateMapItem Method</a>.</p>

<br/>


