using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using TradeAnalytics.Application.Features.Portfolioes.Commands.CreatePortfolio;
using TradeAnalytics.Application.Features.Portfolioes.Commands.DeletePortfolio;
using TradeAnalytics.Application.Features.Portfolioes.Commands.UpdatePortfolio;
using TradeAnalytics.Application.Features.Portfolioes.Queries.GetPortfolioDetail;
using TradeAnalytics.Application.Features.Portfolioes.Queries.GetPortfolioList;
using TradeAnalytics.Application.Features.TradeFees.Commands.CreateTradeFee;
using TradeAnalytics.Application.Features.TradeFees.Commands.DeleteTradeFee;
using TradeAnalytics.Application.Features.TradeFees.Commands.UpdateTradeFee;
using TradeAnalytics.Application.Features.TradeFees.Queries.GetTradeFeeDetail;
using TradeAnalytics.Application.Features.TradeFees.Queries.GetTradeFeeList;
using TradeAnalytics.Application.Features.TradeSecurities.Commands.CreateTradeSecurity;
using TradeAnalytics.Application.Features.TradeSecurities.Commands.DeleteTradeSecurity;
using TradeAnalytics.Application.Features.TradeSecurities.Commands.UpdateTradeSecurity;
using TradeAnalytics.Application.Features.TradeSecurities.Queries.GetTradeSecurityDetail;
using TradeAnalytics.Application.Features.TradeSecurities.Queries.GetTradeSecurityList;
using TradeAnalytics.Domain.Entities;
using TradeAnalytics.Domain.Entities.TradeFee;

namespace TradeAnalytics.Application.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Portfolio, PortfolioListVm>().ReverseMap();
            CreateMap<Portfolio, PortfolioDetailVm>().ReverseMap();
            CreateMap<TradeSecurity, TradeSecurityDto>().ReverseMap();
            CreateMap<Portfolio, CreatePortfolioCommand>().ReverseMap();
            CreateMap<Portfolio, UpdatePortfolioCommand>().ReverseMap();
            CreateMap<Portfolio, DeletePortfolioCommand>().ReverseMap();

            CreateMap<TradeSecurity, TradeSecurityListVm>().ReverseMap();
            CreateMap<TradeSecurity, TradeSecurityDetailVm>().ReverseMap();
            CreateMap<TradeSecurityFundamentals, TradeSecurityFundamentalsDto>().ReverseMap();
            CreateMap<TradeSecurityPerformance, TradeSecurityPerformanceDto>().ReverseMap();
            CreateMap<TradeSecurity, CreateTradeSecurityCommand>().ReverseMap();
            CreateMap<TradeSecurity, UpdateTradeSecurityCommand>().ReverseMap();
            CreateMap<TradeSecurity, DeleteTradeSecurityCommand>().ReverseMap();

            CreateMap<TradeSecurityFee, TradeFeeListVm>().ReverseMap();
            CreateMap<TradeSecurityFee, TradeFeeDetailVm>().ReverseMap();
            CreateMap<Brokerage, BrokerageDto>().ReverseMap();
            CreateMap<StampDuty, StampDutyDto>().ReverseMap();
            CreateMap<TradeSecurityFee, CreateTradeFeeCommand>().ReverseMap();
            CreateMap<TradeSecurityFee, UpdateTradeFeeCommand>().ReverseMap();
            CreateMap<TradeSecurityFee, DeleteTradeFeeCommand>().ReverseMap();
        }
    }
}
