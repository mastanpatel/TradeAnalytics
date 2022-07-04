using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using TradeAnalytics.Application.Features.Portfolioes.Commands.CreatePortfolio;
using TradeAnalytics.Application.Features.Portfolioes.Queries.GetPortfolioDetail;
using TradeAnalytics.Application.Features.Portfolioes.Queries.GetPortfolioList;
using TradeAnalytics.Domain.Entities;

namespace TradeAnalytics.Application.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Portfolio, PortfolioListVm>().ReverseMap();
            CreateMap<Portfolio, PortfolioDetailVm>().ReverseMap();
            CreateMap<TradeSecurity, TradeSecurityDto>();
            CreateMap<Portfolio, CreatePortfolioCommand>();
        }
    }
}
