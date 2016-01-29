namespace _03.Cookies
{
    using System;
    using System.Web;

    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonLogin_Click(object sender, EventArgs e)
        {
            var user = this.TextBoxUser.Text;

            HttpCookie cookie = new HttpCookie("UserName", user.ToString());
            cookie.Expires = DateTime.Now.AddMinutes(1);

            Response.Cookies.Add(cookie);
        }

        protected void Page_PreRender(object sender, EventArgs e)
        {
            HttpCookie cookie = Request.Cookies["UserName"];
            if (cookie != null)
            {
                Response.Redirect("Home.aspx");
            }
        }
    }
}