using System.Web.Routing;

namespace BtlWebForm.Router
{
    public class RouterConfig
    {
        public static void AddConfigRouteAdmin(RouteCollection routes)
        {
            routes.MapPageRoute("home-admin", "admin", "~/Views/Admin/home.aspx");
            routes.MapPageRoute("addproduct", "admin/add-product", "~/Views/Admin/addproduct.aspx");
        }

        public static void AddConfigRouteCommon(RouteCollection routes)
        {
            routes.MapPageRoute("home-common", "", "~/Views/Common/home.aspx");
            routes.MapPageRoute("page-login", "login", "~/Views/Common/login.aspx");
            routes.MapPageRoute("page-register", "register", "~/Views/Common/register.aspx");
            routes.MapPageRoute("logout", "logout", "~/Views/Common/logout.aspx");
            routes.MapPageRoute("search", "search", "~/Views/Common/search.aspx");
            routes.MapPageRoute("checkout", "checkout", "~/Views/Common/checkout.aspx");
            routes.MapPageRoute("cart", "cart", "~/Views/Common/cart.aspx");
            routes.MapPageRoute("access-denied", "access-denied", "~/Views/Common/access-denied.aspx");
            routes.MapPageRoute("category", "{category}", "~/Views/Common/category.aspx");
            routes.MapPageRoute("user", "api/user", "~/Views/Admin/RowUser.aspx");
            routes.MapPageRoute("pro", "api/product", "~/Views/Admin/RowProducts.aspx");
            routes.MapPageRoute("detail", "may-tinh/{slug}", "~/Views/Common/detail.aspx");
            routes.MapPageRoute("details", "phu-kien/{slug}", "~/Views/Common/detail.aspx");
        }

    }
}