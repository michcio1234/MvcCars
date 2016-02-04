using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcCars.Controllers
{
    public class MarianController : Controller
    {
        // GET: Marian
        public string Index()
        {
            return "Eloszka, jestem Marian.";
        }

        public string Jump()
        {
            return "Podskoczyłem sobie. Hopsasa.";
        }
    }
}