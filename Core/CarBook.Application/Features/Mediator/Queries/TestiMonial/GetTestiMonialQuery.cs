using CarBook.Application.Features.Mediator.Results.TestiMonial;
using MediatR;

namespace CarBook.Application.Features.Mediator.Queries.TestiMonial
{
	public class GetTestiMonialQuery : IRequest<IEnumerable<GetTestiMonialQueryResult>>
	{
	}
}
