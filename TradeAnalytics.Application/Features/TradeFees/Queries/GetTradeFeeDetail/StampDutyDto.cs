namespace TradeAnalytics.Application.Features.TradeFees.Queries.GetTradeFeeDetail
{
    public class StampDutyDto
    {
        public int StampDutyId { get; set; }
        public int TradeSecurityFeeId { get; set; }
        public string State { get; set; }
        public decimal StampDutyPct { get; set; }
    }
}