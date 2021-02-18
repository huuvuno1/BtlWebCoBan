using BtlWebForm.Entity;
using System;

namespace BtlWebForm
{
    public partial class WebAdmin : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Đã phân quyền rồi nên vào đây chỉ có thể là admin
            UserEntity user = (UserEntity)Session.Contents["user-login"];
            if (user != null)
                name_admin.InnerText = user.Fullname;
        }
    }
}