using AutoMapper;
using System;
using System.Threading.Tasks;
using TradeAnalytics.Contracts;
using TradeAnalytics.Services.Base;
using TradeAnalytics.ViewModels;

namespace TradeAnalytics.Services
{
    public class AuthenticationService : BaseDataService, IAuthenticationService
    {
        private readonly IMapper _mapper;

        public AuthenticationService(IClient client, IMapper mapper) : base(client)
        {
            _mapper = mapper;
        }

        public async Task<bool> Authenticate(string email, string password)
        {
            LoginViewModel login = new LoginViewModel();
            login.Email = email;
            login.Password = password;

            var mappedAuthenticationRequist = _mapper.Map<AuthenticationRequest>(login);
            var authenticationRepsonse = await _client.AuthenticateAsync(mappedAuthenticationRequist);

            if (authenticationRepsonse.Id != string.Empty)
            {
                return true;
            }
            return false;
        }

        public Task Logout()
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> Register(string firstName, string lastName, string userName, string email, string password)
        {
            throw new System.NotImplementedException();
        }

        public async Task<LoginDetails> getLoggedInUserId()
        {
            var loggedinDetails = await _client.UserIdsAsync();

            return loggedinDetails;
        }


    }
}
