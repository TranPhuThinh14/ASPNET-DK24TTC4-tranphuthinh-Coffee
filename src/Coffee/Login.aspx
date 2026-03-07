<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Coffee.Login" %>

<!DOCTYPE html>
<html>
<head runat="server">
    <title>Login</title>
</head>
<body>
    <form id="form1" runat="server">
        <h2>ĐĂNG NHẬP</h2>

        <asp:Label Text="Username:" runat="server" />
        <br />
        <asp:TextBox ID="txtUsername" runat="server" />
        <br /><br />

        <asp:Label Text="Password:" runat="server" />
        <br />
        <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" />
        <br /><br />

        <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" />
        <br /><br />

        <asp:Label ID="lblMessage" runat="server" ForeColor="Red" />
    </form>
</body>
</html>
