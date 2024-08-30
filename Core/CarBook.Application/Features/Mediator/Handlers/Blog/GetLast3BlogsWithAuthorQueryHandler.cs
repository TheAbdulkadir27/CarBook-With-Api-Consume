using CarBook.Application.Features.Mediator.Queries.Blog;
using CarBook.Application.Features.Mediator.Results.Blog;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
namespace CarBook.Application.Features.Mediator.Handlers.Blog
{
    using CarBook.Application.Interfaces;
    using CarBook.Application.Interfaces.BlogInterfaces;
    using CarBook.Domain.Entities;
    public class GetLast3BlogsWithAuthorQueryHandler : IRequestHandler<GetLast3BlogsQuery, IEnumerable<GetLast3BlogsWithAuthorQueryResult>>
    {
        private readonly IBlogRepository _blogrepository;
        public GetLast3BlogsWithAuthorQueryHandler(IBlogRepository blogrepository) => _blogrepository = blogrepository;
        public async Task<IEnumerable<GetLast3BlogsWithAuthorQueryResult>> Handle(GetLast3BlogsQuery request, CancellationToken cancellationToken)
        {
            var value = await _blogrepository.GetLast3BlogsWithAuthor();
            return value.Select(x => new GetLast3BlogsWithAuthorQueryResult()
            {
                AuthorID = x.AuthorID,
                BlogID = x.BlogID,
                CategoryID = x.CategoryID,
                CoverImageUrl = x.CoverImageUrl,
                Title = x.Title,
                AuthorName = x.Author.Name
            }).ToList();
        }
    }
}
