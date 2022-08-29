using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using TradeAnalytics.Contracts;
using TradeAnalytics.ViewModels;

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
        public async Task<bool> Register(string firstName, string lastName, string userName, string email, string password)
        {
            RegisterViewModel register = new RegisterViewModel();
            register.FirstName = firstName;
            register.LastName = lastName;
            register.Email = email;
            register.UserName = userName;
            register.Password = password;

            var isRegistered = false;

            if (ModelState.IsValid)
            {
                isRegistered = await _authenticationService.Register(register);
            }

            return isRegistered;
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

        [HttpPost]
        public async Task Logout()
        {
            await _authenticationService.Logout();
        }

    }
}
