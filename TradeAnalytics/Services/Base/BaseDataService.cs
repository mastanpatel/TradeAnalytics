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

        //protected Task AddBearerToken()
        //{
        //    if (_context.Session.TryGetValue("token", out _))
        //        _client.HttpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", _context.Session.GetString("token"));

        //    return Task.CompletedTask;
        //}
    }
}
