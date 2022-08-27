using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using TradeAnalytics.Application.Contracts;
using TradeAnalytics.Application.Contracts.Identity;
using TradeAnalytics.Application.Models.Authentication;

namespace TradeAnalytics.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : Controller
    {
        private readonly IAuthenticationService _authenticationService;
        private readonly ILoggedInUserService _loggedInUserService;

        public AccountController(IAuthenticationService authenticationService, ILoggedInUserService loggedInUserService)
        {
            _authenticationService = authenticationService;
            _loggedInUserService = loggedInUserService;
        }

        [HttpPost("authenticate")]
        public async Task<ActionResult<AuthenticationResponse>> AuthenticateAsync(AuthenticationRequest request)
        {
            return Ok(await _authenticationService.AuthenticateAsync(request));
        }

        [HttpPost("register")]
        public async Task<ActionResult<RegistrationResponse>> RegisterAsync(RegistrationRequest request)
        {
            return Ok(await _authenticationService.RegisterAsync(request));
        }

        [HttpGet("UserIds")]
        public async Task<ActionResult<LoginDetails>> GetLoggedInUserId()
        {
            var userDetails = await _loggedInUserService.getUserDetailsAsync();

            return userDetails;


            //if(_loggedInUserService.UserId != null)
            //    return  Ok(_loggedInUserService.UserId);
            //return Ok("0");
        }

    }
}
