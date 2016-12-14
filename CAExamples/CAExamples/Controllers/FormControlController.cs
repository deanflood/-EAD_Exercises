using CAExamples.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CAExamples.Controllers
{
    public class FormControlController : Controller
    {
        // GET: FormControl
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(FormControl fc)
        {
            return RedirectToAction("Details", fc);
        }

        public ActionResult Details(FormControl fc)
        {
            return View(fc);
        }


    }
}