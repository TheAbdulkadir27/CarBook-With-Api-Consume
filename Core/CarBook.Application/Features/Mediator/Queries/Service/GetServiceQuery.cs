using CarBook.Application.Features.Mediator.Results.Service;
using MediatR;

namespace CarBook.Application.Features.Mediator.Queries.Service
{
    public class GetServiceQuery : IRequest<IEnumerable<GetServiceQueryResult>>
    {

    }
}
