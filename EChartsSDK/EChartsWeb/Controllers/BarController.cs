using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EChartsWeb.Controllers
{
    public class BarController : Controller
    {
        // GET: Bar
        public ActionResult Index()
        {
            return View();
        }

        //HeapBar
        public ActionResult HeapBar()
        {
            return View();
        }

        public ActionResult Column()
        {
            return View();
        }

        public ActionResult HeapColumn()
        {
            return View();
        }


    }
}