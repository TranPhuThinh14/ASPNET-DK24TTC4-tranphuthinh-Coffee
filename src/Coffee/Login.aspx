<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Coffee.Login" %>

<!DOCTYPE html>
<html>
<head runat="server">
    <title>Login - Coffee Shop</title>

    <style>

        body{
            margin:0;
            padding:0;
            font-family: Arial;
            background:#f2f2f2;
        }

        .login-container{
            width:350px;
            background:white;
            margin:120px auto;
            padding:40px;
            border-radius:8px;
            box-shadow:0 4px 10px rgba(0,0,0,0.1);
            text-align:center;
        }

        h2{
            margin-bottom:25px;
            color:#333;
        }

        .textbox{
            width:100%;
            padding:10px;
            margin:10px 0;
            border:1px solid #ccc;
            border-radius:4px;
        }

        .btn-login{
            width:100%;
            padding:10px;
            background:#555;
            color:white;
            border:none;
            border-radius:4px;
            cursor:pointer;
        }

        .btn-login:hover{
            background:#333;
        }

        .footer-text{
            margin-top:15px;
            color:#777;
            font-size:14px;
        }

    </style>

</head>

<body>

<form id="form1" runat="server">

    <div class="login-container">

        <h2>Coffee Shop Login</h2>

        <asp:TextBox 
            ID="txtUsername" 
            runat="server" 
            CssClass="textbox"
            Placeholder="Username">
        </asp:TextBox>

        <asp:TextBox 
            ID="txtPassword" 
            runat="server" 
            CssClass="textbox"
            TextMode="Password"
            Placeholder="Password">
        </asp:TextBox>

        <asp:Button 
            ID="btnLogin" 
            runat="server" 
            Text="Login"
            CssClass="btn-login"
            OnClick="btnLogin_Click"/>

        <div class="footer-text">
            Coffee Shop System
        </div>

    </div>
    <asp:Label ID="lblMessage" runat="server" ForeColor="Red" />
</form>

</body>
</html>