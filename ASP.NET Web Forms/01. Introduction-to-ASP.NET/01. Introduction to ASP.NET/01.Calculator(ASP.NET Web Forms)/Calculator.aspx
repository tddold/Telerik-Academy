<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Calculator.aspx.cs" Inherits="_01.Calculator_ASP.NET_Web_Forms_.Calculator" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Calculator</title>
</head>
<body>
    <form id="form" runat="server">
        <div>
            <asp:Label ID="lblFirstNumber" runat="server" name="firstNamme">First Number: </asp:Label>
            <asp:TextBox ID="btnFirstNumber" runat="server" name="firstNumber" value="0"></asp:TextBox>
        </div>
        <br />
        <div>
            <asp:Label ID="lblSecondNumber" runat="server" name="secondNamme">Second Number: </asp:Label>
            <asp:TextBox ID="btnSecondNumber" runat="server" name="secondNumber" value="0"></asp:TextBox>
        </div>
        <br />
        <div>
            <asp:Button ID="btnSum" runat="server" nema="sum" OnClick="btnSum_Click"></asp:Button>
        </div>
        <br />
        <div>
            <asp:Label ID="lblResult" runat="server" name="result">Result: </asp:Label>
            <asp:TextBox ID="btnResult" runat="server" name="result" value="0"></asp:TextBox>
        </div>
    </form>
</body>
</html>
