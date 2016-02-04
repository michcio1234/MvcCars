using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcCars.Controllers
{
    public class HelloController : Controller
    {
        // GET: Hello
        public string OldIndex()
        {
            return "Akcja <b>domyślna</b>.";
        }

        public ActionResult Welcome(string name, int id = 1)
        {
            ViewBag.Message = "Witaj " + name;
            ViewBag.Number = id;

            return View();
        }

        public ActionResult Index()
        {
            return View();
        }

    }
}