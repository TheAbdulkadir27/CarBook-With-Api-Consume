using CarBook.Application.Features.Mediator.Commands.Author;
using MediatR;

namespace CarBook.Application.Features.Mediator.Handlers.Author
{
    using CarBook.Application.Interfaces;
    using CarBook.Domain.Entities;
    public class UpdateAuthorCommandHandler : IRequestHandler<UpdateAuthorCommand>
    {
        private readonly IRepository<Author> _repository;
        public UpdateAuthorCommandHandler(IRepository<Author> repository) => _repository = repository;
        public async Task<Unit> Handle(UpdateAuthorCommand request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIDAsync(request.AuthorID);
            value.Description = request.Description;
            value.ImageUrl = request.ImageUrl;
            value.Name = request.Name;
            await _repository.UpdateAsync(value);
            return Unit.Value;
        }
    }
}
