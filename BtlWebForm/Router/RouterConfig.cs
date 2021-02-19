using System.Web.Routing;

namespace BtlWebForm.Router
{
    public class RouterConfig
    {
        public static void AddConfigRouteAdmin(RouteCollection routes)
        {
            routes.MapPageRoute("home-admin", "admin", "~/Views/Admin/home.aspx");
        }

        public static void AddConfigRouteCommon(RouteCollection routes)
        {
            routes.MapPageRoute("home-common", "", "~/Views/Common/home.aspx");
            routes.MapPageRoute("page-login", "login", "~/Views/Common/login.aspx");
            routes.MapPageRoute("action", "action", "~/Views/Common/action.aspx");
            routes.MapPageRoute("search", "search", "~/Views/Common/search.aspx");
            routes.MapPageRoute("access-denied", "access-denied", "~/Views/Common/access-denied.aspx");
        }

        public static void AddConfigRouteAjax(RouteCollection routes)
        {
            routes.MapPageRoute("api-product", "api/product/{ID}", "~/Views/Ajax/ShowDetailProduct.aspx");
            routes.MapPageRoute("api-form-add", "api/form", "~/Views/Ajax/FormAddOrEditProduct.aspx");
            routes.MapPageRoute("api-form-edit", "api/form/{ID}", "~/Views/Ajax/FormAddOrEditProduct.aspx");
            routes.MapPageRoute("api-row-product", "api/product", "~/Views/Ajax/RowProducts.aspx");
            routes.MapPageRoute("api-get-product-session", "api/cart", "~/Views/Ajax/Cart.aspx");
            routes.MapPageRoute("api-add-product-session", "api/cart/{ID}", "~/Views/Ajax/Cart.aspx");
            routes.MapPageRoute("api-add-quantity-product-session", "api/cart/{ID}/{Type}/{Quantity}", "~/Views/Ajax/Cart.aspx");
            
        }
    }
}