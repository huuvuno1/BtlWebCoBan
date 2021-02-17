using System;

namespace BtlWebForm.Views.Common
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Nếu đã login thì không được vào trang này nữa
            if (Session.Contents["user-login"] != null)
                Response.Redirect("/");

            // Làm đẹp url nếu user cố tình vào trang domain.com/Views/Common/login.aspx
            if (!Request.Url.AbsolutePath.Equals("/login"))
                Response.Redirect("/login");
        }
    }
}