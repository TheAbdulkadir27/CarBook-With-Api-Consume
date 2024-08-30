using CarBook.Application.Features.Mediator.Queries.CarPricing;
using CarBook.Application.Features.Mediator.Results.CarPricing;
using CarBook.Application.Interfaces.CarPricingInterfaces;
using MediatR;
namespace CarBook.Application.Features.Mediator.Handlers.CarPricing
{
    public class GetCarPricingQueryHandler : IRequestHandler<CarPricingQuery, IEnumerable<GetCarPricingQueryResult>>
    {
        private readonly ICarPrisingRepository _carPrisingRepository;
        public GetCarPricingQueryHandler(ICarPrisingRepository carPrisingRepository) => _carPrisingRepository = carPrisingRepository;
        public async Task<IEnumerable<GetCarPricingQueryResult>> Handle(CarPricingQuery request, CancellationToken cancellationToken)
        {
            var values = await _carPrisingRepository.GetCarWithPricing();
            return values.Select(x => new GetCarPricingQueryResult()
            {
                Amount = x.Amount,
                Brand = x.Car.Brand.Name,
                CarPricingID = x.CarPricingID,
                CoverImageUrl = x.Car.CoverImageUrl,
                Model = x.Car.Model
            }).ToList();
        }
    }
}
