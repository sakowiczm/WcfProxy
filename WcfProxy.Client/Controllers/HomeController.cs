using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WcfProxy.ServiceProxy;

namespace WcfProxy.Client.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Value()
        {
            var service = new DataService();

            ViewBag.Value = service.GetData(1);
            
            return View();
        }
    }
}