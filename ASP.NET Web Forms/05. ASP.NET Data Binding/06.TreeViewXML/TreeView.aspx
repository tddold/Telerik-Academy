<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TreeView.aspx.cs" Inherits="TreeViewXML.TreeView" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>TreeViewXML</title>
</head>
<body>
    <form id="MainForm" runat="server">
    <asp:XmlDataSource ID="XmlForumFeed" runat="server" DataFile="~/App_Data/questions.xml"></asp:XmlDataSource>
        <asp:TreeView ID="TreeViewForumRSS" runat="server" DataSourceID="XmlForumFeed" ShowCheckBoxes="Leaf" ImageSet="Arrows">
            <DataBindings>
                <asp:TreeNodeBinding DataMember="Catalog" Text="Catalog" />
            </DataBindings>
            <HoverNodeStyle Font-Underline="true" ForeColor="#5555DD" />
            <NodeStyle Font-Names="Verdana" Font-Size="10px" ForeColor="Black" HorizontalPadding="5px" NodeSpacing="0px" VerticalPadding="0px" />
            <ParentNodeStyle Font-Bold="false" />
            <SelectedNodeStyle Font-Underline="true" ForeColor="#5555DD" HorizontalPadding="0px" VerticalPadding="0px" />
        </asp:TreeView>
        <br />
        <asp:Button ID="ShowResult" runat="server" Text="Show Result" OnClick="ShowResult_Click" />
        <br />
        <br />
        <asp:Literal ID="CheckedNodeInfo" runat="server" Mode="Encode"></asp:Literal>
    </form>
</body>
</html>
