using CarBook.Application.Features.Mediator.Commands.Service;
using CarBook.Application.Features.Mediator.Queries.Service;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Carbook.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiceController : ControllerBase
    {
        private readonly IMediator _mediator;
        public ServiceController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var values = await _mediator.Send(new GetServiceQuery());
            return Ok(values);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var value = await _mediator.Send(new GetServiceByIdQuery(id));
            return Ok(value);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateServiceCommand command)
        {
            await _mediator.Send(command);
            return Ok("Başarıyla servis eklendi");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _mediator.Send(new RemoveServiceCommand(id));
            return Ok("Başarıyla Silindi");
        }

        [HttpPut]
        public async Task<IActionResult> Update(UpdateServiceCommand command)
        {
            await _mediator.Send(command);
            return Ok("Başarıyla Güncelleme Yapıldı");
        }
    }
}
