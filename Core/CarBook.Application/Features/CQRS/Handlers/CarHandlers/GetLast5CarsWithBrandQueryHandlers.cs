using CarBook.Application.Features.CQRS.Results.CarResults;
using CarBook.Application.Interfaces.CarInterfaces;
namespace CarBook.Application.Features.CQRS.Handlers.CarHandlers
{
    public class GetLast5CarsWithBrandQueryHandlers
    {
        private readonly ICarRepository _repository;
        public GetLast5CarsWithBrandQueryHandlers(ICarRepository repository) => _repository = repository;
        public IQueryable<GetLast5CarsWithBrandQueryResult> Handle()
        {
            var values = _repository.GetLastCarsWithBrand();
            return values.Select(x => new GetLast5CarsWithBrandQueryResult()
            {
                BrandName = x.Brand.Name,
                BrandID = x.BrandID,
                BigImageUrl = x.BigImageUrl,
                CarID = x.CarID,
                CoverImageUrl = x.CoverImageUrl,
                Fuel = x.Fuel,
                Km = x.Km,
                Luggage = x.Luggage,
                Model = x.Model,
                Seat = x.Seat,
                Tranmission = x.Tranmission
            }).ToList().AsQueryable();
        }
    }
}
