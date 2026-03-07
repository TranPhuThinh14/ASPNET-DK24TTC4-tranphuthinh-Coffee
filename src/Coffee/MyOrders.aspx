<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MyOrders.aspx.cs" Inherits="Coffee.MyOrders" %>

<!DOCTYPE html>
<html>
<head runat="server">
    <title>Đơn hàng của tôi</title>
</head>
<body>
    <form id="form1" runat="server">

        <h2>Đơn hàng của tôi</h2>

        <asp:GridView ID="gvOrders" runat="server" AutoGenerateColumns="False">
    <Columns>
        <asp:HyperLinkField
            DataTextField="Id"
            DataNavigateUrlFields="Id"
            DataNavigateUrlFormatString="OrderDetails.aspx?orderId={0}"
            HeaderText="Mã đơn" />

        <asp:BoundField DataField="Total" HeaderText="Tổng tiền" />
        <asp:BoundField DataField="CreatedAt" HeaderText="Ngày đặt" />
    </Columns>
</asp:GridView>


        <br />
        <asp:HyperLink NavigateUrl="Home.aspx" runat="server">⬅ Quay lại trang chủ</asp:HyperLink>

    </form>
</body>
</html>
