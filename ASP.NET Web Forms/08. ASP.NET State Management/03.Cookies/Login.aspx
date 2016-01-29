<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="_03.Cookies.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Cookies</title>
</head>
<body>
    <form id="MainForm" runat="server">
    
        <nav>
            <a href="Home.aspx">Home</a>
            <a href="Login.aspx">Login</a>
        </nav>

        Username:
        <asp:TextBox ID="TextBoxUser" runat="server"></asp:TextBox>
        <asp:Button ID="ButtonLogin" runat="server" Text="Login" OnClick="ButtonLogin_Click" />

    </form>
</body>
</html>
