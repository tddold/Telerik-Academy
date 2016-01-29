<%@ Page Title="Home Page" Language="C#"
    MasterPageFile="~/Site.Master"
    AutoEventWireup="true"
    CodeBehind="Default.aspx.cs" Inherits="_01.EmployeesOrders._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <h1>Employees</h1>

    <asp:GridView ID="GridViewEmployees" runat="server"
        AllowPaging="True" ItemType="_01.EmployeesOrders.Models.EmployeeViewModel"
        OnSelectedIndexChanged="GridViewEmployees_SelectedIndexChanged"
        DataKeyNames="EmployeeID">
        <Columns>
            <asp:CommandField ShowSelectButton="true" />
        </Columns>
    </asp:GridView>
    <br />
    <br />

    <asp:UpdateProgress ID="UpdateProgress" runat="server">
        <ProgressTemplate>
            Updating ...
            <img src="Images/loading.gif" alt="" height="50" width="50" />
        </ProgressTemplate>
    </asp:UpdateProgress>

    <asp:UpdatePanel ID="UpdatePanelOrders" runat="server">
        <ContentTemplate>
            <asp:GridView ID="GridViewOrders" runat="server"
                AutoGenerateColumns="true"
                AllowPaging="true"
                PageSize="10">
            </asp:GridView>
        </ContentTemplate>
    </asp:UpdatePanel>

</asp:Content>
