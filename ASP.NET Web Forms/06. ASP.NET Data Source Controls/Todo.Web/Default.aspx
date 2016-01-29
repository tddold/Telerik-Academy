<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Todo.Web._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <asp:SqlDataSource ID="SqlDataSourceCategories" runat="server"
        ConnectionString="<%$ ConnectionStrings:TodoDbaseConnectionString %>"
        DeleteCommand="DELETE FROM [Categories] WHERE [Id] = @original_Id"
        InsertCommand="INSERT INTO [Categories] ([Name]) VALUES (@Name)"
        OldValuesParameterFormatString="original_{0}"
        SelectCommand="SELECT * FROM [Categories]"
        UpdateCommand="UPDATE [Categories] SET [Name] = @Name WHERE [Id] = @original_Id">
        <DeleteParameters>
            <asp:Parameter Name="original_Id" Type="Int32" />
        </DeleteParameters>
        <InsertParameters>
            <asp:Parameter Name="Name" Type="String" />
        </InsertParameters>
        <UpdateParameters>
            <asp:Parameter Name="Name" Type="String" />
            <asp:Parameter Name="original_Id" Type="Int32" />
        </UpdateParameters>
    </asp:SqlDataSource>

    <h3>Categories</h3>
    <asp:ListView ID="ListViewCategories" runat="server"
        DataSourceID="SqlDataSourceCategories"
        DataKeyNames="Id"
        InsertItemPosition="LastItem">
        <AlternatingItemTemplate>
            <td runat="server" style="background-color: #FAFAD2; color: #284775;">Id:
                <asp:Label ID="IdLabel" runat="server" Text='<%# Eval("Id") %>' />
                <br />
                Name:
                <asp:Label ID="NameLabel" runat="server" Text='<%# Eval("Name") %>' />
                <br />
                <asp:Button ID="EditButton" runat="server" CommandName="Edit" Text="Edit" />
                <asp:Button ID="DeleteButton" runat="server" CommandName="Delete" Text="Delete" />
            </td>
        </AlternatingItemTemplate>

        <EditItemTemplate>
            <td runat="server" style="background-color: #FFCC66; color: #000080;">Id:
                <asp:Label ID="IdLabel1" runat="server" Text='<%# Eval("Id") %>' />
                <br />
                Name:
                <asp:TextBox ID="NameTextBox" runat="server" Text='<%# Bind("Name") %>' />
                <br />
                <asp:Button ID="UpdateButton" runat="server" CommandName="Update" Text="Update" />
                <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" Text="Cancel" />
            </td>
        </EditItemTemplate>

        <EmptyDataTemplate>
            <table style="background-color: #FFFFFF; 
                          border-collapse: collapse; 
                          border-color: #999999; 
                          border-style: none; 
                          border-width: 1px;">
                <tr>
                    <td>No data was returned.</td>
                </tr>
            </table>
        </EmptyDataTemplate>

        <InsertItemTemplate>
            <td runat="server" style="">Name:
                <asp:TextBox ID="NameTextBox" runat="server" Text='<%# Bind("Name") %>' />
                <br />
                <asp:Button ID="InsertButton" runat="server" CommandName="Insert" Text="Insert" />
                <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" Text="Clear" />
            </td>
        </InsertItemTemplate>

        <ItemTemplate>
            <td runat="server" style="background-color: #FFFBD6; color: #333333;">Id:
                <asp:Label ID="IdLabel" runat="server" Text='<%# Eval("Id") %>' />
                <br />
                Name:
                <asp:Label ID="NameLabel" runat="server" Text='<%# Eval("Name") %>' />
                <br />
                <asp:Button ID="EditButton" runat="server" CommandName="Edit" Text="Edit" />
                <asp:Button ID="DeleteButton" runat="server" CommandName="Delete" Text="Delete" />
            </td>
        </ItemTemplate>

        <LayoutTemplate>
            <table runat="server" border="1" 
                    style="background-color: #FFFFFF; 
                           border-collapse: collapse;
                           border-color: #999999; 
                           border-style: none; 
                           border-width: 1px; 
                           font-family: Verdana, Arial, Helvetica, sans-serif;">
                <tr id="itemPlaceholderContainer" runat="server">
                    <td id="itemPlaceholder" runat="server"></td>
                </tr>
            </table>
            <div style="text-align: center; background-color: #FFCC66; font-family: Verdana, Arial, Helvetica, sans-serif; color: #333333;">
                <asp:DataPager ID="DataPager1" runat="server">
                    <Fields>
                        <asp:NextPreviousPagerField ButtonType="Button" ShowFirstPageButton="True" ShowLastPageButton="True" />
                    </Fields>
                </asp:DataPager>
            </div>
        </LayoutTemplate>

        <SelectedItemTemplate>
            <td runat="server" style="background-color: #FFCC66; font-weight: bold; color: #000080;">Id:
                <asp:Label ID="IdLabel" runat="server" Text='<%# Eval("Id") %>' />
                <br />
                Name:
                <asp:Label ID="NameLabel" runat="server" Text='<%# Eval("Name") %>' />
                <br />
                <asp:Button ID="EditButton" runat="server" CommandName="Edit" Text="Edit" />
                <asp:Button ID="DeleteButton" runat="server" CommandName="Delete" Text="Delete" />
            </td>
        </SelectedItemTemplate>
    </asp:ListView>

    <asp:SqlDataSource ID="SqlDataSource1" runat="server"
        ConnectionString="<%$ ConnectionStrings:TodoDbaseConnectionString %>"
        OldValuesParameterFormatString="original_{0}"
        SelectCommand="SELECT * FROM [Todoes]">
    </asp:SqlDataSource>

    <h3>Todos</h3>
    <asp:ListView ID="ListView1" runat="server"
        DataSourceID="SqlDataSourceTodo"
        DataKeyNames="Id"
        InsertItemPosition="LastItem" OnItemInserted="ListView1_ItemInserted">
        <AlternatingItemTemplate>
            <li style="background-color: #FFF8DC;">Id:
                <asp:Label ID="IdLabel" runat="server" Text='<%# Eval("Id") %>' />
                <br />
                Title:
                <asp:Label ID="TitleLabel" runat="server" Text='<%# Eval("Title") %>' />
                <br />
                Content:
                <asp:Label ID="ContentLabel" runat="server" Text='<%# Eval("Content") %>' />
                <br />
                LastModified:
                <asp:Label ID="LastModifiedLabel" runat="server" Text='<%# Eval("LastModified") %>' />
                <br />
                CategoryId:
                <asp:Label ID="CategoryIdLabel" runat="server" Text='<%# Eval("CategoryId") %>' />
                <br />
                <asp:Button ID="EditButton" runat="server" CommandName="Edit" Text="Edit" />
                <asp:Button ID="DeleteButton" runat="server" CommandName="Delete" Text="Delete" />
            </li>
        </AlternatingItemTemplate>
        
        <EditItemTemplate>
            <li style="background-color: #008A8C; color: #FFFFFF;">Id:
                <asp:Label ID="IdLabel1" runat="server" Text='<%# Eval("Id") %>' />
                <br />
                Title:
                <asp:TextBox ID="TitleTextBox" runat="server" Text='<%# Bind("Title") %>' />
                <br />
                Content:
                <asp:TextBox ID="ContentTextBox" runat="server" Text='<%# Bind("Content") %>' />
                <br />
                LastModified:
                <asp:TextBox ID="LastModifiedTextBox" runat="server" Text='<%# Bind("LastModified") %>' />
                <br />
                CategoryId:
                <asp:TextBox ID="CategoryIdTextBox" runat="server" Text='<%# Bind("CategoryId") %>' />
                <br />
                <asp:Button ID="UpdateButton" runat="server" CommandName="Update" Text="Update" />
                <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" Text="Cancel" />
            </li>
        </EditItemTemplate>
        
        <EmptyDataTemplate>
            No data was returned.
        </EmptyDataTemplate>
        
        <InsertItemTemplate>
            <li style="">Title:
                <asp:TextBox ID="TitleTextBox" runat="server" Text='<%# Bind("Title") %>' />
                <br />
                Content:
                <asp:TextBox ID="ContentTextBox" runat="server" Text='<%# Bind("Content") %>' />
                <br />
                CategoryId:
                <asp:TextBox ID="CategoryIdTextBox" runat="server" Text='<%# Bind("CategoryId") %>' />
                <br />
                <asp:Button ID="InsertButton" runat="server" CommandName="Insert" Text="Insert" />
                <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" Text="Clear" />
            </li>
        </InsertItemTemplate>
        
        <ItemSeparatorTemplate>
            <br />
        </ItemSeparatorTemplate>

        <ItemTemplate>
            <li style="background-color: #DCDCDC; color: #000000;">Id:
                <asp:Label ID="IdLabel" runat="server" Text='<%# Eval("Id") %>' />
                <br />
                Title:
                <asp:Label ID="TitleLabel" runat="server" Text='<%# Eval("Title") %>' />
                <br />
                Content:
                <asp:Label ID="ContentLabel" runat="server" Text='<%# Eval("Content") %>' />
                <br />
                LastModified:
                <asp:Label ID="LastModifiedLabel" runat="server" Text='<%# Eval("LastModified") %>' />
                <br />
                CategoryId:
                <asp:Label ID="CategoryIdLabel" runat="server" Text='<%# Eval("CategoryId") %>' />
                <br />
                <asp:Button ID="EditButton" runat="server" CommandName="Edit" Text="Edit" />
                <asp:Button ID="DeleteButton" runat="server" CommandName="Delete" Text="Delete" />
            </li>
        </ItemTemplate>
        <LayoutTemplate>
            <ul id="itemPlaceholderContainer" runat="server"
                    style="font-family: Verdana, Arial, Helvetica, sans-serif;">
                <li runat="server" id="itemPlaceholder" />
            </ul>
            <div style="text-align: center; background-color: #CCCCCC; font-family: Verdana, Arial, Helvetica, sans-serif; color: #000000;">
                <asp:DataPager ID="DataPager1" runat="server">
                    <Fields>
                        <asp:NextPreviousPagerField ButtonType="Button" ShowFirstPageButton="True" ShowLastPageButton="True" />
                    </Fields>
                </asp:DataPager>
            </div>
        </LayoutTemplate>

        <SelectedItemTemplate>
            <li style="background-color: #008A8C; font-weight: bold; color: #FFFFFF;">Id:
                <asp:Label ID="IdLabel" runat="server" Text='<%# Eval("Id") %>' />
                <br />
                Title:
                <asp:Label ID="TitleLabel" runat="server" Text='<%# Eval("Title") %>' />
                <br />
                Content:
                <asp:Label ID="ContentLabel" runat="server" Text='<%# Eval("Content") %>' />
                <br />
                LastModified:
                <asp:Label ID="LastModifiedLabel" runat="server" Text='<%# Eval("LastModified") %>' />
                <br />
                CategoryId:
                <asp:Label ID="CategoryIdLabel" runat="server" Text='<%# Eval("CategoryId") %>' />
                <br />
                <asp:Button ID="EditButton" runat="server" CommandName="Edit" Text="Edit" />
                <asp:Button ID="DeleteButton" runat="server" CommandName="Delete" Text="Delete" />
            </li>
        </SelectedItemTemplate>
    </asp:ListView>

    <asp:SqlDataSource ID="SqlDataSourceTodo" runat="server"
        ConnectionString="<%$ ConnectionStrings:TodoDbaseConnectionString2 %>"
        DeleteCommand="DELETE FROM [Todoes] WHERE [Id] = @Id"
        InsertCommand="SET @LastModified = GETDATE();INSERT INTO [Todoes] ([Title], [Content], [LastModified], [CategoryId]) VALUES (@Title, @Content, @LastModified, @CategoryId)"
        SelectCommand="SELECT * FROM [Todoes]"
        UpdateCommand="UPDATE [Todoes] SET [Title] = @Title, [Content] = @Content, [LastModified] = @LastModified, [CategoryId] = @CategoryId WHERE [Id] = @Id">
        <DeleteParameters>
            <asp:Parameter Name="Id" Type="Int32" />
        </DeleteParameters>
        <InsertParameters>
            <asp:Parameter Name="Title" Type="String" />
            <asp:Parameter Name="Content" Type="String" />
            <asp:Parameter Name="LastModified" Type="DateTime" />
            <asp:Parameter Name="CategoryId" Type="Int32" />
        </InsertParameters>
        <UpdateParameters>
            <asp:Parameter Name="Title" Type="String" />
            <asp:Parameter Name="Content" Type="String" />
            <asp:Parameter Name="LastModified" Type="DateTime" />
            <asp:Parameter Name="CategoryId" Type="Int32" />
            <asp:Parameter Name="Id" Type="Int32" />
        </UpdateParameters>
    </asp:SqlDataSource>
</asp:Content>
