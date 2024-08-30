using CarBook.Application.Features.Mediator.Commands.Feature;
using CarBook.Application.Features.Mediator.Queries.Feature;
using MediatR;
using Microsoft.AspNetCore.Mvc;
namespace Carbook.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FeaturesController : ControllerBase
    {
        private readonly IMediator _mediator;
        public FeaturesController(IMediator mediator) => _mediator = mediator;

        [HttpGet]
        public async Task<IActionResult> GetFeatures()
        {
            var values = await _mediator.Send(new GetFeatureQuery());
            return Ok(values);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetFeatures(int id)
        {
            var value = await _mediator.Send(new GetFeatureByIdQuery(id));
            return Ok(value);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> RemoveFeatures(int id)
        {
            await _mediator.Send(new RemoveFeatureCommand(id));
            return Ok("Başarıyla Özellik Silindi");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateFeatures(UpdateFeatureCommand command)
        {
            await _mediator.Send(command);
            return Ok("Başarıyla özellik Güncellendi");
        }
        [HttpPost]
        public async Task<IActionResult> CreateFeatures(CreateFeatureCommand command)
        {
            await _mediator.Send(command);
            return Ok("Başarıyla Özellik Eklendi");
        }
    }
}
