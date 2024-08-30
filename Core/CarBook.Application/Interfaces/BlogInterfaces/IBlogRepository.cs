using CarBook.Domain.Entities;

namespace CarBook.Application.Interfaces.BlogInterfaces
{
    public interface IBlogRepository
    {
        Task<IEnumerable<Blog>> GetLast3BlogsWithAuthor();
    }
}
