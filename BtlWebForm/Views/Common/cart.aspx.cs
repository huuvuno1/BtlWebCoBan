using BtlWebForm.Entity;
using BtlWebForm.Repository;
using BtlWebForm.Utils;
using System;
using System.Collections.Generic;

namespace BtlWebForm.Views.Common
{
    public partial class cart : System.Web.UI.Page
    {
        // TRANG NÀY HIỂN THỊ SẢN PHẨM TRONG GIỎ HÀNG

        ProductRepository productRepository = new ProductRepository();
        protected void Page_Load(object sender, EventArgs e)
        {
            // xử lý khi ng dùng thêm sản phẩm vào giỏ
            if (Request.RequestType.ToLower().Equals("post"))
                AddToCart();


            // tiến hành đọc check session giỏ hàng
            OrderEntity order = (OrderEntity)Session[Constant.ORDER_SESSION];
            if (order == null)
            {
                status_order.InnerHtml = @"<div style='height: 200px'>
                                                 <span> Bạn chưa chọn sản phẩm nào </span>
                                           </div> ";
            }    
            else
            {
                string HTML = "";
                float sumMoney = 0;
                for (int i = 0; i < order.ListProduct.Count; i++)
                {
                    ProductEntity product = productRepository.FindProductByID(order.ListProduct[i].ID);
                    HTML += ProductUtil.MatchHtmlWithProductSession(product, order.ListProduct[i].Quantity);

                    sumMoney += product.Price * order.ListProduct[i].Quantity * (100 - product.Sale) / 100;
                }
                data_render.InnerHtml = HTML;
                tong.InnerText = String.Format("{0:0,0}", sumMoney);
            }    
        }

        private void AddToCart()
        {
            int quantity = Int32.Parse(Request.Form["quantity"]);
            int id = Int32.Parse(Request.Form["ctl00$CommonBody$id_product"]);
            OrderEntity order = (OrderEntity)Session[Constant.ORDER_SESSION];
            if (order == null)
            {
                order = new OrderEntity();
                order.ListProduct = new List<ProductEntity>();
            }

            ProductEntity product = productRepository.FindProductByID(id);
            if (product != null)
            {
                bool added = false;
                foreach (ProductEntity pr in order.ListProduct)
                {
                    if (id == pr.ID)
                    {
                        pr.Quantity = quantity;
                        added = true;
                        break;
                    }
                }
                if (!added)
                {
                    ProductEntity productAdd = new ProductEntity(product.ID, quantity);
                    order.ListProduct.Add(productAdd);
                }
            }

            Session[Constant.ORDER_SESSION] = order;
        }
    }
}