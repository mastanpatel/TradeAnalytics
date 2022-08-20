namespace TradeAnalytics.Application.Features.TradeFees.Commands.CreateTradeFee
{
    public class StampDutyDto
    {
        public int StampDutyId { get; set; }
        public int TradeSecurityFeeId { get; set; }
        public string State { get; set; }
        public decimal StampDutyPct { get; set; }
    }
}