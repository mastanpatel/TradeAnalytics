using System.Collections.Generic;
using TradeAnalytics.Domain.Entities;

namespace TradeAnalytics.Application.Features.TradeSecurities.Queries.GetTradeSecurityDetail
{
    public class TradeSecurityDetailVm
    {
        public TradeSecurityDetailVm()
        {
            this.TradeSecurityPerformance = new HashSet<TradeSecurityPerformanceDto>();
            this.TradeSecurityFundamentals = new HashSet<TradeSecurityFundamentalsDto>();
        }
        public int TradeSecurityId { get; set; }
        public int PortfolioId { get; set; }
        public string Name { get; set; }
        public string SecurityCode { get; set; }
        public string Desc { get; set; }
        public ICollection<TradeSecurityPerformanceDto> TradeSecurityPerformance { get; set; }
        public ICollection<TradeSecurityFundamentalsDto> TradeSecurityFundamentals { get; set; }
    }
}