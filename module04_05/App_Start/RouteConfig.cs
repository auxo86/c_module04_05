using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace module04_05
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                //正常路徑的寫法是下面這一行
                //url: "{controller}/{action}/{id}",
                //正常defaults的寫法是像下面這樣
                //defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }

                //如果url:寫成下面這一行也可以，但是網址列存取就要改成http://localhost:4020/action/controller
                //而且default也要改成像下面的這樣defaults這樣(下面這兩行是一組的)
                url: "{action}/{controller}/{id}",
                //defaults的語句中，action = xxx和index = ooo位置會決定預設的網址列action和controller的位置
                //寫成像下面這樣，預設的網址列就會是http://localhost:4020/index/Home
                defaults: new { action = "Index", controller = "Home", id = UrlParameter.Optional }
            );
        }
    }
}
