using System.Threading.Tasks;
using TradeAnalytics.Services.Base;

namespace TradeAnalytics.Contracts
{
    public interface IAuthenticationService
    {
        Task<bool> Authenticate(string email, string password);

        Task<bool> Register(string firstName, string lastName, string userName, string email, string password);

        Task Logout();

        Task<LoginDetails> getLoggedInUserId();

    }
}
