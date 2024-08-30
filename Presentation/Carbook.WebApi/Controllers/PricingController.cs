using CarBook.Application.Features.Mediator.Commands.Pricing;
using CarBook.Application.Features.Mediator.Queries.Pricing;
using MediatR;
using Microsoft.AspNetCore.Mvc;
namespace Carbook.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PricingController : ControllerBase
    {
        private readonly IMediator _mediator;
        public PricingController(IMediator mediator) => _mediator = mediator;

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var values = await _mediator.Send(new GetPricingQuery());
            return Ok(values);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var value = await _mediator.Send(new GetPricingByIdQuery(id));
            return Ok(value);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreatePricingCommand command)
        {
            await _mediator.Send(command);
            return Ok("Başarıyla Ödeme Türü Eklendi");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _mediator.Send(new RemovePricingCommand(id));
            return Ok("Başarıyla Ödeme Türü Silindi");
        }

        [HttpPut]
        public async Task<IActionResult> Update(UpdatePricingCommand command)
        {
            await _mediator.Send(command);
            return Ok("Başarıyla Ödeme Türü Güncellendi");
        }
    }
}
