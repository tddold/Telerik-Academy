<%@ Page Title="Profile" 
    Language="C#" 
    MasterPageFile="~/Site.Master" 
    AutoEventWireup="true" 
    CodeBehind="Profile.aspx.cs" 
    Inherits="Profile_Page.Views.Profile" %>

<asp:Content ID="ProfileContent" ContentPlaceHolderID="MainContentPlaceHolder" runat="server">
     <img src="http://telerikacademy.com/Content/Images/DefaultAvatar/default_180x180.jpg" class="profile-img" alt="Ninja" width="150" height="150" />

    <ul class="personal-info">
        <li>Name: Pesho</li>
        <li>Age: 20</li>
        <li>Title: Ninja</li>
    </ul>
</asp:Content>
