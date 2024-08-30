using CarBook.Application.Features.Mediator.Commands.Blog;
using MediatR;

namespace CarBook.Application.Features.Mediator.Handlers.Blog
{
    using CarBook.Application.Interfaces;
    using CarBook.Domain.Entities;
    public class CreateBlogCommandHandler : IRequestHandler<CreateBlogCommand>
    {
        private readonly IRepository<Blog> _repository;
        public CreateBlogCommandHandler(IRepository<Blog> repository) => _repository = repository;
        public async Task<Unit> Handle(CreateBlogCommand request, CancellationToken cancellationToken)
        {
            await _repository.CreateAsync(new Blog()
            {
                Title = request.Title,
                AuthorID = request.AuthorID,
                CategoryID = request.CategoryID,
                CoverImageUrl = request.CoverImageUrl,
                CreateDate = request.CreateDate
            });
            return Unit.Value;
        }
    }
}
