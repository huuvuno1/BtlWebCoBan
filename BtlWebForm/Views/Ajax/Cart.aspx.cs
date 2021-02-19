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
            // Xử lý trường hợp ấn run ngay tại trang này, điều hướng đến trang home
            if (!Request.Url.AbsolutePath.Contains("api/cart"))
                Response.Redirect("/");

            // url /api/cart/{id} -> add product to cart
            // save cart with format: "ID1|Quantity1-ID2|Quantity2..."
            string ID = (string) RouteData.Values["ID"];
            if (ID != null)
            {
                SaveIDProductToSession(ID, Session);
            }
            // urel /api/cart -> get full product from session
            else
            {
                string cart = (string)Session.Contents["cart"];
                if (cart != null && !("".Equals(cart)))
                {
                    List<int> ids = GetListIDFromSession(cart);
                    List<ProductEntity> products = productRepository.FindProductByListID(ids);
                    if (products == null)
                        return;
                    string html = "";
                    foreach (ProductEntity product in products)
                    {
                        html += ProductUtil.MatchHtmlWithProductSession(product);
                    }
                    Response.Write(html);
                }
            }
        }

        private List<int> GetListIDFromSession(string cart)
        {
            List<int> ids = new List<int>();
            string[] productAndQuantity = cart.Split('-');
            foreach (string loop in productAndQuantity)
            {
                string id = loop.Split('|')[0];
                ids.Add(Int32.Parse(id));
            }
            return ids;
        }

        private void SaveIDProductToSession(string ID, HttpSessionState session)
        {
            string cart = (string)Session.Contents["cart"];
            if (cart == null || "".Equals(cart))
                Session.Add("cart", ID + "|1");
            else
            {
                // cắt cart từ session ra mảng: {"ID1|Quantity1", "ID2|Quantity2", ...}
                string[] productAndQuantity = cart.Split('-');

                string cartChange = "";
                bool isExist = false;
                // loop để kiểm tra sản phẩm này đã có trong session chưa, nếu có thì tăng số lượng lên
                foreach (string loop in productAndQuantity)
                {
                    string[] temp = loop.Split('|');
                    if (temp[0].Equals(ID)) // temp[0] = ID
                    {
                        temp[1] = (Int32.Parse(temp[1]) + 1).ToString();
                        isExist = true;
                    }
                    cartChange += temp[0] + "|" + temp[1] + "-";
                }

                if (isExist)
                {
                    cartChange = cartChange.Remove(cartChange.Length - 1);
                    Session.Add("cart", cartChange);
                }
                else
                {
                    cart += "-" + ID + "|1";
                    Session.Add("cart", cart);
                }
            }
        }

    }
}