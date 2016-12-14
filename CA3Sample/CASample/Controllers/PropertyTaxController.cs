using CA3Sample2.Models;
using System.Web.Mvc;

namespace CA3Sample2.Controllers
{
    public class PropertyTaxController : Controller
    {
        public ActionResult CalculateTax()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CalculateTax(PropertyTaxservice pt)
        {
            return View(pt);
        }
    }
}