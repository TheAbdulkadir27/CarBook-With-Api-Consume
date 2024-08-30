using CarBook.Application.Features.Mediator.Results.Location;
using MediatR;
namespace CarBook.Application.Features.Mediator.Queries.Location
{
    public class GetLocationQuery : IRequest<IEnumerable<GetLocationQueryResult>>
    {
      
    }
}
