using CarBook.Application.Features.Mediator.Results.CarPricing;
using MediatR;

namespace CarBook.Application.Features.Mediator.Queries.CarPricing
{
    public class CarPricingQuery : IRequest<IEnumerable<GetCarPricingQueryResult>>
    {

    }
}
