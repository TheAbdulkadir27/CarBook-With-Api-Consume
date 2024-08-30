using CarBook.Application.Features.Mediator.Queries.Pricing;
using CarBook.Application.Features.Mediator.Results.Pricing;
using CarBook.Application.Interfaces;
using MediatR;
namespace CarBook.Application.Features.Mediator.Handlers.Pricing
{
    using CarBook.Domain.Entities;
    public class GetPricingQueryHandler : IRequestHandler<GetPricingQuery, IEnumerable<GetPricingQueryResult>>
    {
        private readonly IRepository<Pricing> _repository;
        public GetPricingQueryHandler(IRepository<Pricing> repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<GetPricingQueryResult>> Handle(GetPricingQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x => new GetPricingQueryResult()
            {
                Name = x.Name,
                PricingID = x.PricingID
            }).ToList();
        }
    }
}
