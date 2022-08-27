using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using TradeAnalytics.Contracts;

namespace TradeAnalytics.Controllers
{
    public class AccountController : Controller
    {

        private readonly IAuthenticationService _authenticationService;

        public AccountController(IAuthenticationService authenticationService)
        {
            _authenticationService = authenticationService;
        }
        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<string> Authenticate(string email, string password)
        {
            var isAuthenticated = await _authenticationService.Authenticate(email, password);

            if (isAuthenticated)
            {
                return "Success";
            }
            return "Error";
        }
    }
}
