using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TradeAnalytics.Application.Models.Authentication;

namespace TradeAnalytics.Application.Contracts
{
    public interface ILoggedInUserService
    {
        public string UserId { get; }
        Task<LoginDetails> getUserDetailsAsync();
    }
}
