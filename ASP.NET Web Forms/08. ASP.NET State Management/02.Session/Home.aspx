<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="_02.Session.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Session</title>
</head>
<body>
    <form id="MainForm" runat="server">
    <asp:TextBox ID="TextBoxInput" runat="server"></asp:TextBox>
        <asp:Button ID="ButtonSubmit" runat="server" Text="Button" OnClick="ButtonSubmit_Click" />
        <h3>Session Text:</h3>
        <asp:Label ID="LabelOutput" runat="server"></asp:Label>
    </form>
</body>
</html>
