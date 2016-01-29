<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Test.aspx.cs" Inherits="_03.WebAlbum.Test" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
    <link href="Content/StyleSheet.css" rel="stylesheet" />
    <script type="text/javascript">
        var styleToSelect;
        function onOk() {
            document.getElementById('Paragraph1').className = styleToSelect;
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
        <br />
        <asp:LinkButton ID="LinkButton1" runat="server">Please click to select an alternate text style.</asp:LinkButton><br />
        <br />
        <div>
            <p id="Paragraph1">
                <a href="http://joeon.net"><span style="color: #3366cc">Joe Stagner</span></a>,
      a member of the Microsoft product team, builds a CascadingDropDown sample application
      that demonstrates two fundamental benefits of AJAX-enabled web applications, namely
      web service integration and asynchronous page updates.
            </p>
            <asp:Panel ID="Panel1" runat="server" CssClass="modalPopup" Style="display: none" Width="233px">
                <p>Choose the style you would like:</p>
                <input id="RadioA" name="Radio" onclick="styleToSelect = 'sampleStyleA';" type="radio" />
                <label class="sampleStyleA" for="RadioA">Choose THIS Style.</label><br />
                <input id="RadioB" name="Radio" onclick="styleToSelect = 'sampleStyleB';" type="radio" />
                <label class="sampleStyleB" for="RadioB">Choose THIS Style.</label><br />
                <input id="RadioC" name="Radio" onclick="styleToSelect = 'sampleStyleC';" type="radio" />
                <label class="sampleStyleC" for="RadioC">Choose THIS Style.</label><br />
                <input id="RadioD" name="Radio" onclick="styleToSelect = 'sampleStyleD';" type="radio" />
                <label class="sampleStyleD" for="RadioD">Choose THIS Style.</label><br />
                <br />
                <div>
                    <asp:Button ID="OkButton" runat="server" Text="OK" />
                    <asp:Button ID="CancelButton" runat="server" Text="Cancel" />
                </div>
            </asp:Panel>
            <br />

            <ajaxToolkit:ModalPopupExtender ID="ModalPopupExtender1" runat="server"
                TargetControlID="LinkButton1"
                PopupControlID="Panel1"
                BackgroundCssClass="modalBackground"
                DropShadow="true"
                OkControlID="OkButton"
                OnOkScript="onOk()"
                CancelControlID="CancelButton" />
        </div>
    </form>
</body>
</html>
