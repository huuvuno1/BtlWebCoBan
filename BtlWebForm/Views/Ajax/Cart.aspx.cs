using BtlWebForm.Entity;
using BtlWebForm.Repository;
using BtlWebForm.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BtlWebForm.Views.Ajax
{
    public partial class Cart : System.Web.UI.Page
    {
        ProductRepository productRepository = new ProductRepository();
        protected void Page_Load(object sender, EventArgs e)
        {
            // Xử lý trường hợp ấn run ngay tại trang này, sẽ điều hướng đến trang home
            if (!Request.Url.AbsolutePath.Contains("api/cart"))
                Response.Redirect("/");

            // url /api/cart/{id} -> add product to cart
            string ID = (string) RouteData.Values["ID"];
            if (ID != null)
            {
                SaveProductToSession(Int32.Parse(ID), Session);
            }
            // urel /api/cart -> get full product from session
            else
            {
                OrderEntity order = (OrderEntity)Session.Contents["order"];
                if (order != null)
                {
                    List<int> ids = GetListIDFromSession(order);
                    List<ProductEntity> products = productRepository.FindProductByListID(ids);
                    if (products == null)
                        return;
                    string html = "";
                    // edit part 2
                    int i = 0;
                    foreach (ProductEntity product in products)
                    {
                        html += ProductUtil.MatchHtmlWithProductSession(product, order.ListProduct[i].Quantity);
                        i++;
                    }
                    Response.Write(html);
                }
            }
            OrderEntity ordertest = (OrderEntity)Session.Contents["order"];
        }

        private List<int> GetListIDFromSession(OrderEntity order)
        {
            List<int> ids = new List<int>();
            foreach (ProductEntity product in order.ListProduct)
            {
                int id = product.ID;
                ids.Add(id);
            }
            return ids;
        }

        private void SaveProductToSession(int ID, HttpSessionState session)
        {
            OrderEntity order = (OrderEntity)Session.Contents["order"];
            if (order == null)
            {
                order = new OrderEntity(1, ID, 1);
                Session.Add("order", order);
            }    
            else
            {
                bool isExist = false;
                for (int i = 0; i < order.ListProduct.Count; i++)
                {
                    if (ID == order.ListProduct[i].ID)
                    {
                        order.ListProduct[i].Quantity++;
                        isExist = true;
                    }
                }
                if (isExist)
                    Session.Add("order", order);
                else
                {
                    ProductEntity product = new ProductEntity(ID, 1);
                    order.ListProduct.Add(product);
                    Session.Add("oder", order);
                }
            }
        }

    }
}