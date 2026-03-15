<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Products.aspx.cs" Inherits="Coffee.Products" %>

<!DOCTYPE html>
<html>
<head runat="server">
    <title>Danh sách cà phê</title>
</head>
<body>
<form id="form1" runat="server">
    <div class="search-box" style="text-align: center; margin: 20px 0;">
    <asp:TextBox ID="txtSearchUser" runat="server" placeholder="Bạn muốn uống gì hôm nay?..." 
        Width="300px" Height="30px" style="padding: 5px; border-radius: 15px; border: 1px solid #ccc;"></asp:TextBox>
    
    <asp:Button ID="btnSearchUser" runat="server" Text="Tìm kiếm" OnClick="btnSearchUser_Click" 
        style="border-radius: 15px; padding: 5px 15px; background-color: #4CAF50; color: white; cursor: pointer;" />
</div>

<asp:DataList ID="dlProducts" runat="server" RepeatColumns="3">
    <ItemTemplate>
        </ItemTemplate>
</asp:DataList>
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
