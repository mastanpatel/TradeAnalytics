using AutoMapper;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Http;
using System;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using TradeAnalytics.Auth;
using TradeAnalytics.Contracts;
using TradeAnalytics.Services.Base;
using TradeAnalytics.ViewModels;

namespace TradeAnalytics.Services
{
    public class AuthenticationService : BaseDataService, IAuthenticationService
    {
        private readonly IMapper _mapper;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly AuthenticationStateProvider _authenticationStateProvider;

        public AuthenticationService(IClient client, IMapper mapper, IHttpContextAccessor httpContextAccessor,AuthenticationStateProvider authenticationStateProvider) : base(client)
        {
            _authenticationStateProvider = authenticationStateProvider;
            _mapper = mapper;
            _httpContextAccessor = httpContextAccessor;
        }
        public async Task<bool> Authenticate(string email, string password)
        {
            LoginViewModel login = new LoginViewModel();
            login.Email = email;
            login.Password = password;

            var mappedAuthenticationRequist = _mapper.Map<AuthenticationRequest>(login);
            var authenticationRepsonse = await _client.AuthenticateAsync(mappedAuthenticationRequist);

            if (authenticationRepsonse.Token != string.Empty)
            {
                _httpContextAccessor.HttpContext.Session.SetString("token", authenticationRepsonse.Token);
                ((CustomAuthenticationStateProvider)_authenticationStateProvider).SetUserAuthenticated(email);
                _client.HttpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", authenticationRepsonse.Token);
                return true;
            }
            return false;
        }

        public Task Logout()
        {
            _httpContextAccessor.HttpContext.Session.Remove("token");
            ((CustomAuthenticationStateProvider)_authenticationStateProvider).SetUserLoggedOut();
            _client.HttpClient.DefaultRequestHeaders.Authorization = null;
            return Task.CompletedTask;
        }

        public async Task<bool> Register(RegisterViewModel model)
        {
            // RegistrationRequest registrationRequest = new RegistrationRequest() { FirstName = firstName, LastName = lastName, Email = email, UserName = userName, Password = password };
            
            var mappedRegistrationRequist = _mapper.Map<RegistrationRequest>(model);

            var response = await _client.RegisterAsync(mappedRegistrationRequist);

            if (!string.IsNullOrEmpty(response.UserId))
            {
                return true;
            }
            return false;
        }

        public async Task<LoginDetails> getLoggedInUserId()
        {
            var loggedinDetails = await _client.UserIdsAsync();
           //var state = await ((CustomAuthenticationStateProvider)_authenticationStateProvider).GetAuthenticationStateAsync();

           // state.User.Identity.IsAuthenticated;
            return loggedinDetails;
        }

        public async Task<bool> isLoggedinAsync()
        {
            var state = await ((CustomAuthenticationStateProvider)_authenticationStateProvider).GetAuthenticationStateAsync();

            if (state.User.Identity.IsAuthenticated)
            {
                return true;
            }

            return false;
        }
        public string AddBearerToken()
        {
            if (_httpContextAccessor.HttpContext.Session.GetString("token") != null)
            {
                _client.HttpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", _httpContextAccessor.HttpContext.Session.GetString("token"));
                return _httpContextAccessor.HttpContext.Session.GetString("token");
            }

            return "";
        }

    }
}
