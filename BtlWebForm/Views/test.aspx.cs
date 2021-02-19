using BtlWebForm.Entity;
using BtlWebForm.Repository;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BtlWebForm.Views
{
    public partial class test : System.Web.UI.Page
    {
        FileIO file = new FileIO();

        protected void Page_Load(object sender, EventArgs e)
        {
            string data = file.ReadFileJson((Constant.DATA_CARTS));
            List<CartEntity> carts = JsonConvert.DeserializeObject<List<CartEntity>>(data);
            foreach (CartEntity cart in carts)
            {
                Response.Write(cart);
            }    
        }
    }
}