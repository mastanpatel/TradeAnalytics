using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TradeAnalytics.Controllers
{
    public class TradeFeeController : Controller
    {
        // GET: TradeFeeController
        public ActionResult Index()
        {
            return View();
        }

        // GET: TradeFeeController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: TradeFeeController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TradeFeeController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
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

        // GET: TradeFeeController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: TradeFeeController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
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

        // GET: TradeFeeController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: TradeFeeController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
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
