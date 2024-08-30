using MediatR;

namespace CarBook.Application.Features.Mediator.Commands.TestiMonial
{
	public class RemoveTestiMonialCommand : IRequest
	{
		public int TestiMonialID { get; set; }
		public RemoveTestiMonialCommand(int testiMonialID)
		{
			TestiMonialID = testiMonialID;
		}
	}
}
