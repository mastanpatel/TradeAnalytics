using AutoMapper;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TradeAnalytics.Contracts;
using TradeAnalytics.Services.Base;
using TradeAnalytics.ViewModels;

namespace TradeAnalytics.Services
{
    public class PortfolioDataService : BaseDataService, IPortfolioDataService
    {
        private IMapper _mapper;

        public PortfolioDataService(IClient client, IMapper mapper) : base(client)
        {
            _mapper = mapper;
        }
        public Task<CreatePortfolioCommand> CreatePortfolio(CreatePortfolioCommand createPortfolioCommand)
        {
            throw new System.NotImplementedException();
        }

        public async Task<List<PortfolioListViewModel>> GetAllPortfolioes()
        {
            var allPortfolioes = await _client.GetAllPortfolioesAsync();
            var mappedPortfolioes = _mapper.Map<ICollection<PortfolioListViewModel>>(allPortfolioes);
            return mappedPortfolioes.ToList();

        }

        public Task<PortfolioDetailVm> GetPortfolioDetails(bool includeHistory)
        {
            throw new System.NotImplementedException();
        }

    }
}
