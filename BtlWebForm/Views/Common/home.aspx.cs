using System;
namespace BtlWebForm.Views.Common
{
    public partial class home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (!Request.Url.AbsolutePath.Equals("/"))
                Response.Redirect("/");
        }
    }
}