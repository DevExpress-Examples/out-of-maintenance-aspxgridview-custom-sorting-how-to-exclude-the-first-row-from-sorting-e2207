<!-- default file list -->
*Files to look at*:

* [Default.aspx](./CS/WebSite/Default.aspx) (VB: [Default.aspx](./VB/WebSite/Default.aspx))
* [Default.aspx.cs](./CS/WebSite/Default.aspx.cs) (VB: [Default.aspx.vb](./VB/WebSite/Default.aspx.vb))
<!-- default file list end -->
# ASPxGridView - Custom sorting - how to exclude the first row from sorting


<p>This example demonstrates how to handle the <a href="http://documentation.devexpress.com/#AspNet/DevExpressWebASPxGridViewASPxGridView_CustomColumnSorttopic">ASPxGridView.CustomColumnSort</a> event to sort all rows except for the first visible row.</p>


<h3>Description</h3>

<p>The first row is obtained in the <a href="http://documentation.devexpress.com/#AspNet/DevExpressWebASPxClassesASPxDataWebControlBase_DataBoundtopic">ASPxGridView.DataBound</a> event handler. Its key is stored in a Session.<br /> The <a href="http://documentation.devexpress.com/#AspNet/DevExpressWebASPxGridViewASPxGridView_CustomColumnSorttopic">ASPxGridView.CustomColumnSort</a> event handles all custom sorting, and sorts all rows except for the first row.</p>

<br/>


