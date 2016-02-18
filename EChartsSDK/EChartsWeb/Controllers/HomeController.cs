using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EChartsWeb.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Example(string api)
        {
            ViewBag.API = api;
            if (api == "bar11") {
                ViewBag.ExtJs = "../Scripts/charts/timelineOption.js";
            }
            return View();
        }
    }
}