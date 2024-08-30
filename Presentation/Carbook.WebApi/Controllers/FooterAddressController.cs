using CarBook.Application.Features.Mediator.Commands.FooterAddress;
using CarBook.Application.Features.Mediator.Queries.FooterAddress;
using MediatR;
using Microsoft.AspNetCore.Mvc;
namespace Carbook.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FooterAddressController : ControllerBase
    {
        private readonly IMediator _mediator;
        public FooterAddressController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var values = await _mediator.Send(new GetFooterAddressQuery());
            return Ok(values);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetByid(int id)
        {
            var value = await _mediator.Send(new GetFooterAddressByIdQuery(id));
            return Ok(value);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody]CreateFooterAddressCommand command)
        {
            await _mediator.Send(command);
            return Ok("Başarıyla Ekleme Yapıldı");
        }
        [HttpPut]
        public async Task<IActionResult> Update(UpdateFooterAddressCommand command)
        {
            await _mediator.Send(command);
            return Ok("Başarıyla güncelleme yapıldı");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _mediator.Send(new RemoveFooterAddressCommand(id));
            return Ok("Başarıyla silindi");
        }

    }
}
