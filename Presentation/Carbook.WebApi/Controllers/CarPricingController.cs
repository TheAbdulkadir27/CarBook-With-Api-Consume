using CarBook.Application.Features.Mediator.Queries.CarPricing;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Carbook.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarPricingController : ControllerBase
    {
        private readonly IMediator _mediator;
        public CarPricingController(IMediator mediator) => _mediator = mediator;
     
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var values = await _mediator.Send(new CarPricingQuery());
            return Ok(values);
        }
    }
}
