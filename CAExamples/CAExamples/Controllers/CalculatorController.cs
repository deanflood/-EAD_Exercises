using CAExamples.Models;
using System.Web.Mvc;

namespace CAExamples.Controllers
{
    public class CalculatorController : Controller
    {
        // GET: Calculator
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Calculator calc)
        {
            return View(calc);
        }
    }
}