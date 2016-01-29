<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Search.aspx.cs" Inherits="Mobile.Search" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Search</title>
</head>
<body>
    <form id="MainForm" runat="server">
        Producer:
        <asp:DropDownList ID="ProducersDropDownList" runat="server"
            AutoPostBack="True"
            DataTextField="Name"
            OnSelectedIndexChanged="OnProducerSelectedIndexChangrd">
        </asp:DropDownList>

        <br />
        <br />

        Model:
        <asp:DropDownList ID="ProducerModelsDropDownList" runat="server"
            ItemType="Mobile.Producer">
        </asp:DropDownList>

        <br />
        <br />

        Extras:
        <asp:CheckBoxList ID="ExtrasCheckBoxList" runat="server"
            DataTextField="Name">
        </asp:CheckBoxList>

        <br />
        <br />

        Engine:
        <asp:RadioButtonList ID="EnginesRadioButtonList" runat="server" RepeatDirection="Horizontal">
        </asp:RadioButtonList>

        <br />

        <asp:Button Text="Search" ID="btnButton" runat="server" OnClick="OnSearchButtonClicked"/>

        <br />

        <asp:Label ID="SummaryContainer" runat="server" Visible="false"></asp:Label>
    </form>
</body>
</html>
