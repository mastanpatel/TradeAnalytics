using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace TradeAnalytics.Services.Base
{
    public class BaseDataService
    {
        public IClient _client;

        public BaseDataService(IClient client)
        {
            _client = client;
        }
    }
}
