using MediatR;

namespace CarBook.Application.Features.Mediator.Commands.TestiMonial
{
	public class CreateTestiMonialCommand : IRequest
	{
		public string Name { get; set; }
		public string Title { get; set; }
		public string Comment { get; set; }
		public string ImageUrl { get; set; }
	}
}
