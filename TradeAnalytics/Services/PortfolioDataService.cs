using AutoMapper;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using TradeAnalytics.Contracts;
using TradeAnalytics.Services.Base;
using TradeAnalytics.ViewModels;

namespace TradeAnalytics.Services
{
    public class PortfolioDataService : BaseDataService, IPortfolioDataService
    {
        private IMapper _mapper;
        private readonly IAuthenticationService _authenticationService;

        public PortfolioDataService(IClient client, IMapper mapper, IAuthenticationService authenticationService) : base(client)
        {
            _mapper = mapper;
            _authenticationService = authenticationService;
        }
        public async Task<CreatePortfolioCommand> CreatePortfolio(CreatePortfolioCommand createPortfolioCommand)
        {
           // await AddBearerToken();

            throw new System.NotImplementedException();
        }

        public async Task<List<PortfolioListViewModel>> GetAllPortfolioes()
        {
            var token = _authenticationService.AddBearerToken();

            _client.HttpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

            var allPortfolioes = await _client.GetAllPortfolioesAsync();
            var mappedPortfolioes = _mapper.Map<ICollection<PortfolioListViewModel>>(allPortfolioes);
            return mappedPortfolioes.ToList();

        }

        public async Task<PortfolioDetailVm> GetPortfolioDetails(bool includeHistory)
        {
            //await AddBearerToken();

            throw new System.NotImplementedException();
        }

    }
}
