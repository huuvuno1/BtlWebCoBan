using BtlWebForm.Entity;
using System;

namespace BtlWebForm
{
    public partial class WebCommon : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            UserEntity user = (UserEntity)Session.Contents[Constant.USER_SESSION];
            if (user != null)
            {
                fullname.InnerText = user.Fullname;
                logout.InnerText = "Logout";
                string link = "/";
                if (user.Role == Constant.ROLE_ADMIN)
                    link = "/admin";

                LINK.Attributes.Add("href", link);
                LINK1.Attributes.Add("href", link);
            }
            OrderEntity orderCurent = (OrderEntity)Session.Contents[Constant.ORDER_SESSION];
            if (orderCurent != null)
                number_oder.InnerText = orderCurent.ListProduct.Count.ToString();
        }
    }
}