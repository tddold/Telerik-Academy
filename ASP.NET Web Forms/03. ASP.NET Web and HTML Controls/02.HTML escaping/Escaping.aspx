<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Escaping.aspx.cs" Inherits="_02.HTML_escaping.Escaping" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>HTML escaping</title>
</head>
<body>
    <form id="myForm" runat="server">
        <div>
            <h1>HTML escaping</h1>
            <asp:TextBox ID="tbInputTextBox" runat="server" Placeholder="Enter some text here..."></asp:TextBox>
            <asp:Button ID="btnButtonSubmit" runat="server" OnClick="btnButtonSubmit_Click" Text="submit" />
            <br />
            <br />
            <asp:TextBox ID="tbEnteredTextBox" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblEnteredTexLabel" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
