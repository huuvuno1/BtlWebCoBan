using BtlWebForm.Entity;
using BtlWebForm.Repository;
using BtlWebForm.Utils;
using System;
using System.Collections.Generic;
namespace BtlWebForm.Views.Common
{
    public partial class search : System.Web.UI.Page
    {
        ProductRepository productRepository = new ProductRepository();
        protected void Page_Load(object sender, EventArgs e)
        {

            string html = "";
            string q = Request.QueryString.Get("q");
            List<ProductEntity> products = productRepository.FindProductsLikeName(q);
            if (products == null)
                CountResult.InnerText = "Không có sản phẩm nào được tìm thấy !";
            else
            {
                CountResult.InnerText = "Có " + products.Count + " kết quả được tìm thấy";

                foreach (ProductEntity product in products)
                    html += ProductUtil.MatchHtmlWithData(product);

                ListProduct.InnerHtml = html;
            }    
                

        }
    }
}