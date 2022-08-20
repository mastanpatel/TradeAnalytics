namespace TradeAnalytics.Application.Features.TradeFees.Queries.GetTradeFeeList
{
    public class TradeFeeListVm
    {
        public int TradeSecurityId { get; set; }
        public int PortfolioId { get; set; }
        public string Name { get; set; }
        public string SecurityCode { get; set; }
        public string Desc { get; set; }
    }
}