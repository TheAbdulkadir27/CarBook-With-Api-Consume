using CarBook.Application.Features.Mediator.Results.Feature;
using MediatR;

namespace CarBook.Application.Features.Mediator.Queries.Feature
{
    public class GetFeatureQuery : IRequest<IEnumerable<GetFeatureQueryResult>>
    {
        
    }
}
