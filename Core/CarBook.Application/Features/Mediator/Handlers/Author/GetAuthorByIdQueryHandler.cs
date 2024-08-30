using CarBook.Application.Features.Mediator.Queries.Author;
using CarBook.Application.Features.Mediator.Results.Author;
using MediatR;

namespace CarBook.Application.Features.Mediator.Handlers.Author
{
    using CarBook.Application.Interfaces;
    using CarBook.Domain.Entities;
    public class GetAuthorByIdQueryHandler : IRequestHandler<GetAuthorByIdQuery, GetAuthorByIdQueryResult>
    {
        private readonly IRepository<Author> _repository;
        public GetAuthorByIdQueryHandler(IRepository<Author> repository) => _repository = repository;
        public async Task<GetAuthorByIdQueryResult> Handle(GetAuthorByIdQuery request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIDAsync(request.AuthorID);
            return new GetAuthorByIdQueryResult()
            {
                AuthorID = value.AuthorID,
                Description = value.Description,
                ImageUrl = value.ImageUrl,
                Name = value.Name
            };
        }
    }
}
