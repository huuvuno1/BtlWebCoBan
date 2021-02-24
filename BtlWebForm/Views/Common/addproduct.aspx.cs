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
    public partial class addproduct : System.Web.UI.Page
    {
        ProductRepository productRepository = new ProductRepository();
        protected void Page_Load(object sender, EventArgs e)
        {
            string name_pro = Request.Form.Get("name_pro");
            string price_pro = Request.Form.Get("price_pro");
            string quantity_pro = Request.Form.Get("quantity_pro");
            string sale_pro = Request.Form.Get("sale_pro");
            string info_pro = Request.Form.Get("info_pro");
            string url_pro = Request.Form.Get("url_pro");
            string thuong_hieu = Request.Form.Get("thuong_hieu");

            List<string> listimg = new List<string>();
            // đọc list file
            var file = Request.Files;
            for (int i = 0; i < file.AllKeys.Length; i++)
            {
                string filename = "/static/img/product/" + file[i].FileName;
                file[i].SaveAs(MapPath(filename));
                listimg.Add(filename);
            }

            ProductEntity product = new ProductEntity();
            product.ID = productRepository.FindAllProducts().Count + 1;
            product.Name = name_pro;
            product.Price = Int32.Parse(price_pro);
            product.Quantity = Int32.Parse(quantity_pro);
            product.Sale = Int32.Parse(sale_pro);
            product.Info = info_pro;
            product.Slug = url_pro;
            product.Category = "may-tinh";
            product.ListImage = listimg;
            product.Trademark = thuong_hieu;
            // save
            productRepository.SaveProduct(product);
            Response.Redirect("/admin");
        }
    }
}