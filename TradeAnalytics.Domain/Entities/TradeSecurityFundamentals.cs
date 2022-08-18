using System;
using System.Collections.Generic;
using System.Text;

namespace TradeAnalytics.Domain.Entities
{
    public class TradeSecurityFundamentals 
    {
        public int TradeSecurityFundamentalsId { get; set; }
        public int TradeSecurityId { get; set; }
        public decimal MarketCap { get; set; }
        public decimal PriceToEarning { get; set; }
        public decimal PriceToBook { get; set; }
        public decimal PriceToEarning_Industry { get; set; }
        public decimal DebtToEquity { get; set; }
        public decimal ReturnOnEquityPerc { get; set; }
        public decimal EarningPerShare { get; set; }
        public decimal DividendYield { get; set; }
        public decimal BookValue { get; set; }
        public decimal FaceValue { get; set; }
        public bool IsCurrent { get; set; }
    }
}
