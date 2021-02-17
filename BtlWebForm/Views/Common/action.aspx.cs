using BtlWebForm.Entity;
using BtlWebForm.Repository;
using System;

namespace BtlWebForm.Views.Common
{
    public partial class action : System.Web.UI.Page
    {
        UserRepository userRepository = new UserRepository();

        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (Session.Contents["user-login"] == null)
            {
                string action = Request.Form.Get("action");
                if ("login".Equals(action))
                {
                    CheckLogin();
                } 
                else if ("register".Equals(action))
                {
                    Register();
                }
            }
            else
            {
                // them xu ly tham só = logout thì mới được logout, đây đang làm vội
                Session.Abandon();
                Response.Redirect("/login");
            }
        }

        private void Register()
        {
            throw new NotImplementedException();
        }

        private void CheckLogin()
        {
            string username = Request.Form.Get("username");
            string password = Request.Form.Get("password");
            if (username != null && password != null)
            {
                UserEntity user = userRepository.FindUserByUsername(username);
                if (user != null)
                {
                    if (user.Password.Equals(password))
                    {
                        Session.Add("user-login", user);
                        string redirect = user.Role == Constant.ROLE_ADMIN ? "/admin" : "/";
                        Response.Redirect(redirect);
                    }
                }
                Response.Redirect("/login");
            }
        }
    }
}