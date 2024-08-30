using CarBook.Application.Features.Mediator.Commands.Blog;
using MediatR;
namespace CarBook.Application.Features.Mediator.Handlers.Blog
{
    using CarBook.Application.Interfaces;
    using CarBook.Domain.Entities;
    public class RemoveBlogCommandHandler : IRequestHandler<RemoveBlogCommand>
    {
        private readonly IRepository<Blog> _repository;
        public RemoveBlogCommandHandler(IRepository<Blog> repository) => _repository = repository;
        public async Task<Unit> Handle(RemoveBlogCommand request, CancellationToken cancellationToken)
        {
            await _repository.RemoveAsync(await _repository.GetByIDAsync(request._blogid));
            return Unit.Value;
        }
    }
}
