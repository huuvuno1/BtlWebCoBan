using BtlWebForm.Entity;
using BtlWebForm.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BtlWebForm.Views.Common
{
    public partial class action : System.Web.UI.Page
    {
        UserService userService = new UserService();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session.Contents["user-login"] == null)
            {
                string action = Request.Form.Get("action");
                if (action.Equals("login"))
                {
                    CheckLogin();
                } 
                else if (action.Equals("register"))
                {
                    Register();
                }
            }
        }

        private void Register()
        {
            throw new NotImplementedException();
        }

        private void CheckLogin()
        {
            Server.MapPath("");
            string username = Request.Form.Get("username");
            string password = Request.Form.Get("password");
            if (username != null && password != null)
            {
                UserEntity user = userService.FindUserByUsername(username);
                if (user != null)
                {
                    if (user.Password.Equals(password))
                    {
                        Session.Add("user-login", user);
                        string redirect = user.Role == 1 ? "/admin" : "";
                        Response.Redirect(redirect);
                    }
                }
                Response.Redirect("/login");
            }
        }
    }
}