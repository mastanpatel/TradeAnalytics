﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TradeAnalytics.Application.Exceptions
{
    public class NotFoundException : ApplicationException
    {
        public NotFoundException(string name, string key) 
            : base($"{name} ({key}) is not found")
        {

        }
    }
}
