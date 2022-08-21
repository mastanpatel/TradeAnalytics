using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using TradeAnalytics.Application.Features.TradeFees.Commands.CreateTradeFee;
using TradeAnalytics.Application.Features.TradeFees.Commands.DeleteTradeFee;
using TradeAnalytics.Application.Features.TradeFees.Commands.UpdateTradeFee;
using TradeAnalytics.Application.Features.TradeFees.Queries.GetTradeFeeDetail;
using TradeAnalytics.Application.Features.TradeFees.Queries.GetTradeFeeList;

namespace TradeAnalytics.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TradeSecurityFee : Controller
    {
        private readonly IMediator _mediator;

        public TradeSecurityFee(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("all", Name = "GetAllTradeSecurityFees")]
        public async Task<ActionResult<List<TradeFeeListVm>>> GetAllTradeSecurityFees()
        {
            var dtos = await _mediator.Send(new GetTradeFeeListQuery());
            return Ok(dtos);
        }

        [HttpGet("{id}", Name = "GetTradeSecurityFeeDetails")]
        public async Task<ActionResult<List<TradeFeeDetailVm>>> GetTradeSecurityFeeDetails(int id)
        {
            var getPortfolioDetailQuery = new GetTradeFeeDetailQuery() { Id = id };

            var dtos = await _mediator.Send(getPortfolioDetailQuery);

            return Ok(dtos);
        }

        [HttpPost(Name = "AddTradeSecurityFee")]
        public async Task<ActionResult<int>> Create([FromBody] CreateTradeFeeCommand createTradeFeeCommand)
        {
            var id = await _mediator.Send(createTradeFeeCommand);
            return Ok(id);
        }

        [HttpPut(Name = "UpdateTradeSecurityFee")]
        public async Task<ActionResult> Update([FromBody] UpdateTradeFeeCommand updateTradeFeeCommand)
        {
            await _mediator.Send(updateTradeFeeCommand);
            return NoContent();
        }

        [HttpDelete("{id}", Name = "DeleteSecurityFee")]
        public async Task<ActionResult> Delete(int id)
        {
            var deleteTradeSecurityFeeCommand = new DeleteTradeFeeCommand() { TradeSecurityFeeId = id };

            await _mediator.Send(deleteTradeSecurityFeeCommand);

            return NoContent();
        }
    }
}
