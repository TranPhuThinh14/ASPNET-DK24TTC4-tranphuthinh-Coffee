<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="OrderDetails.aspx.cs" Inherits="Coffee.OrderDetails" %>

<!DOCTYPE html>
<html>
<head runat="server">
    <title>Chi tiết đơn hàng</title>
</head>
<body>
    <form id="form1" runat="server">

        <h2>Chi tiết đơn hàng</h2>

        <asp:Label ID="lblOrderId" runat="server" Font-Bold="true"></asp:Label>
        <br /><br />

        <asp:GridView ID="gvDetails" runat="server" AutoGenerateColumns="False">
            <Columns>
                <asp:BoundField DataField="ProductName" HeaderText="Sản phẩm" />
                <asp:BoundField DataField="Price" HeaderText="Giá" />
                <asp:BoundField DataField="Quantity" HeaderText="Số lượng" />
                <asp:BoundField DataField="Total" HeaderText="Thành tiền" />
            </Columns>
        </asp:GridView>

        <br />
        <a href="MyOrders.aspx">⬅ Quay lại đơn hàng</a>

    </form>
</body>
</html>
