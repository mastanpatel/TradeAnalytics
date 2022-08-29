using TradeAnalytics.Models;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using Microsoft.AspNetCore.Mvc;
using TradeAnalytics.Contracts;
using System.Threading.Tasks;
using System.Collections.Generic;
using TradeAnalytics.ViewModels;

namespace TradeAnalytics.Controllers
{

    [Route("api/[controller]")]
    public class PortfolioDataController : Controller
    {
        private readonly IPortfolioDataService _portfolioDataService;

        public PortfolioDataController(IPortfolioDataService portfolioDataService)
        {
            _portfolioDataService = portfolioDataService;
        }

        [HttpGet]
        public async Task<object> Get(DataSourceLoadOptions loadOptions)
        {
            //List<PortfolioListViewModel> data = _portfolioDataService.GetAllPortfolioes();

            var data = await _portfolioDataService.GetAllPortfolioes();

            return DataSourceLoader.Load(data, loadOptions);
        }
    }
}
