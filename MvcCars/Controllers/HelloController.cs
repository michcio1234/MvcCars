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
        public string Index()
        {
            return "Akcja <b>domyślna</b>.";
        }

        public string Welcome(string name, int id = 1)
        {
            return HttpUtility.HtmlEncode("Witaj " + name + ", numer wizyty: " + id);
        }
    }
}