using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace _03.Registration_form
{
    public partial class RegisterStudentsAndCourses : System.Web.UI.Page
    {
        TextBox name, facultyNumber, university, specialty, course;
        Label lblName, lblFN, lblUniversity, lblSpecialty, lblCourse;

        protected void Page_Load(object sender, EventArgs e)
        {
            lblName = new Label();
            lblName.Text = "Name: ";
            lblName.ID = "lblName";

            lblFN = new Label();
            lblFN.Text = "FN: ";
            lblFN.ID = "lblFN";

            lblUniversity = new Label();
            lblUniversity.Text = "University: ";
            lblUniversity.ID = "lblUniversity";

            lblSpecialty = new Label();
            lblSpecialty.Text = "Specialty: ";
            lblSpecialty.ID = "lblSpecialty";

            lblCourse = new Label();
            lblCourse.Text = "Course: ";
            lblCourse.ID = "lblCourse";


            name = new TextBox();
            name.Text = this.tbFirstName.Text + " " + this.tbLastName.Text;
            name.ID = "name";

            facultyNumber = new TextBox();
            facultyNumber.Text = this.tbFacultyNumber.Text;
            facultyNumber.ID = "facultyNumber";

            university = new TextBox();
            university.Text = this.universityDropDownList.SelectedValue;
            university.ID = "university";

            specialty = new TextBox();
            specialty.Text = this.specialtyDropDownList.SelectedValue;
            specialty.ID = "specialty";

            course = new TextBox();
            course.Text = this.coursesListBox.SelectedValue;
            course.ID = "course";



        }

        protected void btnRegidterButton_Click(object sender, EventArgs e)
        {
            this.registerForm.Visible = false;

            var titleHeader = new HtmlGenericControl("h1");
            titleHeader.InnerText =new string('-', 40);

            var nameHeader = new HtmlGenericControl("h1");
            nameHeader.InnerText = String.Format("Name: {0} {1}", this.tbFirstName.Text, this.tbLastName.Text);

            var facultyNumberParagrph = new HtmlGenericControl("p");
            facultyNumberParagrph.InnerText = String.Format("Faculty number: {0}", this.tbFacultyNumber.Text);

            var universityHeader = new HtmlGenericControl("h2");
            universityHeader.InnerText = String.Format("University: {0}", this.universityDropDownList.SelectedValue);

            var specialtyHeader = new HtmlGenericControl("h3");
            specialtyHeader.InnerText = String.Format("Specialty: {0}", this.specialtyDropDownList.SelectedValue);

            var courseHeader = new HtmlGenericControl("h4");
            courseHeader.InnerText = String.Format("Course: {0}", this.coursesListBox.SelectedValue);

            this.registerInfo.Controls.Add(titleHeader);
            this.registerInfo.Controls.Add(nameHeader);
            this.registerInfo.Controls.Add(facultyNumberParagrph);
            this.registerInfo.Controls.Add(universityHeader);
            this.registerInfo.Controls.Add(specialtyHeader);
            this.registerInfo.Controls.Add(courseHeader);

            this.Panel.Controls.Add(lblName);
            this.Panel.Controls.Add(name);
            this.Panel.Controls.Add(new LiteralControl("<br>"));
            this.Panel.Controls.Add(lblFN);
            this.Panel.Controls.Add(facultyNumber);
            this.Panel.Controls.Add(new LiteralControl("<br>"));
            this.Panel.Controls.Add(lblUniversity);
            this.Panel.Controls.Add(university);
            this.Panel.Controls.Add(new LiteralControl("<br>"));
            this.Panel.Controls.Add(lblSpecialty);
            this.Panel.Controls.Add(specialty);
            this.Panel.Controls.Add(new LiteralControl("<br>"));
            this.Panel.Controls.Add(lblCourse);
            this.Panel.Controls.Add(course);
            this.Panel.Controls.Add(new LiteralControl("<br>"));
        }
    }
}