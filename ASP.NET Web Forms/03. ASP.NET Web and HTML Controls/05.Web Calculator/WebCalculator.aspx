<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebCalculator.aspx.cs" Inherits="_05.Web_Calculator.WebCalculator" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Web Calculator</title>
    <link rel="stylesheet" type="text/css" href="Content/bootstrap.css" />
    <link href="Content/site.css" rel="stylesheet" />
</head>
<body>
    <form id="mainForm" runat="server">
        <div class="row">
            <h1>Calculator</h1>
            <div class="col-md-2 well">
                <div class="row">
                    <div class="col-md-12">
                        <asp:TextBox ID="tbNumber" runat="server" CssClass="col-md-12 text-right tb" ></asp:TextBox>
                    </div>
                    <input type="text" runat="server" name="firstValue" id="firstValue" hidden="hidden" />
                    <input type="text" runat="server" name="lastOperand" id="lastOperand" hidden="hidden" />
                </div>

                <div class="btn-toolbar  text-center">
                    <div class="btn-group  text-center">

                        <asp:Button ID="Button1" runat="server" Text="1" OnClick="Button1_Click" CssClass="btn btn-default" />

                        <asp:Button ID="Button2" runat="server" Text="2" OnClick="Button2_Click" CssClass="btn btn-default input-text-box" />

                        <asp:Button ID="Button3" runat="server" Text="3" OnClick="Button3_Click" CssClass="btn btn-default" />

                        <asp:Button ID="ButtonPlus" runat="server" Text="+" OnClick="ButtonPlus_Click" CssClass="btn btn-default" />

                    </div>
                </div>

                <div class="btn-toolbar">
                    <div class="btn-group">
                        <asp:Button ID="Button4" runat="server" Text="4" OnClick="Button4_Click" CssClass="btn btn-default" />

                        <asp:Button ID="Button5" runat="server" Text="5" OnClick="Button5_Click" CssClass="btn btn-default" />

                        <asp:Button ID="Button6" runat="server" Text="6" OnClick="Button6_Click" CssClass="btn btn-default" />

                        <asp:Button ID="ButtonMinus" runat="server" Text="-" OnClick="ButtonMinus_Click" CssClass="btn btn-default" />
                    </div>
                </div>

                <div class="btn-toolbar">
                    <div class="btn-group">
                        <asp:Button ID="Button7" runat="server" Text="7" OnClick="Button6_Click" CssClass="btn btn-default" />

                        <asp:Button ID="Button8" runat="server" Text="8" OnClick="Button8_Click" CssClass="btn btn-default" />

                        <asp:Button ID="Button9" runat="server" Text="9" OnClick="Button9_Click" CssClass="btn btn-default" />

                        <asp:Button ID="ButtonMultiply" runat="server" Text="x" OnClick="ButtonMultiply_Click" CssClass="btn btn-default" />
                    </div>
                </div>

                <div class="btn-toolbar">
                    <div class="btn-group">
                        <asp:Button ID="ButtonClear" runat="server" Text="Clear" OnClick="ButtonClear_Click" CssClass="btn btn-default" />

                        <asp:Button ID="Button0" runat="server" Text="0" OnClick="Button0_Click" CssClass="btn btn-default" />

                        <asp:Button ID="ButtonDivide" runat="server" Text="/" OnClick="ButtonDivide_Click" CssClass="btn btn-default" />

                        <asp:Button ID="ButtonSquareRoot" runat="server" Text="√" OnClick="ButtonSquareRoot_Click" CssClass="btn btn-default" />
                    </div>
                </div>

                <div class="row">
                    <div class="col-md-8">
                        <asp:Button ID="ButtonEqual" runat="server" Text="=" OnClick="ButtonEqual_Click" CssClass="btn btn-group-lg" />
                    </div>
                </div>

            </div>
        </div>
    </form>


    <script src="scripts/jquery-1.9.1.min.js"></script>
    <script src="scripts/bootstrap.min.js"></script>
</body>
</html>
