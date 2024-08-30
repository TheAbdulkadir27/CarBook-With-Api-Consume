using CarBook.Application.Features.Mediator.Commands.Author;
using MediatR;
namespace CarBook.Application.Features.Mediator.Handlers.Author
{
    using CarBook.Application.Interfaces;
    using CarBook.Domain.Entities;
    public class CreateAuthorCommandHandler : IRequestHandler<CreateAuthorCommand>
    {
        private readonly IRepository<Author> repository;
        public CreateAuthorCommandHandler(IRepository<Author> repository) => this.repository = repository;
        public async Task<Unit> Handle(CreateAuthorCommand request, CancellationToken cancellationToken)
        {
            await repository.CreateAsync(new Author()
            {
                Description = request.Description,
                ImageUrl = request.ImageUrl,
                Name = request.Name
            });
            return Unit.Value;
        }
    }
}
