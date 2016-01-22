<%@ Page Title="Home" 
    Language="C#" 
    MasterPageFile="~/Site.Master" 
    AutoEventWireup="true" 
    CodeBehind="Home.aspx.cs" 
    Inherits="_02.International_Company.Views.Home" %>


<asp:Content ID="ContentPage" ContentPlaceHolderID="PageContentPlaceHolder" runat="server">
    <asp:HyperLink runat="server" NavigateUrl="~/Views/Bulgaria/Home.aspx" Text="Bulgaria" CssClass="bg-icon"/>
    <asp:HyperLink runat="server" NavigateUrl="~/Views/England/Home.aspx" Text="England" CssClass="uk-icon"/>
</asp:Content>
