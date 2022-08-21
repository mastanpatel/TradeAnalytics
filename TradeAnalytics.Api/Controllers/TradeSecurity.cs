using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using TradeAnalytics.Application.Features.TradeSecurities.Commands.CreateTradeSecurity;
using TradeAnalytics.Application.Features.TradeSecurities.Commands.DeleteTradeSecurity;
using TradeAnalytics.Application.Features.TradeSecurities.Commands.UpdateTradeSecurity;
using TradeAnalytics.Application.Features.TradeSecurities.Queries.GetTradeSecurityDetail;
using TradeAnalytics.Application.Features.TradeSecurities.Queries.GetTradeSecurityList;

namespace TradeAnalytics.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TradeSecurity : Controller
    {
        private readonly IMediator _mediator;

        public TradeSecurity(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("all", Name = "GetAllTradeSecurities")]
        public async Task<ActionResult<List<TradeSecurityListVm>>> GetAllTradeSecurities()
        {
            var dtos = await _mediator.Send(new GetTradeSecuirtyListQuery());
            return Ok(dtos);
        }

        [HttpGet("{id}", Name = "GetTradeSecurityDetails")]
        public async Task<ActionResult<List<TradeSecurityDetailVm>>> GetTradeSecurityDetails(int id)
        {
            var getPortfolioDetailQuery = new GetTradeSecurityDetailQuery() { Id = id };

            var dtos = await _mediator.Send(getPortfolioDetailQuery);

            return Ok(dtos);
        }

        [HttpPost(Name = "AddTradeSecurity")]
        public async Task<ActionResult<int>> Create([FromBody] CreateTradeSecurityCommand createTradeSecurityCommand)
        {
            var id = await _mediator.Send(createTradeSecurityCommand);
            return Ok(id);
        }

        [HttpPut(Name = "UpdateTradeSecurity")]
        public async Task<ActionResult> Update([FromBody] UpdateTradeSecurityCommand updateTradeSecurityCommand)
        {
            await _mediator.Send(updateTradeSecurityCommand);
            return NoContent();
        }

        [HttpDelete("{id}", Name = "DeleteSecurity")]
        public async Task<ActionResult> Delete(int id)
        {
            var deleteTradeSecurityCommand = new DeleteTradeSecurityCommand() { TradeSecurityId = id };

            await _mediator.Send(deleteTradeSecurityCommand);

            return NoContent();
        }
    }
}
