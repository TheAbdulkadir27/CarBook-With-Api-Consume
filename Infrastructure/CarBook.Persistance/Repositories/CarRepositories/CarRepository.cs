using CarBook.Application.Interfaces.CarInterfaces;
using CarBook.Domain.Entities;
using CarBook.Persistance.Context;
using Microsoft.EntityFrameworkCore;

namespace CarBook.Persistance.Repositories.CarRepositories
{
    public class CarRepository : ICarRepository
    {
        private readonly CarBookContext _carBookContext;
        public CarRepository(CarBookContext carBookContext) => _carBookContext = carBookContext;

        public IEnumerable<Car> GetCarsListWithBrands()
        {
            var values = _carBookContext.Cars.Include(x => x.Brand).ToList();
            return values;
        }

        public IQueryable<Car> GetLastCarsWithBrand()
        {
            return _carBookContext.Cars.Include(x => x.Brand)
                .OrderByDescending(x => x.CarID)
                .Take(5).ToList().AsQueryable();
        }
    }
}
