<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="_01.Print_your_name.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Welcome</title>
</head>
<body>
    <form id="printNameForm" runat="server">
        <div>Enter your name: </div>
        <br />
        <asp:TextBox runat="server" ID="btnNameTextBox"></asp:TextBox>
        <br />
        <br />
        <asp:Button runat="server" ID="btnSubit" name="OnButtonClicked" OnClick="OnButtonClicked"/>
        <br />
        <br />
        <asp:Label runat="server" ID="lblNameResultBox"></asp:Label>
    </form>
</body>
</html>
