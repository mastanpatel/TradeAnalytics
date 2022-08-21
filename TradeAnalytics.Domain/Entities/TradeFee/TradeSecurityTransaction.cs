using System;
using System.Collections.Generic;
using System.Text;
using TradeAnalytics.Domain.Enums;

namespace TradeAnalytics.Domain.Entities.TradeFee
{
    public class TradeSecurityTransaction
    {
        public int TradeSecurityTransactionId { get; set; }
        public int TradeSecurityFeeId { get; set; }
        public int TradeQuantity { get; set; }
        public TradeType TradeType { get; set; }
        public decimal BuyPrice { get; set; }
        public decimal SellPrice { get; set; }
        public decimal TurnOver { get; set; }
        public decimal ProfitAndLoss { get; set; }
    }
}
