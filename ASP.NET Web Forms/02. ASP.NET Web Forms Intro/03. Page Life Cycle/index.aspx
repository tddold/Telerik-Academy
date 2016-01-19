<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="_03.Page_Life_Cycle.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Page Life Cycle</title>
</head>
<body>
    <form id="webForm" runat="server">
    <div>
        <br />
        <asp:Button ID="btnOnButton" 
                    runat="server" 
                    OnInit="btnOnButton_Init" 
                    OnLoad="btnOnButton_Load" 
                    OnClick="btnOnButton_Click" 
                    OnPreRender="btnOnButton_PreRender" 
                    Text="Press" />
        <br />
        <asp:Label runat="server" ID="lblTextBlock"></asp:Label>
    </div>
    </form>
</body>
</html>
