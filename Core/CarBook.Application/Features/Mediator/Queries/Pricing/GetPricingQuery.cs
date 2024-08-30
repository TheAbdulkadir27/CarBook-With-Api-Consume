using CarBook.Application.Features.Mediator.Results.Pricing;
using MediatR;

namespace CarBook.Application.Features.Mediator.Queries.Pricing
{
    public class GetPricingQuery : IRequest<IEnumerable<GetPricingQueryResult>>
    {

    }
}
