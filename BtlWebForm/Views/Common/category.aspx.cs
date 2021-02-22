using BtlWebForm.Entity;
using BtlWebForm.Repository;
using BtlWebForm.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BtlWebForm.Views.Common
{
    public partial class category : System.Web.UI.Page
    {
        ProductRepository productRepository = new ProductRepository();
        protected void Page_Load(object sender, EventArgs e)
        {
            // xử lí trường hợp run tại page này hoặc cố tình vào page /Views/Common/...
            if (Request.Url.AbsolutePath.Contains("Views/Common"))
                Response.Redirect("/may-tinh");

            string category = (string)RouteData.Values["category"];

            url_server.Attributes.Add("href", "/" + category);
            switch (category)
            {
                case "may-tinh":
                    name_page.InnerText = "Máy tính";
                    break;
                case "phu-kien":
                    name_page.InnerText = "Phụ kiện";
                    break;
                case "san-pham":
                    name_page.InnerText = "Tất cả sản phẩm";
                    break;
                case "san-pham-moi-nhat":
                    name_page.InnerText = "Sản phẩm mới nhất";
                    break;
                case "san-pham-khuyen-mai":
                    name_page.InnerText = "Sản phẩm khuyến mãi";
                    break;
                default:
                    Response.Redirect("/san-pham");
                    break;
            }

            string HTML = "";
            foreach (ProductEntity product in productRepository.FindProductCategory(category))
            {
                string html = ProductUtil.MatchHtmlWithData(product);
                HTML += html;
            }
            data_server.InnerHtml = HTML;
        }
    }
}