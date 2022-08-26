using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using TradeAnalytics.Application.Features.Portfolioes.Commands.CreatePortfolio;
using TradeAnalytics.Application.Features.Portfolioes.Commands.DeletePortfolio;
using TradeAnalytics.Application.Features.Portfolioes.Commands.UpdatePortfolio;
using TradeAnalytics.Application.Features.Portfolioes.Queries.GetPortfolioDetail;
using TradeAnalytics.Application.Features.Portfolioes.Queries.GetPortfolioList;

namespace TradeAnalytics.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PortfolioController : Controller
    {
        private readonly IMediator _mediator;

        public PortfolioController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [Authorize]
        [HttpGet("all",Name = "GetAllPortfolioes")]
        public async Task<ActionResult<List<PortfolioListVm>>> GetAllPortfolioes()
        {
            var dtos = await _mediator.Send(new GetPortfolioListQuery());
            return Ok(dtos);
        }

        [HttpGet("{id}", Name = "GetPortfolioDetails")]
        public async Task<ActionResult<List<PortfolioDetailVm>>> GetPortfolioDetails(int id)
        {
            var getPortfolioDetailQuery = new GetPortfolioDetailQuery() { Id = id };

            var dtos = await _mediator.Send(getPortfolioDetailQuery);

            return Ok(dtos);
        }

        [HttpPost(Name = "AddPortfolio")]
        public async Task<ActionResult<int>> Create([FromBody] CreatePortfolioCommand createPortfolioCommand)
        {
            var id = await _mediator.Send(createPortfolioCommand);
            return Ok(id);
        }

        [HttpPut(Name = "UpdatePortfolio")]
        public async Task<ActionResult> Update([FromBody] UpdatePortfolioCommand updatePortfolioCommand)
        {
            await _mediator.Send(updatePortfolioCommand);
            return NoContent();
        }

        [HttpDelete("{id}",Name = "DeletePortfolio")]
        public async Task<ActionResult> Delete(int id)
        {
            var deletePortfolioCommand = new DeletePortfolioCommand() { PortfolioId = id };

            await _mediator.Send(deletePortfolioCommand);

            return NoContent();
        }
    }
}
