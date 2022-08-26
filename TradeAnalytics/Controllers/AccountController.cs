using Microsoft.AspNetCore.Mvc;

namespace TradeAnalytics.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
