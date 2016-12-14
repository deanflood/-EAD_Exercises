using CAExamples.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CAExamples.Controllers
{
    public class AzureStorageController : Controller
    {
        // GET: AzureStorage
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(AzureStorage azureS)
        {
            return View(azureS);
        }

        public ActionResult Redendancy()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Redendancy(AzureRedundency azureR)
        {
            return RedirectToAction("Details", azureR);
        }

        public ActionResult Details(AzureRedundency azureR)
        {
            return View(azureR);
        }


    }
}