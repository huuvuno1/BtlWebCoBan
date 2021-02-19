using BtlWebForm.Entity;
using BtlWebForm.Repository;
using System;
namespace BtlWebForm.Views.Common
{
    public partial class home : System.Web.UI.Page
    {
        ProductRepository productRepository = new ProductRepository();
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (!Request.Url.AbsolutePath.Equals("/"))
                Response.Redirect("/");  
        }
    }
}