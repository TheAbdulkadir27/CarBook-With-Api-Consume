using CarBook.Application.Features.Mediator.Queries.Blog;
using CarBook.Application.Features.Mediator.Results.Blog;
using MediatR;
namespace CarBook.Application.Features.Mediator.Handlers.Blog
{
    using CarBook.Application.Interfaces;
    using CarBook.Domain.Entities;
    public class GetBlogByIdQueryHandler : IRequestHandler<GetBlogByIdQuery, GetBlogByIdQueryResult>
    {
        private readonly IRepository<Blog> _repository;
        public GetBlogByIdQueryHandler(IRepository<Blog> repository)
        {
            _repository = repository;
        }
        public async Task<GetBlogByIdQueryResult> Handle(GetBlogByIdQuery request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIDAsync(request.id);
            return new GetBlogByIdQueryResult()
            {
                BlogID = value.BlogID,
                AuthorID = value.AuthorID,
                CategoryID = value.CategoryID,
                CoverImageUrl = value.CoverImageUrl,
                Title = value.Title
            };
        }
    }
}
