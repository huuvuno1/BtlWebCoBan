using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BtlWebForm.Views.Common
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            /*
                - Làm đẹp url nếu user cố tình vào bằng domain.com/Views/Common/login.aspx
                - Tránh vào url trên dẫn tới action trong form bị sai
            */
            //Response.Redirect("/login");
        }
    }
}