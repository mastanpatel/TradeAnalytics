using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TradeAnalytics.Controllers
{
    public class TradeSecurityController : Controller
    {
        // GET: TradeSecurityController
        public ActionResult Index()
        {
            return View();
        }

        // GET: TradeSecurityController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: TradeSecurityController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TradeSecurityController/Create
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

        // GET: TradeSecurityController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: TradeSecurityController/Edit/5
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

        // GET: TradeSecurityController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: TradeSecurityController/Delete/5
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
