using CarBook.Application.Features.Mediator.Commands.Service;
using CarBook.Application.Features.Mediator.Commands.SocialMedia;
using CarBook.Application.Features.Mediator.Queries.Service;
using CarBook.Application.Features.Mediator.Queries.SocialMedia;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Carbook.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SocialMediaController : ControllerBase
    {
        private readonly IMediator _mediator;
        public SocialMediaController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var values = await _mediator.Send(new GetSocialMediaQuery());
            return Ok(values);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var value = await _mediator.Send(new GetSocialMediaByIdQuery(id));
            return Ok(value);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateSocialMediaCommand command)
        {
            await _mediator.Send(command);
            return Ok("Başarıyla  eklendi");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _mediator.Send(new RemoveSocialMediaCommand(id));
            return Ok("Başarıyla Silindi");
        }

        [HttpPut]
        public async Task<IActionResult> Update(UpdateSocialMediaCommand command)
        {
            await _mediator.Send(command);
            return Ok("Başarıyla Güncelleme Yapıldı");
        }
    }
}
