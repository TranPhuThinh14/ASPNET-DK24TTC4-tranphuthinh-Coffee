<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminStatistics.aspx.cs" Inherits="Coffee.AdminStatistics" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <h2>THỐNG KÊ DOANH THU</h2>

<asp:Label Text="Từ ngày:" runat="server" />
<asp:TextBox ID="txtFrom" runat="server" TextMode="Date" />

<asp:Label Text="Đến ngày:" runat="server" />
<asp:TextBox ID="txtTo" runat="server" TextMode="Date" />

<asp:Button ID="btnStat" runat="server"
    Text="Thống kê"
    OnClick="btnStat_Click" />

<br /><br />

<asp:Label ID="lblTotal" runat="server"
    Font-Bold="true" ForeColor="Green" />

<br /><br />

<asp:GridView ID="gvRevenue" runat="server" AutoGenerateColumns="true" />
        <h3>SẢN PHẨM BÁN CHẠY</h3>

<asp:GridView ID="gvTopProducts"
    runat="server"
    AutoGenerateColumns="true" />

        <div>
        </div>
    </form>
</body>
</html>
