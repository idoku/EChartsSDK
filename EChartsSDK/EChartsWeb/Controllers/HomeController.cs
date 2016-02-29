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
            if (api == "bar11" || api == "scatter4")
            {
                ViewBag.ExtJs = "../Scripts/charts/timelineOption.js";
            }
            else if (api == "scatter2")
            {
                ViewBag.ExtJs = "../Scripts/charts/asset.js";
            }
            else if (api == "lasagna")
            {
                ViewBag.ExtJs = "../Scripts/charts/lasagna.js";
            }
            else if (api == "Force") {
                ViewBag.ExtJs = "../Scripts/charts/force.js";
            }
            else if (api == "force1")
            {
                ViewBag.ExtJs = "../Scripts/charts/force.js";
            }
            else if (api == "force2")
            {
                ViewBag.ExtJs = "../Scripts/charts/force2.js";
            }
            else if (api == "force4")
            {
                ViewBag.ExtJs = "../Scripts/charts/force4.js";
            }

            return View();
        }
    }
}