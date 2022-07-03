using System;
using System.Collections.Generic;
using System.Text;

namespace TradeAnalytics.Domain.Entities
{
    internal class TradeSecurityPerformance
    {
        public DateTime Date { get; set; }
        public decimal OpenPrice { get; set; }
        public decimal PrevClosed { get; set; }
        public decimal Volume { get; set; }
        public decimal Value { get; set; }
        public decimal Week_52_Low { get; set; }
        public decimal Week_52_High { get; set; }
    }
}
