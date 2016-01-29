<%@ Page Title="Home Page" Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="FileSystem.Web._Default" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <title><%: Page.Title %> - My ASP.NET Application</title>
    <link href="Content/kendo/2014.1.318/kendo.common.min.css" rel="stylesheet" />
    <link href="Content/kendo/2014.1.318/kendo.black.min.css" rel="stylesheet" />
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <script src="Scripts/kendo/2014.1.318/jquery.min.js"></script>
    <script src="Scripts/kendo/2014.1.318/kendo.web.min.js"></script>
</head>

<body>
    <div class="navbar navbar-inverse navbar-fixed-top">
        <div class="container">
            <div class="navbar-header">
                <button type="button" class="navbar-toggle" data-toggle="collapse" data-target=".navbar-collapse">
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                </button>
                <a class="navbar-brand" runat="server" href="~/">File Upload</a>
            </div>
            <div class="navbar-collapse collapse">
                <ul class="nav navbar-nav">
                    <li><a runat="server" href="~/">Home</a></li>
                </ul>
            </div>
        </div>
    </div>

    <div class="jumbotron">
        <h1>File Upload</h1>
        <p class="alert alert-warning">You can find sample zip files in Sample Data Folder</p>
    </div>

    <section>
        <input type="file" name="uploaded" id="uploaded" runat="server" />
        <a href="~/" runat="server">Click to see content</a>
        <asp:Repeater ID="RepeaterContent" runat="server"
            ItemType="FileSystem.Models.FileContent">
            <HeaderTemplate>
                <div class="panel panel-primary col-md-6 col-md-offset-3">
                    <div class="panel-heading">
                        <h3 class="panel-title">Uploaded text</h3>
                    </div>
                    <div class="panel-body">
                        <ul class="list-group">
            </HeaderTemplate>

            <ItemTemplate>
                <li class="list-group-item"><%#: Item.Content %></li>
            </ItemTemplate>

            <FooterTemplate>
                </ul>
                    </div>
                </div>
            </FooterTemplate>
        </asp:Repeater>
    </section>

    <script>
        $(document).ready(function () {
            $("#uploaded").kendoUpload({
                async: {
                    saveUrl: "Upload",
                    autoUpload: false
                }
            });
        });
    </script>
</body>
</html>
