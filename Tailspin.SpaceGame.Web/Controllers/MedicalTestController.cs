using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TailSpin.SpaceGame.Web.Models.MedicalTest;
using TailSpin.SpaceGame.Web.Services;

namespace TailSpin.SpaceGame.Web.Controllers
{
    public class MedicalTestController : Controller
    {
        private readonly TestPriceComparisonService _comparisonService;

        public MedicalTestController(TestPriceComparisonService comparisonService)
        {
            _comparisonService = comparisonService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View(new TestSearchQuery());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Compare(TestSearchQuery query)
        {
            if (string.IsNullOrWhiteSpace(query.TestNames))
            {
                ModelState.AddModelError("TestNames", "Please enter at least one test name.");
                return View("Index", query);
            }

            if (string.IsNullOrWhiteSpace(query.Location))
            {
                ModelState.AddModelError("Location", "Please enter your city.");
                return View("Index", query);
            }

            var result = await _comparisonService.CompareAsync(query);
            return View("Results", result);
        }

        [HttpGet]
        public async Task<IActionResult> Compare(string testNames, string location)
        {
            if (string.IsNullOrWhiteSpace(testNames) || string.IsNullOrWhiteSpace(location))
                return RedirectToAction("Index");

            var query = new TestSearchQuery { TestNames = testNames, Location = location };
            var result = await _comparisonService.CompareAsync(query);
            return View("Results", result);
        }
    }
}
