<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Tweet.aspx.cs" Inherits="TweetApi.Tweet" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Tweet</title>
</head>
<body>
    <form id="MainForm" runat="server">
    <asp:GridView ID="GridView1" runat="server" DataSourceID="ObjectDataSourceTweet">
            <Columns>
                <asp:BoundField />
            </Columns>
        </asp:GridView>
        <asp:ObjectDataSource ID="ObjectDataSourceTweet" runat="server" SelectMethod="GetAllFiles" TypeName="TweetApi.TweeterApi"></asp:ObjectDataSource>
    </form>
</body>
</html>
