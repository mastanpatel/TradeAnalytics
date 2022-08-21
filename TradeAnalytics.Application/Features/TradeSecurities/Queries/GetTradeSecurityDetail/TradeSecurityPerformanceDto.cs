using System;
using System.Collections.Generic;
using System.Text;

namespace TradeAnalytics.Application.Features.TradeSecurities.Queries.GetTradeSecurityDetail
{
    public class TradeSecurityPerformanceDto
    {
        public int TradeSecurityPerformanceId { get; set; }
        public int TradeSecurityId { get; set; }
        public DateTime Date { get; set; }
        public decimal OpenPrice { get; set; }
        public decimal PrevClosed { get; set; }
        public decimal Volume { get; set; }
        public decimal Value { get; set; }
        public decimal Week_52_Low { get; set; }
        public decimal Week_52_High { get; set; }
        public bool IsCurrent { get; set; }
    }
}
