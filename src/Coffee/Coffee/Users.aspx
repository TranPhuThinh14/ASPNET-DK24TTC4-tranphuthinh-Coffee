<%@ Page Language="C#" AutoEventWireup="true"
    CodeBehind="Users.aspx.cs"
    Inherits="Coffee.Users" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <h2>DANH SÁCH USERS</h2>

<asp:GridView ID="gvUsers" runat="server" AutoGenerateColumns="true" />

        <div>
        </div>
    </form>
</body>
</html>
