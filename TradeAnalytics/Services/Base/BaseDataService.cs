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
