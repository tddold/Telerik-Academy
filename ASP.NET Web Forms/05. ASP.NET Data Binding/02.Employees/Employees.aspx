<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Employees.aspx.cs" Inherits="EmployeesDataBinding.Employees" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="MainForm" runat="server">
        <asp:GridView ID="GirdViewEmployees" runat="server" AutoGenerateColumns="false" AllowPaging="true" DataKeyNames="EmployeeID">
            <Columns>
                <asp:BoundField DataField="FirstName" HeaderText="First Name" />
                <asp:BoundField DataField="LastName" HeaderText="Last Name" />
                <asp:BoundField DataField="HomePhone" HeaderText="Phone" />
                <asp:HyperLinkField
                    Text="Details"
                    DataNavigateUrlFields="EmployeeID"
                    DataNavigateUrlFormatString="EmployeeDetails.aspx?id={0}" />
            </Columns>
        </asp:GridView>
    </form>
</body>
</html>
