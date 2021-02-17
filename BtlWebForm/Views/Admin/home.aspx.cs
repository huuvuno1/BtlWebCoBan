using BtlWebForm.Entity;
using System;
namespace BtlWebForm.Views.Admin
{
    public partial class home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            UserEntity user = (UserEntity)Session.Contents["user-login"];
            if (user != null && user.Role == Constant.ROLE_ADMIN)
            {
                // làm đẹp url
                if (!Request.Url.AbsolutePath.Equals("/admin"))
                    Response.Redirect("/admin");
            }
            else
                Response.Redirect("/access-denied");
               
        }
    }
}