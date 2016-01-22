<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RandomNumber.aspx.cs" Inherits="_01.Random_Number.RandomNumber" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Random Number</title>
</head>
<body>
    <form id="myForm" runat="server">
        <div>
            <h1>Random number using the HTML server controls</h1>
            Min number for range:
            <input id="minNumberInput" runat="server" type="number" name="minNumber" value="10" max="10000"/>
            <br />
            <br />
            Max number for range:
            <input id="maxNumberInput" runat="server" type="number" name="maxnNumber" value="20" max="10000"/>
            <br />
            <br />
            <input id="btnSubmit" runat="server" type="button" name="submit" value="Submit" onserverclick="btnSubmit_ServerClick"/>
            <br />
            <br />
            Result:
            <input id="result" runat="server" type="text" name="result" />
        </div>

         <div>
            <h1>Random number using Web server controls</h1>
            Min number for range:
            <asp:TextBox ID="tbMin" runat="server" value="10"/>
            <br />
            <br />
            Max number for range:
            <asp:TextBox ID="tbMax" runat="server" value="20"/>
            <br />
            <br />
            <asp:Button ID="buttonSubmit" runat="server" value="Submit" OnClick="buttonSubmit_Click"/>
            <br />
            <br />
            Result:
            <asp:Label ID="lblResult" runat="server"/>
        </div>
    </form>
</body>
</html>
