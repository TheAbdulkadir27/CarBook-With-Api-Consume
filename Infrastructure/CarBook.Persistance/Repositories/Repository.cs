using CarBook.Application.Interfaces;
using CarBook.Persistance.Context;
using Microsoft.EntityFrameworkCore;

namespace CarBook.Persistance.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly CarBookContext _carbookContext;
        public Repository(CarBookContext carbookContext)
        {
            _carbookContext = carbookContext;
        }

        public async Task CreateAsync(T Entity)
        {
            _carbookContext.Set<T>().Add(Entity);
            await _carbookContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _carbookContext.Set<T>().ToListAsync();
        }

        public async Task<T> GetByIDAsync(int id)
        {
            return await _carbookContext.Set<T>().FindAsync(id);
        }

        public async Task RemoveAsync(T Entity)
        {
            _carbookContext.Set<T>().Remove(Entity);
            await _carbookContext.SaveChangesAsync();
        }

        public async Task UpdateAsync(T Entity)
        {
            _carbookContext.Set<T>().Update(Entity);
            await _carbookContext.SaveChangesAsync();
        }
    }
}
