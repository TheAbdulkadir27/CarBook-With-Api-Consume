using CarBook.Application.Interfaces.CarPricingInterfaces;
using CarBook.Domain.Entities;
using CarBook.Persistance.Context;
using Microsoft.EntityFrameworkCore;

namespace CarBook.Persistance.Repositories.CarPrisingRepositories
{
    public class CarPrisingRepository : ICarPrisingRepository
    {
        private readonly CarBookContext _context;
        public CarPrisingRepository(CarBookContext context) => _context = context;
        public async Task<IEnumerable<CarPricing>> GetCarWithPricing()
        {
            return await _context.CarPricings.Include(x => x.Car)
                .ThenInclude(y => y.Brand)
                .Include(z => z.Pricing).Where(z => z.PricingID == 2).ToListAsync();
        }
    }
}
