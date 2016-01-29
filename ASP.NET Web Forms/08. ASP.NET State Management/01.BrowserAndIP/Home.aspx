<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="_01.BrowserAndIP.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="MainForm" runat="server">
        <div>
            <p>
                Your browser is:
                     <asp:Label ID="LabelBrowser" Text="test" runat="server"></asp:Label>
            </p>
            <p>
                Your IP address is:
                    <asp:Label ID="LabelIPAddress" runat="server" Text="text"></asp:Label>
            </p>
        </div>
    </form>
</body>
</html>
