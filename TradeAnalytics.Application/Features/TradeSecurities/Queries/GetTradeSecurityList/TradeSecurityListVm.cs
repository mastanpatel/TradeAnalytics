﻿namespace TradeAnalytics.Application.Features.TradeSecurities.Queries.GetTradeSecurityList
{
    public class TradeFeeListVm
    {
        public int TradeSecurityId { get; set; }
        public int PortfolioId { get; set; }
        public string Name { get; set; }
        public string SecurityCode { get; set; }
        public string Desc { get; set; }
    }
}