﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="SubstringModule.Web.Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Substring Module Client Web Application</title>
</head>
<body>
    <form id="formSubstringModuleConsumer" runat="server">
        <div>
            Text:<asp:TextBox ID="TextBox" runat="server" />
            <br />
            <br />
            Substring:
            <asp:TextBox ID="SubStringTextBox" runat="server" />
            <br />
            <br />
            <asp:Button ID="ButtonSubMit" runat="server" Text="Get number of substrings" OnClick="OnGetNumberOfSubstringButtonClick" />
            <br />
            <br />
        </div>
        <asp:Label ID="ResultLabel" runat="server"></asp:Label>
    </form>
</body>
</html>
