using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EChartsWeb.Apis;

namespace EChartsWeb.Controllers
{
    public class HomeController : Controller
    {
        
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Demo()
        {
            return View();
        }

        public ActionResult Editor(string c)
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
            else if (api == "force")
            {
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
            else if (api == "gauge4")
            {
                ViewBag.ExtJs = "../Scripts/charts/gauge4.js";
            }
            else if (api == "gauge5")
            {
                ViewBag.ExtJs = "../Scripts/charts/gauge5.js";
            }
            else if (api.Contains("gauge"))
            {
                ViewBag.ExtJs = "../Scripts/charts/gauge.js";
            }
            else if (api == "heatmap_map")
            {
                ViewBag.ExtJs = "../Scripts/charts/heatmap_map.js";
            }
            else if (api.Contains("heatmap"))
            {
                ViewBag.ExtJs = "../Scripts/charts/heatmap.js";
            }
            else if (api == "eventRiver2")
            {
                ViewBag.ExtJs = "../Scripts/charts/eventRiver2_data.js";
            }
            else if (api == "wordCloud")
            {
                ViewBag.ExtJs = "../Scripts/charts/wordCloud.js";
            }
            return View();
        }
    }
}