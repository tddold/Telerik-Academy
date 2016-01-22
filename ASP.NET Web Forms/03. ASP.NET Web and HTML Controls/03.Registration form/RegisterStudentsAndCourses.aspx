<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegisterStudentsAndCourses.aspx.cs" Inherits="_03.Registration_form.RegisterStudentsAndCourses" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Register Students and Courses</title>
</head>
<body>
    <form id="mainForm" runat="server">
        
       

        <div runat="server" id="registerForm">
            First name: 
        <asp:TextBox ID="tbFirstName" runat="server"></asp:TextBox><br />
            <br />
            Last name: 
        <asp:TextBox ID="tbLastName" runat="server"></asp:TextBox><br />
            <br />
            Faculty number: 
        <asp:TextBox ID="tbFacultyNumber" runat="server"></asp:TextBox><br />
            <br />

            University: 
        <asp:DropDownList ID="universityDropDownList" runat="server">
            <asp:ListItem Text="First University" />
            <asp:ListItem Text="Second University" />
            <asp:ListItem Text="Third University" />
        </asp:DropDownList>
            <br />
            <br />

            Specialty: 
        <asp:DropDownList ID="specialtyDropDownList" runat="server">
            <asp:ListItem Text="First Specialty" />
            <asp:ListItem Text="Second Specialty" />
            <asp:ListItem Text="Third Specialty" />
        </asp:DropDownList>
            <br />
            <br />

            Courses:<br />
            <asp:ListBox ID="coursesListBox" runat="server">
                <asp:ListItem Text="First Courses" />
                <asp:ListItem Text="Second Courses" />
                <asp:ListItem Text="Third Courses" />
            </asp:ListBox>
            <br />
            <br />

            <asp:Button Text="Register" ID="btnRegidterButton" runat="server" OnClick="btnRegidterButton_Click" />
        </div>
        <div runat="server" id="registerInfo">

            <asp:Panel ID="Panel" runat="server"
            BackColor="gainsboro">
            Panel: Here is content...
            <br />
        </asp:Panel>
         <br /><br />
        </div>

         
    </form>
</body>
</html>
