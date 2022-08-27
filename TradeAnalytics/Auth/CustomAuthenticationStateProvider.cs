using Microsoft.AspNetCore.Components.Authorization;
using System.Security.Claims;
using System.Threading.Tasks;

namespace TradeAnalytics.Auth
{
    public class CustomAuthenticationStateProvider : AuthenticationStateProvider
    {
        public override Task<AuthenticationState> GetAuthenticationStateAsync()
        {

            var anonUser = new ClaimsPrincipal(new ClaimsIdentity(new[] { new Claim(ClaimTypes.Name, "email") }, "apiauth"));

            var authState = Task.FromResult(new AuthenticationState(anonUser));
            

            return authState;
        }

        public void SetUserAuthenticated(string email)
        {
            var authUser = new ClaimsPrincipal(new ClaimsIdentity(new[] { new Claim(ClaimTypes.Name, email) }, "apiauth"));
            var authState = Task.FromResult(new AuthenticationState(authUser));
            NotifyAuthenticationStateChanged(authState);
        }
    }
}
