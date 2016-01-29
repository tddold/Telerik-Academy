<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EmployeeDetails.aspx.cs" Inherits="EmployeesDataBinding.EmployeeDetails" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Employee Details</title>
</head>
<body>
    <form id="MainForm" runat="server">
        <asp:DetailsView ID="EmployeeDetailsView" runat="server"
            AutoGenerateRows="true"
            AllowPaging="true">
        </asp:DetailsView>

        <br />
        <br />

        <asp:Button Text="Back" ID="ButtonClick" runat="server" OnClick="OnBackButtonClick" />
    </form>
</body>
</html>
