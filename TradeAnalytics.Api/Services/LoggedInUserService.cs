using Microsoft.AspNetCore.Http;
using System.Security.Claims;
using System.Threading.Tasks;
using TradeAnalytics.Application.Contracts;
using TradeAnalytics.Application.Models.Authentication;

namespace TradeAnalytics.Api.Services
{
    public class LoggedInUserService : ILoggedInUserService
    {

        public string UserId { get; }
        public LoggedInUserService(IHttpContextAccessor httpContextAccessor)
        {
            UserId = httpContextAccessor.HttpContext?.User?.FindFirstValue(ClaimTypes.NameIdentifier);
        }


        public Task<LoginDetails> getUserDetailsAsync()
        {
            LoginDetails response = new LoginDetails
            {
                UserId = UserId
            };

            return Task.FromResult(response);
        }
    }
}
