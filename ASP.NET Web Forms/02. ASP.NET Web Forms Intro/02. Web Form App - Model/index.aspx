<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="_02.Web_Form_App___Model.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Web Forms App - Model</title>
</head>
<body>
    <form id="webForm" runat="server">
        <div>
            <asp:Label runat="server" ID="lblWebForm"></asp:Label>
            <br />
            <asp:Label runat="server" ID="lblLocationTextBlock"></asp:Label>
            <br />
            <br /> 
            <div>
                <strong>.aspx file</strong> containing HTML for visualization.
            </div>
            <div>
                <strong>"Code behind" (.aspx.cs)</strong> containing the presentation logic for particular page. It separates the presentation logic from UI visualization.
            </div>
        </div>
    </form>
</body>
</html>
