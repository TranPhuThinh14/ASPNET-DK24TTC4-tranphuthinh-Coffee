<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Products.aspx.cs" Inherits="Coffee.Products" %>

<!DOCTYPE html>
<html>
<head runat="server">
    <title>Danh sách cà phê</title>
</head>
<body>
<form id="form1" runat="server">

    <h2>☕ DANH SÁCH CÀ PHÊ</h2>

    <asp:GridView ID="gvProducts"
        runat="server"
        AutoGenerateColumns="False"
        BorderWidth="1"
        CellPadding="5">

        <Columns>
    <asp:BoundField DataField="Name" HeaderText="Tên cà phê" />
    <asp:BoundField DataField="Price" HeaderText="Giá (VNĐ)" />
    <asp:BoundField DataField="Description" HeaderText="Mô tả" />

    <asp:TemplateField HeaderText="Chi tiết">
        <ItemTemplate>
            <a href='ProductDetail.aspx?id=<%# Eval("Id") %>'>
                Xem
            </a>
        </ItemTemplate>
    </asp:TemplateField>
</Columns>


    </asp:GridView>

    <br />
    <asp:HyperLink ID="lnkBack" runat="server" NavigateUrl="Home.aspx">
        ← Quay về trang chính
    </asp:HyperLink>

</form>
</body>
</html>
