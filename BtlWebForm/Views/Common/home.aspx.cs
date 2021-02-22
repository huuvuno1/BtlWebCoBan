using BtlWebForm.Entity;
using BtlWebForm.Repository;
using BtlWebForm.Utils;
using System;
namespace BtlWebForm.Views.Common
{
    public partial class home : System.Web.UI.Page
    {
        ProductRepository productRepository = new ProductRepository();
        protected void Page_Load(object sender, EventArgs e)
        {
            // làm đẹp url
            if (!Request.Url.AbsolutePath.Equals("/"))
                Response.Redirect("/");

            // list máy tính
            string HTML = @"<div class='banner_cate width33'>
                                <a href='/may-tinh'>
                                     <img class='img' src='/static/img/banner/collection_module_2_banner.png' alt=''>
                                </a>
                            </div>"; 

            foreach (ProductEntity product in productRepository.FindProductCategory(Constant.MAY_TINH))
            {
                HTML += ProductUtil.MatchHtmlWithData(product);
            }
            maytinh.InnerHtml = HTML;

            // list phụ kiện
            HTML = @"<div class='banner_cate width33'>
                        <a href='/phu-kien'>
                                <img class='img' src='/static/img/banner/collection_module_3_banner.png' alt=''>
                        </a>
                    </div>";

            foreach (ProductEntity product in productRepository.FindProductCategory(Constant.PHU_KIEN))
            {
                HTML += ProductUtil.MatchHtmlWithData(product);
            }
            phukien.InnerHtml = HTML;

        }
    }
}