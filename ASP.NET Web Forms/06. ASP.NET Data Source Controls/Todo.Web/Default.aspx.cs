namespace Todo.Web
{
    using System;
    using System.Data.SqlClient;
    using System.Web.UI;

    public partial class _Default : Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=.\SqlExpress;Initial Catalog=TodoDbase;Integrated Security=True;MultipleActiveResultSets=True;Application Name=EntityFramework");
        SqlCommand cmd;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ListView1_ItemInserted(object sender, System.Web.UI.WebControls.ListViewInsertedEventArgs e)
        {

        }
    }
}