Imports Microsoft.VisualBasic
Imports System
Imports System.Data
Imports System.Configuration
Imports System.Web
Imports System.Web.Security
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Web.UI.WebControls.WebParts
Imports System.Web.UI.HtmlControls
Imports System.Collections

Partial Public Class _Default
	Inherits System.Web.UI.Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)

	End Sub
	Protected Sub grid_HtmlRowPrepared(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxGridView.ASPxGridViewTableRowEventArgs)
		If e.VisibleIndex = 0 Then
			e.Row.BackColor = System.Drawing.Color.LightGreen
		End If
	End Sub

	Protected Sub grid_CustomColumnSort(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxGridView.CustomColumnSortEventArgs)
		Dim key As Object = Session("Previous_FirstRow")

		' custom sorting 
		e.Handled = True

		If e.GetRow1Value(grid.KeyFieldName).Equals(key) Then
			e.Result = (If(e.SortOrder = DevExpress.Data.ColumnSortOrder.Ascending, -1, 1))
		ElseIf e.GetRow2Value(grid.KeyFieldName).Equals(key) Then
			e.Result = (If(e.SortOrder = DevExpress.Data.ColumnSortOrder.Ascending, 1, -1))
		Else
			e.Handled = False ' default sorting 
		End If
	End Sub

	Protected Sub grid_DataBound(ByVal sender As Object, ByVal e As EventArgs)
		' get first row key value 
		Session("Previous_FirstRow") = grid.GetRowValues(0, grid.KeyFieldName)
	End Sub
End Class
