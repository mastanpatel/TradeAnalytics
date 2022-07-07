using System;
using System.Collections.Generic;
using System.Text;
using TradeAnalytics.Domain.Common;
using TradeAnalytics.Domain.Enums;

namespace TradeAnalytics.Domain.Entities.TradeFee
{
    public class TradeSecurityFee : AuditableEntity
    {
        public Guid TradeSecurityFeeId { get; set; }
        public Guid TradeSecurityId { get; set; }
        public TradeSecurityTransaction TradeSecurityTransaction { get; set; }
        public Brokerage Brokerage { get; set; }
        public decimal SecurityTransCharge { get; set; }
        public decimal SecurityExchangeCharge { get; set; }
        public decimal TurnOverFee { get; set; }
        public StampDuty StampDuty { get; set; }
        public decimal DPCharge { get; set; }
        public decimal Tax { get; set; }
    }
}
