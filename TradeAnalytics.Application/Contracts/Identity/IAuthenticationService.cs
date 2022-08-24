using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TradeAnalytics.Application.Models.Authentication;

namespace TradeAnalytics.Application.Contracts.Identity
{
    public interface IAuthenticationService
    {
        Task<AuthenticationResponse> AuthenticateAsync(AuthenticationRequest request);
        Task<RegistrationResponse> RegisterAsync(RegistrationRequest request);
    }
}
