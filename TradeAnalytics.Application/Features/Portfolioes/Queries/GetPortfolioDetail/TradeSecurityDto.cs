using System;
using System.Collections.Generic;
using System.Text;
using TradeAnalytics.Domain.Entities;

namespace TradeAnalytics.Application.Features.Portfolioes.Queries.GetPortfolioDetail
{
    public class TradeSecurityDto
    {
        public TradeSecurityDto()
        {
            this.TradeSecurityPerformance = new HashSet<TradeSecurityPerformance>();
            this.TradeSecurityFundamentals = new HashSet<TradeSecurityFundamentals>();
        }
        public int TradeSecurityId { get; set; }
        public int PortfolioId { get; set; }
        public string Name { get; set; }
        public string SecurityCode { get; set; }
        public string Desc { get; set; }
        public ICollection<TradeSecurityPerformance> TradeSecurityPerformance { get; set; }
        public ICollection<TradeSecurityFundamentals> TradeSecurityFundamentals { get; set; }
    }
}
