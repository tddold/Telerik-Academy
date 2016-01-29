<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Employees.aspx.cs" Inherits="EmployeesRepeater.Employees" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Employees</title>
</head>
<body>
    <form id="MainForm" runat="server">
        <h1>Employees List</h1>
        <asp:Repeater ID="RepeaterEmployees" runat="server" ItemType="EmployeesDataBinding.Employees">
            <HeaderTemplate>
                <table>
                    <thead>
                        <th>Index</th>
                        <th>First Name</th>
                        <th>Last Name</th>
                        <th>Phone</th>
                        <th>Country</th>
                        <th>City</th>
                    </thead>
            </HeaderTemplate>
            <ItemTemplate>
                <tbody>
                    <tr>
                        <td><%#: Item.EmployeeID %></td>
                        <td><%#: Item.FirstName %></td>
                        <td><%#: Item.LastName %></td>
                        <td><%#: Item.HomePhone %></td>
                        <td><%#: Item.Country %></td>
                        <td><%#: Item.City %></td>
                    </tr>
                </tbody>
            </ItemTemplate>
            <FooterTemplate>
                </table>
            </FooterTemplate>
        </asp:Repeater>
    </form>
</body>
</html>
