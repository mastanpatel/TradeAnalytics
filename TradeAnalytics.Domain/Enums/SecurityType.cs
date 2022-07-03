using System;
using System.Collections.Generic;
using System.Text;

namespace TradeAnalytics.Domain.Enums
{
    public enum SecurityType
    {
        Equity = 0,
        FuturesOptions = 1,
        Commodity = 2,
        Forex = 3,
        IndexFunds = 4,
        MutualFunds = 5,
        FixedDeposit = 6
    }
}
