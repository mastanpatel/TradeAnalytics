using System.Threading.Tasks;
using TradeAnalytics.Services.Base;
using TradeAnalytics.ViewModels;

namespace TradeAnalytics.Contracts
{
    public interface IAuthenticationService
    {
        Task<bool> Authenticate(string email, string password);

        Task<bool> Register(RegisterViewModel model);

        Task Logout();

        Task<LoginDetails> getLoggedInUserId();

        Task<bool> isLoggedinAsync();

        string AddBearerToken();

    }
}
