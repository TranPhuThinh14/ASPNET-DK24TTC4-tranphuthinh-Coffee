<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Cart.aspx.cs" Inherits="Coffee.Cart" %>

<!DOCTYPE html>
<html>
<head runat="server">
    <title>Giỏ hàng</title>
</head>
<body>
<form id="form1" runat="server">

    <h2>🛒 GIỎ HÀNG</h2>

    <asp:GridView ID="gvCart"
    runat="server"
    AutoGenerateColumns="False"
    BorderWidth="1"
    CellPadding="5"
    OnRowCommand="gvCart_RowCommand">

    <Columns>
        <asp:BoundField DataField="Name" HeaderText="Tên cà phê" />
        <asp:BoundField DataField="Price" HeaderText="Giá" />

         <%-- CỘT SỐ LƯỢNG --%>
        <asp:TemplateField HeaderText="Số lượng">
            <ItemTemplate>
                <asp:TextBox ID="txtQty"
                    runat="server"
                    Width="50"
                    Text='<%# Eval("Quantity") %>' />
            </ItemTemplate>
        </asp:TemplateField>

        <%-- NÚT CẬP NHẬT --%>
        <asp:TemplateField>
            <ItemTemplate>
                <asp:Button ID="btnUpdate"
                    runat="server"
                    Text="Cập nhật"
                    CommandName="updateQty"
                    CommandArgument='<%# Container.DataItemIndex %>' />
            </ItemTemplate>
        </asp:TemplateField>

       


    </Columns>
                
</asp:GridView>
                    <asp:Button ID="btnCheckout" runat="server" Text="Thanh toán" OnClick="btnCheckout_Click" />

<br />
<asp:Label ID="lblResult" runat="server" ForeColor="Green" />



    <br />
    <asp:Label ID="lblTotal" runat="server" Font-Bold="true" />
    <br /><br />

    <asp:HyperLink ID="lnkBack" runat="server" NavigateUrl="Products.aspx">
        ← Tiếp tục mua
    </asp:HyperLink>

</form>
</body>
</html>
