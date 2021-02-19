using BtlWebForm.Entity;
using System;

namespace BtlWebForm
{
    public partial class WebCommon : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            UserEntity user = (UserEntity)Session.Contents["user-login"];
            if (user != null)
            {
                fullname.InnerText = user.Fullname;
                logout.InnerText = "Logout";
            }
        }
    }
}