using CarBook.Application.Features.Mediator.Queries.Pricing;
using CarBook.Application.Features.Mediator.Results.Pricing;
using CarBook.Application.Interfaces;
using MediatR;

namespace CarBook.Application.Features.Mediator.Handlers.Pricing
{
    using CarBook.Domain.Entities;
    public class GetPricingByIdQueryHandler : IRequestHandler<GetPricingByIdQuery, GetPricingByIdQueryResult>
    {
        private readonly IRepository<Pricing> _repository;
        public GetPricingByIdQueryHandler(IRepository<Pricing> repository)
        {
            _repository = repository;
        }

        public async Task<GetPricingByIdQueryResult> Handle(GetPricingByIdQuery request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIDAsync(request.PricingID);
            return new GetPricingByIdQueryResult()
            {
                Name = value.Name,
                PricingID = value.PricingID,
            };
        }
    }
}
