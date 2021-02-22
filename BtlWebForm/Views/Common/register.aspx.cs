using BtlWebForm.Entity;
using BtlWebForm.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BtlWebForm.Views.Common
{
    public partial class register : System.Web.UI.Page
    {
        UserRepository userRepository = new UserRepository();
        protected void Page_Load(object sender, EventArgs e)
        {    
            // chỉnh lại path nếu run từ trang này
            if (!Request.Url.AbsolutePath.Equals("/register"))
                Response.Redirect("/register");

            // xem đăng nhập chưa, đăng nhập rồi thì không được vào đây
            if (Session.Contents[Constant.USER_SESSION] != null)
                Response.Redirect("/");
            else
            {
                // kiểm tra xem có phải gủi dữ liệu lên để đăng ký ko
                if (Request.Form.Get("username") != null)
                    Register();
            }
        }

        private void Register()
        {
            string username = Request.Form.Get("username");
            string password = Request.Form.Get("password");
            string fullname = Request.Form.Get("fullname");
            string phonenumber = Request.Form.Get("phonenumber");

            // validate sau
            if ( "".Equals(fullname) || "".Equals(password) || "".Equals(phonenumber) || "".Equals(username))
            {
                fullname_warn.InnerText = username_warn.InnerText = password_warn.InnerText =
                phonenumber_warn.InnerText = "* Trường này không được để trống !";
            }
            else
                if (username != null && userRepository.FindUserByUsername(username) == null)
                {
                    UserEntity user = new UserEntity();
                    user.ID = userRepository.FindAllUser().Count + 1; // id mới bằng số lượng id cũ + 1
                    user.Username = username;
                    user.Password = password; // phạm vi bài đơn giản nên không mã hóa password
                    user.Fullname = fullname;
                    user.PhoneNumber = phonenumber;
                    user.Role = Constant.ROLE_USER;

                
                    // tam save mai lam
                    if (userRepository.SaveUser(user))
                    {
                        Response.Redirect("/login?msg=register-success");
                    }

                
                }
        }
    }
}