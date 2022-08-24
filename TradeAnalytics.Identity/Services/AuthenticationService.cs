using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TradeAnalytics.Application.Contracts.Identity;
using TradeAnalytics.Application.Models.Authentication;

namespace TradeAnalytics.Identity.Services
{
    public class AuthenticationService : IAuthenticationService
    {
        public Task<AuthenticationResponse> AuthenticateAsync(AuthenticationRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<RegistrationRequest> RegisterAsync(RegistrationRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
