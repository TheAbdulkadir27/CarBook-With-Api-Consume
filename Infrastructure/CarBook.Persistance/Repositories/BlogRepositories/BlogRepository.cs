using CarBook.Application.Interfaces.BlogInterfaces;
using CarBook.Domain.Entities;
using CarBook.Persistance.Context;
using Microsoft.EntityFrameworkCore;

namespace CarBook.Persistance.Repositories.BlogRepositories
{
    public class BlogRepository : IBlogRepository
    {
        private readonly CarBookContext _carbookcontext;
        public BlogRepository(CarBookContext carbookcontext) => _carbookcontext = carbookcontext;
        public async Task<IEnumerable<Blog>> GetLast3BlogsWithAuthor()
        {
            return await _carbookcontext.Blogs.Include(x => x.Author).OrderByDescending(x => x.BlogID).Take(3).ToListAsync();
        }
    }
}
