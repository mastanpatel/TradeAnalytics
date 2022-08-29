using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TradeAnalytics.Contracts;

namespace TradeAnalytics.Controllers
{
    public class PortfolioController : Controller
    {
        private readonly IPortfolioDataService _portfolioDataService;

        public PortfolioController(IPortfolioDataService portfolioDataService)
        {
            _portfolioDataService = portfolioDataService;

        }
        // GET: PortfolioController
        public IActionResult Index()
        {
            return View();
        }

        // GET: PortfolioController/Details/5
        public IActionResult Details(int id)
        {
            return View();
        }

        // GET: PortfolioController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PortfolioController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PortfolioController/Edit/5
        public IActionResult Edit(int id)
        {
            return View();
        }

        // POST: PortfolioController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PortfolioController/Delete/5
        public IActionResult Delete(int id)
        {
            return View();
        }

        // POST: PortfolioController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
