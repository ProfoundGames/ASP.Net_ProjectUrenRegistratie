﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="ProjectUrenRegistratie.WebsiteItems.WebForm1" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <%--ff mooi maken met CSS ofzo--%>
            <asp:Label ID="lblUsername" runat="server" Text="Username"></asp:Label>
            <asp:TextBox ID="txtUsername" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblPassword" runat="server" Text="Password"></asp:Label>
            <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" />

        </div>
    </form>
</body>
</html>
