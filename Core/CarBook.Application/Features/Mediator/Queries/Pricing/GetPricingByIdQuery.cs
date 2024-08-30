using CarBook.Application.Features.Mediator.Results.Pricing;
using MediatR;

namespace CarBook.Application.Features.Mediator.Queries.Pricing
{
    public class GetPricingByIdQuery : IRequest<GetPricingByIdQueryResult>
    {
        public int PricingID { get; set; }
        public GetPricingByIdQuery(int pricingID)
        {
            PricingID = pricingID;
        }
    }
}
