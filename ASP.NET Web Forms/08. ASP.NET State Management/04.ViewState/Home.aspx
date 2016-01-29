<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="_04.ViewState.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>View State</title>
    <script src="Scripts/jquery-2.2.0.min.js"></script>
</head>
<body>
    <form id="MainForm" runat="server">

        <asp:TextBox ID="TextBoxInput" runat="server"></asp:TextBox>
        <asp:Button ID="ButtonSubmit" runat="server" Text="Submit" OnClick="ButtonSubmit_Click" />

        <button id="deleteViewState">Delete ViewState</button>

        <h3>Result in ViewState</h3>
        <asp:Label ID="LabelOutput" runat="server" />
    </form>

    <script>
        $(document).ready(
            $("#deleteViewState").on("click", function () {
                $("#_VIEWSTATE").val("");
            }));
    </script>

</body>
</html>
