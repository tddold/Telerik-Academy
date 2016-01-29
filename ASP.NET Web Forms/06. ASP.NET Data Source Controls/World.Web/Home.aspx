<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="World.Web.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>World</title>
</head>
<body>
    <form id="MainForm" runat="server">
         <asp:SqlDataSource ID="SqlDataSourceContinets" runat="server"
            ConnectionString="<%$  ConnectionStrings:WorldConnection %>"
            SelectCommand="SELECT * FROM [Continents]"
            DeleteCommand="DELETE FROM [Continents] WHERE [id] = @Id"
            InsertCommand="INSERT INTO [Continents] SET ([Name]) VALUE (@Name)"
            UpdateCommand="UPDATE [Continents] SET [Name] = @Name WHERE [Id] = @Id">
            <InsertParameters>
                <asp:Parameter Name="Name" Type="String" />
            </InsertParameters>
            <DeleteParameters>
                <asp:Parameter Name="Id" Type="Int32" />
            </DeleteParameters>
            <UpdateParameters>
                <asp:Parameter Name="Name" Type="String" />
                <asp:Parameter Name="Id" Type="Int32" />
            </UpdateParameters>
        </asp:SqlDataSource>

        <p>Continents:</p>
        <asp:ListBox ID="ListBoxContinents" runat="server"
            DataSourceID="SqlDataSourceContinets"
            DataTextField="Name"
            DataValueField="Id"
            AutoPostBack="true"
            Rows="5"
            OnSelectedIndexChanged="ListBoxContinents_SelectedIndexChanged"></asp:ListBox>

        <asp:EntityDataSource ID="EntityDataSourceCountries" runat="server"
            ConnectionString="name=WorldEntities"
            DefaultContainerName="WorldEntities"
            EnableDelete="true"
            EnableInsert="true"
            EnableUpdate="true"
            EntitySetName="Countries">
        </asp:EntityDataSource>

        <p>Countries:</p>
        <asp:GridView ID="GridViewCountries" runat="server"
            AutoGenerateColumns="false"
            DataKeyNames="Id"
            AllowPaging="true"
            PageSize="3"
            ItemType="World.Web.Countries"
            AutoGenerateEditButton="true"
            AllowSorting="true"
            CellPadding="4"
            DataSourceID="EntityDataSourceCountries"
            ForeColor="#333333"
            GridLines="None"
            OnRowUpdating="GridViewCountries_RowUpdating">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField DataField="Id" HeaderText="Id" ReadOnly="true" SortExpression="Id" />
                <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
                <asp:BoundField DataField="Language" HeaderText="Language" SortExpression="Language" />
                <asp:BoundField DataField="Population" HeaderText="Population" SortExpression="Population" />

                <asp:TemplateField>
                    <EditItemTemplate>
                        <asp:FileUpload ID="FileUploadControl" runat="server" />
                    </EditItemTemplate>
                </asp:TemplateField>
            </Columns>
            <EditRowStyle BackColor="#2461BF" />
            <FooterStyle BackColor="#507CD1" Font-Bold="true" ForeColor="White" />
            <HeaderStyle BackColor="#507CD1" Font-Bold="true" ForeColor="White" />
            <PagerStyle BackColor="#2461BF" />
            <RowStyle BackColor="#EFF3FB" />
            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="true" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#F5F7FB" />
            <SortedAscendingHeaderStyle BackColor="#6D95E1" />
            <SortedDescendingCellStyle BackColor="#E9EBEF" />
            <SortedDescendingHeaderStyle BackColor="#4870BE" />
            <EmptyDataTemplate>
                <p>No countries for selected continent.</p>
            </EmptyDataTemplate>
        </asp:GridView>

        <%--<p>Towns:</p>
        <asp:EntityDataSource ID="EntityDataSourceTowns" runat="server"
            ConnectionString="name=WorldEntities"
            DefaultContainerName="WorldEntities"
            EnableFlattening="true"
            EnableDelete="false"
            EnableInsert="true"
            EnableUpdate="true"
            EntitySetName="Towns">
        </asp:EntityDataSource>

        <asp:ListView ID="ListViewTowns" runat="server"
            DataKeyNames="Id"
            ItemType="World.Web.Towns"
            DataSourceID="EntityDataSourceTowns"
            InsertItemPosition="LastItem">
            <AlternatingItemTemplate>
                <td runat="server" style="background-color: #FFF8DC;">Id:
                    <asp:Label ID="LabelId" runat="server" Text='<%# Eval("Id") %>'></asp:Label>
                    <br />
                    Name:<asp:Label ID="LabelName" runat="server" Text='<%# Eval("Name") %>'></asp:Label>
                    <br />
                    Population:
                    <asp:Label ID="LabelPopulation" runat="server" Text='<%# Eval("Population") %>'></asp:Label>
                    <br />
                    CountryId:
                    <asp:Label ID="LabelCountryId" runat="server" Text='<%# Eval("CountryId") %>'></asp:Label>
                    <br />
                </td>
            </AlternatingItemTemplate>
            <EditItemTemplate>
                <td runat="server" style="background-color: #008A8C; color: #FFFFFF;">Id
                    <asp:Label ID="Label1" runat="server" Text='<%# Eval("Id") %>'></asp:Label>
                    <br />
                    Name:
                    <asp:TextBox ID="TextBoxName" runat="server" Text='<%# Bind("Name") %>'></asp:TextBox>
                    <br />
                    Population:
                    <asp:TextBox ID="TextBoxPolulation" runat="server" Text='<%# Bind("Population") %>'></asp:TextBox>
                    <br />
                    CountryId:
                    <asp:TextBox ID="TextBoxCountryId" runat="server" Text='<%# Bind("CountryId") %>'></asp:TextBox>
                    <br />
                    <asp:Button ID="ButtonUpdate" runat="server" CommandName="Update" Text="Update" />
                    <asp:Button ID="ButtonCancel" runat="server" CommandName="Cancel" Text="Update" />
                </td>
            </EditItemTemplate>
            <InsertItemTemplate>
                <td runat="server" style="">Id:
                    <asp:TextBox ID="IdTextBox" runat="server" Text='<%# Bind("Id") %>' />
                    <br />
                    Name:
                    <asp:TextBox ID="NameTextBox" runat="server" Text='<%# Bind("Name") %>' />
                    <br />
                    Population:
                    <asp:TextBox ID="PopulationTextBox" runat="server" Text='<%# Bind("Population") %>' />
                    <br />
                    CountryId:
                    <asp:TextBox ID="CountryIdTextBox" runat="server" Text='<%# Bind("CountryId") %>' />
                    <br />
                    <asp:Button ID="InsertButton" runat="server" CommandName="Insert" Text="Insert" />
                    <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" Text="Clear" />
                </td>
            </InsertItemTemplate>
            <ItemTemplate>
                <td runat="server" style="background-color: #DCDCDC; color: #000000;">Id:
                    <asp:Label ID="IdLabel" runat="server" Text='<%# Eval("Id") %>' />
                    <br />
                    Name:
                    <asp:Label ID="NameLabel" runat="server" Text='<%# Eval("Name") %>' />
                    <br />
                    Population:
                    <asp:Label ID="PopulationLabel" runat="server" Text='<%# Eval("Population") %>' />
                    <br />
                    CountryId:
                    <asp:Label ID="CountryIdLabel" runat="server" Text='<%# Eval("CountryId") %>' />
                    <br />
                    <asp:Button ID="EditButton" runat="server" CommandName="Edit" Text="Edit" />
                    <asp:Button ID="DeleteButton" runat="server" CommandName="Delete" Text="Delete" />
                </td>
            </ItemTemplate>

            <LayoutTemplate>
                <table runat="server"
                    border="1" 
                    style="background-color: #FFFFFF;
                           border-collapse:collapse; 
                           border-color: #999999; 
                           border-style:none; 
                           border-width:1px; 
                           font-family: Verdana, Arial, Helvetica, sans-serif;">
                    <tr id="itemPlaceholderContainer" runat="server">
                        <td id="itemPlaceholder" runat="server"></td>
                    </tr>
                </table>

                <div style="text-align: center; 
                            background-color: #CCCCCC; 
                            font-family:Verdana, Arial, Helvetica, sans-serif; 
                            color: #000000;">
                    <asp:DataPager ID="DataPager1" runat="server">
                        <Fields>
                            <asp:NextPreviousPagerField ButtonType="Button" ShowFirstPageButton="true" ShowLastPageButton="true" />
                        </Fields>
                    </asp:DataPager>
                </div>
            </LayoutTemplate>

            <SelectedItemTemplate>
                <td runat="server" style="background-color: #008A8C; font-weight: bold; color: #FFFFFF;">Id:
                    <asp:Label ID="IdLabel" runat="server" Text='<%# Eval("Id") %>' />
                    <br />
                    Name:
                    <asp:Label ID="NameLabel" runat="server" Text='<%# Eval("Name") %>' />
                    <br />
                    Population:
                    <asp:Label ID="PopulationLabel" runat="server" Text='<%# Eval("Population") %>' />
                    <br />
                    CountryId:
                    <asp:Label ID="CountryIdLabel" runat="server" Text='<%# Eval("CountryId") %>' />
                    <br />
                    <asp:Button ID="EditButton" runat="server" CommandName="Edit" Text="Edit" />
                    <asp:Button ID="DeleteButton" runat="server" CommandName="Delete" Text="Delete" />
                </td>
            </SelectedItemTemplate>
        </asp:ListView>--%>




    </form>
</body>
</html>
