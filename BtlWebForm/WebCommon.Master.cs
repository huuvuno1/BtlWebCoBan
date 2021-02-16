using BtlWebForm.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BtlWebForm
{
    public partial class WebCommon : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            UserEntity user = (UserEntity)Session.Contents["user-login"];
            if (user != null)
                fullname.InnerText = user.Fullname;
        }
    }
}