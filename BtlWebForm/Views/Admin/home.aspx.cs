using BtlWebForm.Entity;
using System;
namespace BtlWebForm.Views.Admin
{
    public partial class home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            UserEntity user = (UserEntity)Session.Contents["user-login"];

            // Phân quyền
            if (user != null)
            {
                // làm đẹp url nếu người dùng truy cập vào /Views/Admin/home.aspx
                if (!Request.Url.AbsolutePath.Equals("/admin"))
                    Response.Redirect("/admin");

                if (user.Role == Constant.ROLE_USER)
                    Response.Redirect("/access-denied");
            }
            else
                Response.Redirect("/login");
               
        }
    }
}