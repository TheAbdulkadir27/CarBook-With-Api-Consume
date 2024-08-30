using MediatR;

namespace CarBook.Application.Features.Mediator.Commands.TestiMonial
{
	public class UpdateTestiMonialCommand : IRequest
	{
		public int TestiMonialID { get; set; }
		public string Name { get; set; }
		public string Title { get; set; }
		public string Comment { get; set; }
		public string ImageUrl { get; set; }
	}
}
