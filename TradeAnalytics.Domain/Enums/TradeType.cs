using System;
using System.Collections.Generic;
using System.Text;

namespace TradeAnalytics.Domain.Enums
{
    public  enum TradeType
    {
        Intraday = 0,
        Delivery = 1,
        Futures = 3,
        Options = 4
    }
}
