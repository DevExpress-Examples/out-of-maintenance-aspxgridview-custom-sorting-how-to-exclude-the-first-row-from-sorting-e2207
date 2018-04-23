using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Collections;

public partial class _Default : System.Web.UI.Page {
    protected void Page_Load(object sender, EventArgs e) {

    }
    protected void grid_HtmlRowPrepared(object sender, DevExpress.Web.ASPxGridViewTableRowEventArgs e) {
        if (e.VisibleIndex == 0)
            e.Row.BackColor = System.Drawing.Color.LightGreen;
    }

    protected void grid_CustomColumnSort(object sender, DevExpress.Web.CustomColumnSortEventArgs e) {
        Object key = Session["Previous_FirstRow"];

       
        var key1 = e.GetRow1Value(grid.KeyFieldName);
        var key2 = e.GetRow2Value(grid.KeyFieldName);

        if(key1 == key2) {
            e.Handled = false;
            return;
        }
        /* custom sorting */
        e.Handled = true;
        if(key1.Equals(key))
            e.Result = (e.SortOrder == DevExpress.Data.ColumnSortOrder.Ascending ? -1 : 1);
        else if(key2.Equals(key))
            e.Result = (e.SortOrder == DevExpress.Data.ColumnSortOrder.Ascending ? 1 : -1);
        else
            e.Handled = false; /* default sorting */
    }
  
    protected void grid_DataBound(object sender, EventArgs e) {
        /* get first row key value */
        Session["Previous_FirstRow"] = grid.GetRowValues(0, grid.KeyFieldName);
    }
}
