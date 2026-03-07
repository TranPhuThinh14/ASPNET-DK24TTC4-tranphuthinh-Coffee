<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TestDB.aspx.cs" Inherits="Coffee.TestDB" %>

<!DOCTYPE html>
<html>
<head runat="server">
    <title>Test DB Connection</title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Button ID="btnTest" runat="server" Text="Test kết nối DB" OnClick="btnTest_Click" />
        <br /><br />
        <asp:Label ID="lblResult" runat="server" />
    </form>
</body>
</html>
