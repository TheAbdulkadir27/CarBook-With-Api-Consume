using CarBook.Application.Features.Mediator.Commands.Blog;
using MediatR;
namespace CarBook.Application.Features.Mediator.Handlers.Blog
{
    using CarBook.Application.Interfaces;
    using CarBook.Domain.Entities;
    public class UpdateBlogCommandHandler : IRequestHandler<UpdateBlogCommand>
    {
        private readonly IRepository<Blog> _repository;
        public UpdateBlogCommandHandler(IRepository<Blog> repository) => _repository = repository;
        public async Task<Unit> Handle(UpdateBlogCommand request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIDAsync(request.BlogID);
            value.AuthorID = request.AuthorID;
            value.CreateDate = request.CreateDate;
            value.CategoryID = request.CategoryID;
            value.Title = request.Title;
            value.CoverImageUrl = request.CoverImageUrl;
            value.BlogID = request.BlogID;
            await _repository.UpdateAsync(value);
            return Unit.Value;
        }
    }
}
