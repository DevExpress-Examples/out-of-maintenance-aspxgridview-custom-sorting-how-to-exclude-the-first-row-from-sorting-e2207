<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128533134/10.1.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E2207)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Default.aspx](./CS/WebSite/Default.aspx) (VB: [Default.aspx](./VB/WebSite/Default.aspx))
* [Default.aspx.cs](./CS/WebSite/Default.aspx.cs) (VB: [Default.aspx.vb](./VB/WebSite/Default.aspx.vb))
<!-- default file list end -->
# ASPxGridView - Custom sorting - how to exclude the first row from sorting
<!-- run online -->
**[[Run Online]](https://codecentral.devexpress.com/e2207/)**
<!-- run online end -->


<p>This example demonstrates how to handle the <a href="http://documentation.devexpress.com/#AspNet/DevExpressWebASPxGridViewASPxGridView_CustomColumnSorttopic">ASPxGridView.CustomColumnSort</a> event to sort all rows except for the first visible row.</p>


<h3>Description</h3>

<p>The first row is obtained in the <a href="http://documentation.devexpress.com/#AspNet/DevExpressWebASPxClassesASPxDataWebControlBase_DataBoundtopic">ASPxGridView.DataBound</a> event handler. Its key is stored in a Session.<br /> The <a href="http://documentation.devexpress.com/#AspNet/DevExpressWebASPxGridViewASPxGridView_CustomColumnSorttopic">ASPxGridView.CustomColumnSort</a> event handles all custom sorting, and sorts all rows except for the first row.</p>

<br/>


