using CarBook.Application.Features.Mediator.Queries.Author;
using CarBook.Application.Features.Mediator.Results.Author;
using MediatR;

namespace CarBook.Application.Features.Mediator.Handlers.Author
{
    using CarBook.Application.Interfaces;
    using CarBook.Domain.Entities;
    public class GetAuthorQueryHandler : IRequestHandler<GetAuthorQuery, IEnumerable<GetAuthorsQueryResult>>
    {
        private readonly IRepository<Author> _repository;
        public GetAuthorQueryHandler(IRepository<Author> repository)
        {
            _repository = repository;
        }
        public async Task<IEnumerable<GetAuthorsQueryResult>> Handle(GetAuthorQuery request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetAllAsync();
            return value.Select(x => new GetAuthorsQueryResult()
            {
                AuthorID = x.AuthorID,
                Description = x.Description,
                ImageUrl = x.ImageUrl,
                Name = x.Name
            }).ToList();
        }
    }
}
