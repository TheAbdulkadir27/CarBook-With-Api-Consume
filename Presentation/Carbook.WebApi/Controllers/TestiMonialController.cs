using CarBook.Application.Features.Mediator.Commands.TestiMonial;
using CarBook.Application.Features.Mediator.Queries.TestiMonial;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Transactions;

namespace Carbook.WebApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class TestiMonialController : ControllerBase
	{
		private readonly IMediator _mediator;
		public TestiMonialController(IMediator mediator)
		{
			_mediator = mediator;
		}

		[HttpGet]
		public async Task<IActionResult> GetAll()
		{
			var values = await _mediator.Send(new GetTestiMonialQuery());
			return Ok(values);
		}

		[HttpGet("{id}")]
		public async Task<IActionResult> GetById(int id)
		{
			return Ok(await _mediator.Send(new GetTestiMonialByIdQuery(id)));
		}

		[HttpPut]
		public async Task<IActionResult> Update(UpdateTestiMonialCommand command)
		{
			await _mediator.Send(command);
			return Ok("Başarıyla Referans Güncellendi");
		}

		[HttpDelete("{id}")]
		public async Task<IActionResult> Delete(int id)
		{
			await _mediator.Send(new RemoveTestiMonialCommand(id));
			return Ok("Başarıyla Referans Silindi");
		}

		[HttpPost]
		public async Task<IActionResult> Create(CreateTestiMonialCommand command)
		{
			await _mediator.Send(command);
			return Ok("Başarıyla Referans Oluşturuldu");
		}
	}
}
