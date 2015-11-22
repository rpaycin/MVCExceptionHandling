using MVCExceptionHandling.CustomExceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVCExceptionHandling
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            //custom error için eklenmesi gerekli
            //FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
        }

        //6.Yöntem
        protected void Application_Error(object sender, EventArgs e)
        {
            Exception exception = Server.GetLastError();
            Server.ClearError();
            Response.Redirect("/Home/Error");
        }
    }
}
