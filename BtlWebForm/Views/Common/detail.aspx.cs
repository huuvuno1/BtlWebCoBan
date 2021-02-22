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
    public partial class detail : System.Web.UI.Page
    {
        ProductRepository productRepository = new ProductRepository();
        protected void Page_Load(object sender, EventArgs e)
        {
            string category = (string)RouteData.Values["category"];
            string slug = (string)RouteData.Values["slug"];
            ProductEntity product = productRepository.FindProductBySlug(slug);
            if (product != null)
            {
                url_page.Attributes.Add("href", category);
                if ("may-tinh".Equals(category))
                    name_page.InnerText = "Máy tính";
                else
                    name_page.InnerText = "Phụ kiện";
                slug_.Attributes.Add("href", category + product.Url);
                name_product.InnerText = product.Name;

                bigImg.Attributes.Add("src", product.ListImage[0]);

                string html_img = @"<div class='chuyen' onclick='backImg()' style='display: none;'>
                                          <img src='/static/img/icon/click-left.png' >
                                    </div>";

                foreach (string img in product.ListImage)
                {
                    int i = 0;
                    html_img += @"<img src='" + img +@"' class='small-img' onclick='showImage(this)' num='" + i + @"'>";
                }
                html_img += @"<div class='chuyen' onclick='nextImg()'>
                                    <img src='/static/img/icon/click-right.png' >
                              </div>";
                list_anh.InnerHtml = html_img;

                name_pro.InnerText = product.Name;
                name_pro.Attributes.Add("href", product.Url);

                price_new.InnerText = String.Format("{0:0,0}", product.Price * (100 - product.Sale) / 100) + @"₫";
                price_old.InnerText = String.Format("{0:0,0}", product.Price) + @"₫";

                _status.InnerText = product.Quantity > 0 ? "Còn hàng" : "Hết hàng";

                descript.InnerText = product.Info;
            }
            else
                Response.Redirect(" / ");
        }
    }
}