<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="Coffee.Home" %>

<!DOCTYPE html>
<html>
<head runat="server">
    <title>Trang người dùng</title>
</head>
<body>
<form id="form1" runat="server">

    <h2>☕ WEBSITE BÁN CÀ PHÊ</h2>

    Xin chào:
    <asp:Label ID="lblUser" runat="server" Font-Bold="true" />
    <br /><br />

    <asp:HyperLink ID="lnkProducts" runat="server" NavigateUrl="Products.aspx">
        Xem danh sách cà phê
        <a href="MyOrders.aspx">📦 Đơn hàng của tôi</a>
    </asp:HyperLink>
    
    <br /><br />

    <asp:Button ID="btnLogout" runat="server" Text="Logout" OnClick="btnLogout_Click" />

</form>
</body>
</html>
