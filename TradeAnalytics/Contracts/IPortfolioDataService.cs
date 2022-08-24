using System.Collections.Generic;
using System.Threading.Tasks;
using TradeAnalytics.Services;
using TradeAnalytics.Services.Base;
using TradeAnalytics.ViewModels;

namespace TradeAnalytics.Contracts
{
    public interface IPortfolioDataService
    {
        Task<List<PortfolioListViewModel>> GetAllPortfolioes();
        Task<PortfolioDetailVm> GetPortfolioDetails(bool includeHistory);
        Task<CreatePortfolioCommand> CreatePortfolio(CreatePortfolioCommand createPortfolioCommand);
    }
}
