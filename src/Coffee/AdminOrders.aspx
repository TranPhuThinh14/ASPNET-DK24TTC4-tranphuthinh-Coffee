<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminOrders.aspx.cs" Inherits="Coffee.AdminOrders" %>

<!DOCTYPE html>
<html>
<head runat="server">
    <title>Quản lý đơn hàng</title>
</head>
<body>
<form id="form1" runat="server">

    <h2>Danh sách đơn hàng</h2>

    <asp:GridView ID="gvOrders" runat="server" AutoGenerateColumns="False">
    <Columns>

        <%-- MÃ ĐƠN: CLICK XEM CHI TIẾT --%>
        <asp:HyperLinkField
            HeaderText="Mã đơn"
            DataTextField="Id"
            DataNavigateUrlFields="Id"
            DataNavigateUrlFormatString="OrderDetails.aspx?orderId={0}" />

        <asp:BoundField DataField="Username" HeaderText="Khách hàng" />
        <asp:BoundField DataField="Total" HeaderText="Tổng tiền" />
        <asp:BoundField DataField="CreatedAt" HeaderText="Ngày đặt" />
    </Columns>
</asp:GridView>

    <hr />

    <h3>📊 Thống kê doanh thu</h3>
    <asp:Label ID="lblRevenue" runat="server" Font-Bold="true"></asp:Label>

</form>
</body>
</html>
