<%@ Page Language="vb" AutoEventWireup="true" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<%@ Register Assembly="DevExpress.Web.v15.1, Version=15.1.15.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
	Namespace="DevExpress.Web" TagPrefix="dx" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
	<title>Untitled Page</title>
</head>
<body>
	<form id="form1" runat="server">
		<div>
			<dx:ASPxGridView ID="grid" runat="server" AutoGenerateColumns="False" DataSourceID="sds"
				KeyFieldName="ProductID" OnCustomColumnSort="grid_CustomColumnSort" OnHtmlRowPrepared="grid_HtmlRowPrepared"
				OnDataBound="grid_DataBound">
				<Columns>
					<dx:GridViewDataTextColumn FieldName="ProductID" ReadOnly="True" VisibleIndex="0"
						Settings-SortMode="Custom">
						<EditFormSettings Visible="False" />
					</dx:GridViewDataTextColumn>
					<dx:GridViewDataTextColumn FieldName="ProductName" VisibleIndex="1" Settings-SortMode="Custom">
					</dx:GridViewDataTextColumn>
					<dx:GridViewDataTextColumn FieldName="SupplierID" VisibleIndex="2" Settings-SortMode="Custom">
					</dx:GridViewDataTextColumn>
					<dx:GridViewDataTextColumn FieldName="CategoryID" VisibleIndex="3" Settings-SortMode="Custom">
					</dx:GridViewDataTextColumn>
					<dx:GridViewDataTextColumn FieldName="QuantityPerUnit" VisibleIndex="4" Settings-SortMode="Custom">
					</dx:GridViewDataTextColumn>
					<dx:GridViewDataTextColumn FieldName="UnitPrice" VisibleIndex="5" Settings-SortMode="Custom">
					</dx:GridViewDataTextColumn>
				</Columns>
			</dx:ASPxGridView>
			<asp:SqlDataSource ID="sds" runat="server" ConnectionString="<%$ ConnectionStrings:NorthwindConnectionString %>"
				SelectCommand="SELECT [ProductID], [ProductName], [SupplierID], [CategoryID], [QuantityPerUnit], [UnitPrice] FROM [Products]">
			</asp:SqlDataSource>
		</div>
	</form>
</body>
</html>