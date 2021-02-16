using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Web;
using System.Web.Routing;

public class CommonRouterConfig
{
    public static void AddRouter(RouteCollection routes)
    {
        routes.MapPageRoute("home-common", "", "~/Views/Common/home.aspx");
        routes.MapPageRoute("page-login", "login", "~/Views/Common/login.aspx");
        routes.MapPageRoute("action", "action", "~/Views/Common/action.aspx");
        routes.MapPageRoute("search", "search", "~/Views/Common/search.aspx");
    }
}
