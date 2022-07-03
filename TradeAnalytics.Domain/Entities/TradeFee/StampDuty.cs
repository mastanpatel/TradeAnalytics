using System;
using System.Collections.Generic;
using System.Text;

namespace TradeAnalytics.Domain.Entities.TradeFee
{
    internal class StampDuty
    {
        public Guid StampDutyId { get; set; }
        public string State { get; set; }
        public decimal StampDutyPct { get; set; }
    }
}
