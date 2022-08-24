using AutoMapper;
using TradeAnalytics.Services.Base;
using TradeAnalytics.ViewModels;

namespace TradeAnalytics.Profiles
{
    public class Mapping : Profile
    {
        public Mapping()
        {
            CreateMap<PortfolioListVm, PortfolioListViewModel>().ReverseMap();
        }
    }
}
