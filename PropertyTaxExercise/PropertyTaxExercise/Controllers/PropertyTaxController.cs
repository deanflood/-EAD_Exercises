using PropertyTaxExercise.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PropertyTaxExercise.Controllers
{
    public class PropertyTaxController : Controller
    {
        // GET: PropertyTax
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(PropertyTaxService pt)
        {
            return View(pt);
        }
    }
}