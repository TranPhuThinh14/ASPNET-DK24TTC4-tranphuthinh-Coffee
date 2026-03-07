<%@ Page Language="C#" MasterPageFile="~/Site.Master"
    AutoEventWireup="true"
    CodeBehind="Users.aspx.cs"
    Inherits="Coffee.Users" %>

<asp:Content ID="Content1"
    ContentPlaceHolderID="MainContent"
    runat="server">

    <div style="text-align:right">
        <asp:Button ID="btnLogout"
            runat="server"
            Text="Logout"
            OnClick="btnLogout_Click" />
        Xin chào:
        <asp:Label ID="lblUser" runat="server" Font-Bold="true" />
    </div>

    <h2>DANH SÁCH USERS</h2>

    <asp:GridView ID="gvUsers" runat="server"
        AutoGenerateColumns="False"
        DataKeyNames="Id"
        OnRowEditing="gvUsers_RowEditing"
        OnRowUpdating="gvUsers_RowUpdating"
        OnRowCancelingEdit="gvUsers_RowCancelingEdit"
        OnRowDeleting="gvUsers_RowDeleting">

        <Columns>
            <asp:BoundField DataField="Id" HeaderText="Id" ReadOnly="true" />
            <asp:BoundField DataField="Username" HeaderText="Username" />
            <asp:BoundField DataField="Password" HeaderText="Password" />
            <asp:CommandField ShowEditButton="true" ShowDeleteButton="true" />
        </Columns>
    </asp:GridView>

    <hr />
    <asp:Panel ID="pnlAddUser" runat="server">
    <h3>THÊM USER</h3>
    Username:
    <asp:TextBox ID="txtUsername" runat="server" /><br />
    Password:
    <asp:TextBox ID="txtPassword" runat="server" /><br /><br />

    <asp:Button ID="btnAdd" runat="server"
        Text="Add User"
        OnClick="btnAdd_Click" />
        </asp:Panel>

</asp:Content>
