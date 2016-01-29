<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ValidationControls._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <fieldset>
        <legend>Register Form</legend>
        <asp:ValidationSummary runat="server" CssClass="text-danger alert alert-danger" />
        <asp:Label ID="LabelMessage" runat="server" CssClass="alert alert-success" Visible="false"></asp:Label>
        <div class="form-group">
            <label class="col-lg-2 control-label" for="TextBoxUsername">Username</label>

            <div class="col-lg-10">
                <asp:TextBox ID="TextBoxUsername" runat="server" type="text" class="form-control" placeholder="Username"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidatorUsername" runat="server" Display="Dynamic" ControlToValidate="TextBoxUsername" CssClass="text-danger" ErrorMessage="The username name field is required."></asp:RequiredFieldValidator>
            </div>
        </div>
        <div class="form-group">
            <label class="col-lg-2 control-label" for="TextBoxFirstName">First Name</label>
            <div class="col-lg-10">
                <asp:TextBox ID="TextBoxFirstName" runat="server" type="text" class="form-control" placeholder="Firs Name"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidatorFirsName" runat="server" Display="Dynamic" ControlToValidate="TextBoxFirstName" CssClass="text-danger" ErrorMessage="The first name field is required."></asp:RequiredFieldValidator>
            </div>
        </div>
        <div class="form-group">
            <label class="col-lg-2 control-label" for="TextBoxLastName">Last Name</label>
            <div class="col-lg-10">
                <asp:TextBox ID="TextBoxLastName" runat="server" type="text" class="form-control" placeholder="Last Name"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidatorLastName" runat="server" Display="Dynamic" ControlToValidate="TextBoxLastName" CssClass="text-danger" ErrorMessage="The last name field is required."></asp:RequiredFieldValidator>
            </div>
        </div>
        <div class="form-group">
            <label class="col-lg-2 control-label" for="TextBoxAge">Age</label>
            <div class="col-lg-10">
                <asp:TextBox ID="TextBoxAge" runat="server" type="number" class="form-control" placeholder="30"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidatorAge" runat="server" Display="Dynamic" ControlToValidate="TextBoxAge" CssClass="text-danger" ErrorMessage="The age field is required."></asp:RequiredFieldValidator>
                <asp:CompareValidator ID="CompareValidatorAge18" runat="server" Display="Dynamic" ControlToValidate="TextBoxAge" ValueToCompare="18" Type="Integer" Operator="GreaterThanEqual" CssClass="text-danger" ErrorMessage="Age value must be greater or equal than 18"></asp:CompareValidator>
                <asp:CompareValidator ID="CompareValidatorAge81" runat="server" Display="Dynamic" ControlToValidate="TextBoxAge" ValueToCompare="81" Type="Integer" Operator="LessThanEqual" CssClass="text-danger" ErrorMessage="Age value must be less or equal than 81"></asp:CompareValidator>
            </div>
        </div>
        <div class="form-group">
            <label class="col-lg-2 control-label" for="TextBoxEmail">Email</label>
            <div class="col-lg-10">
                <asp:TextBox ID="TextBoxEmail" runat="server" type="email" class="form-control" placeholder="sample@mail.com"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidatorEmail" runat="server" Display="Dynamic" ControlToValidate="TextBoxEmail" CssClass="text-danger" ErrorMessage="The email field is required."></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionValidatorEmail" runat="server" Display="Dynamic" ControlToValidate="TextBoxEmail" ValidationExpression="\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" CssClass="text-danger" ErrorMessage="Invalid Email Format"></asp:RegularExpressionValidator>
            </div>
        </div>
        <div class="form-group">
            <label class="col-lg-2 control-label" for="TextBoxAddress">Address</label>
            <div class="col-lg-10">
                <asp:TextBox ID="TextBoxAddress" runat="server" type="text" class="form-control" placeholder="bul. Bulgaria 11"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidatorAddress" runat="server" Display="Dynamic" ControlToValidate="TextBoxAddress" CssClass="text-danger" ErrorMessage="The address field is required."></asp:RequiredFieldValidator>
            </div>
        </div>
        <div class="form-group">
            <label class="col-lg-2 control-lable" for="TextBoxPhone">Phone number</label>
            <div class="col-lg-10">
                <asp:TextBox ID="TextBoxPhone" runat="server" type="text" class="form-control" placeholder="0881234567"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidatorPhone" runat="server" Display="Dynamic" ControlToValidate="TextBoxPhone" CssClass="text-danger" ErrorMessage="The phone number field is required."></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionValidatorPhone" runat="server" Display="Dynamic" ControlToValidate="TextBoxPhone" ValidationExpression="08[7-9][0-9]{7}" CssClass="text-danger" ErrorMessage="Invalid Phone number format"></asp:RegularExpressionValidator>
            </div>
        </div>
        <div class="form-group">
            <label class="col-lg-2 control-label" for="TextBoxPassword">Password</label>
            <div class="col-lg-10">
                <asp:TextBox ID="TextBoxPassword" runat="server" type="password" class="form-control" TextMode="Password" placeholder="Password"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidatorPassword" runat="server" Display="Dynamic" ControlToValidate="TextBoxPassword" CssClass="text-danger" ErrorMessage="The password field is required."></asp:RequiredFieldValidator>
            </div>
        </div>
        <div class="form-group">
            <label class="col-lg-2 control-label" for="TextBoxConfirmPassword">Confirm Password</label>
            <div class="col-lg-10">
                <asp:TextBox ID="TextBoxConfirmPassword" runat="server" type="password" class="form-control" placeholder="Confirm Password"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidatorConfirmPassword" runat="server" Display="Dynamic" ControlToValidate="TextBoxConfirmPassword" CssClass="text-danger" ErrorMessage="The password field is required."></asp:RequiredFieldValidator>
                <asp:CompareValidator ID="CompareValidatorConfirmPassword" runat="server" Display="Dynamic" ControlToCompare="TextBoxPassword" ControlToValidate="TextBoxConfirmPassword" CssClass="text-danger" ErrorMessage="The password and confirmation password do not match."></asp:CompareValidator>
            </div>
        </div>
        <div class="form-group">
            <div class="col-lg-10 col-lg-offset-2">
                <button class="btn btn-default">Cancel</button>
                <asp:Button ID="ButtonSubmit" runat="server" type="submit" class="btn btn-primary" Text="Register" OnClick="ButtonSubmit_Click" />
            </div>
        </div>
    </fieldset>

</asp:Content>
