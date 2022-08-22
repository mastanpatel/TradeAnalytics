using System.Net.Http;

namespace TradeAnalytics.Services.Base
{
    public partial interface IClient
    {
        public HttpClient HttpClient { get; }
    }
}
