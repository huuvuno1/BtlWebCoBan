using System;
using BtlWebForm.Entity;

namespace BtlWebForm.Utils
{
    public class ProductUtil
    {
        public static string MatchHtmlWithData(ProductEntity product)
        {
            if (product == null)
                return null;

            string name = product.Name;

            string html =
                @"<div class='product'>
                    <div class='product-box'>
                        <div class='product-thumnail'> ";
            if (product.Sale != 0f)
                html += @"<span class='sale-count'>
                                - " + product.Sale + @"%
                            </span>";

            html += @"<a href = '' title='" + product.Name + @"'>
                                <img src = '" + product.ListImage[0] + @"' alt=''
                                    class='img-thumnail'>
                            </a>
                            <div class='show-option-selection'>
                                <div class='view-details' onclick='btnShowForm(1, " + product.ID + @")' title='Xem nhanh'>
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
                                " + product.Trademark + @"
                            </span>

                            <h4 class='product-name'>
                                <a href = '' class='text-2-line'>
                                    " + product.Name + @"
                                </a>
                            </h4>

                            <div class='product-price'> ";
                if (product.Sale != 0f)
                    html += @"<span class='product-price-old'>
                                    " + String.Format("{0:0,0}", product.Price) + @"₫
                                </span>";

                html +=        @"<span class='product-price-new'>
                                    " + String.Format("{0:0,0}", product.Price * (100 - product.Sale) / 100) + @"₫
                                </span>
                            </div>
                        </div>
                    </div>
                </div>";
            return html;
        }
    }
}