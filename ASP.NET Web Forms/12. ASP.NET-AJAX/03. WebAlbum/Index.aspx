<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="_03.WebAlbum.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Web album</title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <script src="scripts/bootstrap.min.js"></script>
    <script src="scripts/jquery-1.9.1.min.js"></script>
     <script type="text/javascript">
        function LoadDiv(url) {
            $("#Image1").attr("src", url);
            return true;
        }
    </script>
</head>
<body>

    <form id="formMain" runat="server">
        <asp:ScriptManager runat="server" ID="ScriptManager" />

        <ajaxToolkit:SlideShowExtender ID="SlideShowExtender1" runat="server"
            BehaviorID="SSBehaviorID"
            TargetControlID="Image"
            SlideShowServiceMethod="GetSlides"
            AutoPlay="true"
            ImageDescriptionLabelID="imageDescription"
            NextButtonID="nextButton"
            PreviousButtonID="prevButton"
            PlayButtonID="playButton"
            PlayButtonText="Play"
            StopButtonText="Stop"
            Loop="true"></ajaxToolkit:SlideShowExtender>

        <div class="well col-md-6 col-md-offset-3">
            <asp:ImageButton ID="Image" CssClass="img-thumbnail" runat="server" Height="400px" Width="400px" OnClientClick="return LoadDiv(this.src);" />
            <asp:Label ID="imageTitle" runat="server" Text=""></asp:Label><br />
            <strong>
                <asp:Label ID="imageDescription" runat="server" Text=""></asp:Label>

            </strong>
            <br />
            <asp:Button ID="prevButton" runat="server" Text="Previous" />
            <asp:Button ID="playButton" runat="server" Text="" />
            <asp:Button ID="nextButton" runat="server" Text="Next" />
        </div>

        <div>
            <asp:Panel ID="Panel1" runat="server" CssClass="modalPopup" Style="display: none" Width="233px">
                <asp:Image ID="Image1" runat="server"
                    Height="500px" Width="500px" />
                <div>
                    <asp:Button ID="OkButton" runat="server" Text="OK" />
                    <asp:Button ID="CancelButton" runat="server" Text="Cancel" />
                </div>
            </asp:Panel>

            <ajaxToolkit:ModalPopupExtender ID="ModalPopupExtender1" runat="server"
                TargetControlID="Image"
                PopupControlID="Panel1"
                BackgroundCssClass="modalBackground"
                DropShadow="true"
                OkControlID="OkButton"
                CancelControlID="CancelButton" X="0" Y="0" />
        </div>

    </form>
   
</body>
</html>
