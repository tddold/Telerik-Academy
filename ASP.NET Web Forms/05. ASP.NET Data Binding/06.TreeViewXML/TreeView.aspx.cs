namespace TreeViewXML
{
    using System;
    using System.Web.UI.WebControls;


    public partial class TreeView : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ShowResult_Click(object sender, EventArgs e)
        {
            foreach (TreeNode node in this.TreeViewForumRSS.CheckedNodes)
            {
                this.CheckedNodeInfo.Text =this.CheckedNodeInfo.Text + node.Value + "<br />";
            }
        }
    }
}