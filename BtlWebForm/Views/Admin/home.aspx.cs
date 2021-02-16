using BtlWebForm.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BtlWebForm.Views.Admin
{
    public partial class home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
                
            // làm đẹp url
            if (!Request.Url.AbsolutePath.Equals("/admin"))
                Response.Redirect("/admin");
        }
    }
}