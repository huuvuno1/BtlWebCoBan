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
    }
}