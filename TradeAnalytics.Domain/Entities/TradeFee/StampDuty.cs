using System;
using System.Collections.Generic;
using System.Text;

namespace TradeAnalytics.Domain.Entities.TradeFee
{
    public class StampDuty
    {
        public Guid StampDutyId { get; set; }
        public string State { get; set; }
        public decimal StampDutyPct { get; set; }
    }
}
