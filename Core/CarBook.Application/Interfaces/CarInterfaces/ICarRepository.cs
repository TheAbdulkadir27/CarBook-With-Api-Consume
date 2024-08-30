using CarBook.Domain.Entities;
namespace CarBook.Application.Interfaces.CarInterfaces
{
    public interface ICarRepository
    {
        IEnumerable<Car> GetCarsListWithBrands();
        IQueryable<Car> GetLastCarsWithBrand();
    }
}
