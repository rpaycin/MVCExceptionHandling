using MVCExceptionHandling.CustomExceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCExceptionHandling.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            //1. YÖNTEM
            //    try
            //    {
            //        throw new Exception("Test exception");
            //        return View();
            //    }
            //    catch (Exception ex)
            //    {
            //        return View("Error");
            //    }

            throw new Exception("Test exception");
            return View("Error");
        }

        public ActionResult Error()
        {
            return View();
        }

        /// <summary>
        /// 3.Yöntem. HandleError niteliği metota veya classa eklenir
        /// web.confige eklenmesi gerek. <customErrors defaultRedirect="Error.cshtml" mode="On"/>
        /// </summary>
        /// <returns></returns>
        [HandleError()]
        public ActionResult SomeError()
        {
            throw new Exception("test");
        }

        //2.YÖNTEM. Sayfa içinde OnException override ederek. Hata sayfasında detayını gösteriyoruz
        //protected override void OnException(ExceptionContext filterContext)
        //{
        //    Exception ex = filterContext.Exception;
        //    filterContext.ExceptionHandled = true;

        //    var controllerName = filterContext.RouteData.Values["controller"].ToString();
        //    var actionName = filterContext.RouteData.Values["action"].ToString();
        //    var model = new HandleErrorInfo(filterContext.Exception, controllerName, actionName);

        //    filterContext.Result = new ViewResult()
        //    {
        //        ViewName = "Error",
        //        ViewData = new ViewDataDictionary(model)
        //    };
        //}
    }
}