using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;

public class AdminRouterConfig
{
    public static void AddRouter(RouteCollection routes)
    {
        routes.MapPageRoute("home-admin", "admin", "~/Views/Admin/home.aspx");
    }
}
