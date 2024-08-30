using CarBook.Domain.Entities;

namespace CarBook.Application.Interfaces.CarPricingInterfaces
{
    public interface ICarPrisingRepository
    {
        Task<IEnumerable<CarPricing>> GetCarWithPricing();
    }
}
