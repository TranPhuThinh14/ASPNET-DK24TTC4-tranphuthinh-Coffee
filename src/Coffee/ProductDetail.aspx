<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ProductDetail.aspx.cs" Inherits="Coffee.ProductDetail" %>

<!DOCTYPE html>
<html>
<head runat="server">
    <title>Chi tiết cà phê</title>
</head>
<body>
<form id="form1" runat="server">

    <h2>☕ CHI TIẾT CÀ PHÊ</h2>

    <b>Tên:</b>
    <asp:Label ID="lblName" runat="server" /><br /><br />

    <b>Giá:</b>
    <asp:Label ID="lblPrice" runat="server" /><br /><br />

    <b>Mô tả:</b>
    <asp:Label ID="lblDesc" runat="server" /><br /><br />

    <asp:Button ID="btnAddCart"
        runat="server"
        Text="Thêm vào giỏ hàng"
        OnClick="btnAddCart_Click" />

    <br /><br />
    <asp:HyperLink ID="lnkBack" runat="server" NavigateUrl="Products.aspx">
        ← Quay lại danh sách
    </asp:HyperLink>

</form>
</body>
</html>
