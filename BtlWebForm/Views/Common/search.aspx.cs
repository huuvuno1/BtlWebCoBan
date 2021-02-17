using System;

namespace BtlWebForm.Views.Common
{
    public partial class search : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string html = 
                @"<div class='product'>
                    <div class='product-box'>
                        <div class='product-thumnail'>
                            <span class='sale-count'>
                                - 8%
                            </span>
                            <a href = '' title='LapApple Macbook 12 MNYK2SA/A Core M 1.2GHz/8GB/256GB (2017)'>
                                <img src = '/static/img/product/apple-macbook-12-mnyk2sa-a-450x300-450x300.jpg' alt=''
                                    class='img-thumnail'>
                            </a>
                            <div class='show-option-selection'>
                                <div class='view-details' onclick='btnShowForm(1)' title='Xem nhanh'>
                                    <img src = '/static/img/icon/kinhlup.png' alt='' class='icon'>
                                </div>
                                <div class='add-to-cart' onclick='btnShowForm(2)' title='Thêm vào Thêm vào giỏ hàng'>
                                    <img src = '/static/img/icon/cart.png' alt='' class='icon'>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class='product-box khungduoi'>
                        <div class='product-info'>
                            <span class='product-vendor'>
                                Apple
                            </span>

                            <h4 class='product-name'>
                                <a href = '' class='text-2-line'>
                                    Lap tốp vjp pro (2017)
                                </a>
                            </h4>

                            <div class='product-price'>
                                <span class='product-price-old'>
                                    300.000.000₫
                                </span>
                                <span class='product-price-new'>
                                    28.000.000₫
                                </span>
                            </div>
                        </div>
                    </div>
                </div>";
           
            ListProduct.InnerHtml = html;
        }
    }
}