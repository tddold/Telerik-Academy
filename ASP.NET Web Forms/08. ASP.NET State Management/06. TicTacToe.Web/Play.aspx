<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Play.aspx.cs" Inherits="_06.TicTacToe.Web.Play" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Button ID="ButtonTopLeft" runat="server" Text="-" OnClick="ButtonTopLeft_Click" />
    <asp:Button ID="ButtonTopCenter" runat="server" Text="-" OnClick="ButtonTopCenter_Click" />
    <asp:Button ID="ButtonTopRight" runat="server" Text="-" OnClick="ButtonTopRight_Click" />
    <br />
    <asp:Button ID="ButtonMiddleLeft" runat="server" Text="-" OnClick="ButtonMiddleLeft_Click" />
    <asp:Button ID="ButtonMiddleCenter" runat="server" Text="-" OnClick="ButtonMiddleCenter_Click" />
    <asp:Button ID="ButtonMiddleRight" runat="server" Text="-" OnClick="ButtonMiddleRight_Click" />
    <br />
    <asp:Button ID="ButtonBottomLeft" runat="server" Text="-" OnClick="ButtonBottomLeft_Click" />
    <asp:Button ID="ButtonBottomCenter" runat="server" Text="-" OnClick="ButtonBottomCenter_Click" />
    <asp:Button ID="ButtonBottomRight" runat="server" Text="-" OnClick="ButtonBottomRight_Click" />
    <br />
    <br />
    <asp:Label ID="result" runat="server" Text=""></asp:Label>    
   
</asp:Content>
