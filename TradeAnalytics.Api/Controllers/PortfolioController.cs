using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
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

        [HttpGet("all",Name = "GetAllPortfolioes")]
        public async Task<ActionResult<List<PortfolioListVm>>> GetAllPortfolioes()
        {
            var dtos = await _mediator.Send(new GetPortfolioListQuery());
            return Ok(dtos);
        }

        [HttpGet(Name = "GetPortfolioDetails")]
        public async Task<ActionResult<List<PortfolioDetailVm>>> GetPortfolioDetails()
        {
            var dtos = await _mediator.Send(new GetPortfolioDetailQuery());
            return Ok(dtos);
        }
    }
}
