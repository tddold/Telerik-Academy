namespace _03.Page_Life_Cycle
{
    using System;
    using System.Web.UI;

    public partial class index : Page
    {
        protected void Page_PreInit(object sender, EventArgs e)
        {
            this.Response.Write("Page_PreInit invoke" + "<br/>");
        }

        protected void Page_Init(object sender, EventArgs e)
        {
            this.Response.Write("Page_Init invoke" + "<br/>");
        }

        protected void Page_InitComplete(object sender, EventArgs e)
        {
            this.Response.Write("Page_InitComplete invoke" + "<br/>");
        }

        protected void Page_PreLoad(object sender, EventArgs e)
        {
            this.Response.Write("Page_PreLoad invoke" + "<br/>");
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            this.Response.Write("Page_Load invoke" + "<br/>");
        }

        protected void Page_LoadComplete(object sender, EventArgs e)
        {
            this.Response.Write("Page_LoadComplete invoke" + "<br/>");
        }

        protected void Page_PreRender(object sender, EventArgs e)
        {
            this.Response.Write("Page_PreRender invoked" + "<br/>");
        }

        protected void Page_SaveStateComplete(object sender, EventArgs e)
        {
            this.Response.Write("Page_SaveStateComplete invoked" + "<br/>");
        }

        protected void Page_Render(object sender, EventArgs e)
        {
            this.Response.Write("Page_Render invoked" + "<br/>");
        }

        protected void Page_PreRenderComplete(object sender, EventArgs e)
        {
            this.Response.Write("Page_PreRenderComplete invoked" + "<br/>");
        }

        protected void Page_Unload(object sender, EventArgs e)
        {
            // this.Response.Write("Page_Unload invoked" + "<br/>");
        }

        protected void btnOnButton_Init(object sender, EventArgs e)
        {
            this.Response.Write("btnOnButton_Init invoked" + "<br/>");
        }

        protected void btnOnButton_Load(object sender, EventArgs e)
        {
            this.Response.Write("btnOnButton_Load invoked" + "<br/>");
        }

        protected void btnOnButton_Click(object sender, EventArgs e)
        {
            this.Response.Write("btnOnButton_Click invoked" + "<br/>");
        }

        protected void btnOnButton_PreRender(object sender, EventArgs e)
        {
            this.Response.Write("btnOnButton_PreRender invoked" + "<br/>");
        }
    }
}