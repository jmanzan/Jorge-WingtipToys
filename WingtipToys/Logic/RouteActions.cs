using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;

namespace WingtipToys.Logic
{
    internal class RouteActions
    {
        internal void RegisterCustomRoutes()
        {
            RouteTable.Routes.MapPageRoute(
                "ProductsByCategoryRoute",
                "Category/{categoryName}",
                "~/ProductList.aspx"
            );

            RouteTable.Routes.MapPageRoute(
                "ProductByNameRoute",
                "Product/{productName}",
                "~/ProductDetails.aspx"
            );

        }
    }

}