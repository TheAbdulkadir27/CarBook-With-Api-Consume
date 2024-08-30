using CarBook.Application.Features.Mediator.Commands.Author;
using MediatR;

namespace CarBook.Application.Features.Mediator.Handlers.Author
{
    using CarBook.Application.Interfaces;
    using CarBook.Domain.Entities;
    public class RemoveAuthorCommandHandler : IRequestHandler<RemovAuthorCommand>
    {
        private readonly IRepository<Author> _repository;
        public RemoveAuthorCommandHandler(IRepository<Author> repository) => _repository = repository;
        public async Task<Unit> Handle(RemovAuthorCommand request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIDAsync(request.AuthorID);
            await _repository.RemoveAsync(value);
            return Unit.Value;
        }
    }
}
