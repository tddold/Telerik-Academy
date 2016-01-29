<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Employees.aspx.cs" Inherits="EmployeesFormView.Employees" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Employees</title>
</head>
<body>
    <form id="MainForm" runat="server">
        
        <asp:FormView ID="FormViewEmployees" runat="server" ItemType="EmployeesDataBinding.Employees"
            AllowPaging="true" OnPageIndexChanging="FormViewEmployees_PageIndexChanged">
            <ItemTemplate>
                <table>
                        <tr>
                            <th>First Name</th>
                            <th>Last Name</th>
                            <th>Phone</th>
                            <th>City</th>
                            <th></th>
                        </tr>
                        <tr>
                            <td><%#: Item.FirstName %></td>
                            <td><%#: Item.LastName %></td>
                            <td><%#: Item.HomePhone %></td>
                            <td><%#: Item.City %></td>
                            <td><a href="Employees.aspx?id=<%# Item.EmployeeID %>">Details</a></td>
                        </tr>
                </table>
                
            </ItemTemplate>
            <EditItemTemplate>
                <p>First Name: <%#: Item.FirstName %></p>
                <p>Last Name: <%#: Item.LastName %></p>
                <p>Phone: <%#: Item.HomePhone %></p>
                <p>City: <%#: Item.City%></p>
                Notes:
                <p><%#: Item.Notes %></p>
                <br />
                <asp:Button Text="Back" ID="ButtonClick" runat="server" OnClick="OnBackButtonClick" />
            </EditItemTemplate>
        </asp:FormView>
    </form>
</body>
</html>
