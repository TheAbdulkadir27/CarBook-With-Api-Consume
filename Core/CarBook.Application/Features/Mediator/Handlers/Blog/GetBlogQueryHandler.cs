using CarBook.Application.Features.Mediator.Queries.Blog;
using CarBook.Application.Features.Mediator.Results.Blog;
using MediatR;
namespace CarBook.Application.Features.Mediator.Handlers.Blog
{
    using CarBook.Application.Interfaces;
    using CarBook.Domain.Entities;
    public class GetBlogQueryHandler : IRequestHandler<GetBlogQuery, IEnumerable<GetBlogQueryResult>>
    {
        private readonly IRepository<Blog> _repository;
        public GetBlogQueryHandler(IRepository<Blog> repository) => _repository = repository;
        public async Task<IEnumerable<GetBlogQueryResult>> Handle(GetBlogQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x => new GetBlogQueryResult()
            {
                AuthorID = x.AuthorID,
                BlogID = x.BlogID,
                CategoryID = x.CategoryID,
                CoverImageUrl = x.CoverImageUrl,
                Title = x.Title
            }).ToList();
        }
    }
}
