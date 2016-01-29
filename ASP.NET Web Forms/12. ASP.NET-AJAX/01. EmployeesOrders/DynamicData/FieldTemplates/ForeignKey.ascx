<%@ Control Language="C#" CodeBehind="ForeignKey.ascx.cs" Inherits="_01.EmployeesOrders.ForeignKeyField" %>

<asp:HyperLink ID="HyperLink1" runat="server"
    Text="<%# GetDisplayString() %>"
    NavigateUrl="<%# GetNavigateUrl() %>"  />

