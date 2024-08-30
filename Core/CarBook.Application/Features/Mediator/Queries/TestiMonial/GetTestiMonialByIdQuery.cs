using CarBook.Application.Features.Mediator.Results.TestiMonial;
using MediatR;

namespace CarBook.Application.Features.Mediator.Queries.TestiMonial
{
	public class GetTestiMonialByIdQuery : IRequest<GetTestiMonialByIdQueryResult>
	{
		public GetTestiMonialByIdQuery(int testiMonialId)
		{
			TestiMonialId = testiMonialId;
		}
		public int TestiMonialId { get; set; }
    }
}
