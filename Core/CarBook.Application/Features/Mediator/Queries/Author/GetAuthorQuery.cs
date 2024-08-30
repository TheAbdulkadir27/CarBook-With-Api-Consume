using CarBook.Application.Features.Mediator.Results.Author;
using MediatR;
namespace CarBook.Application.Features.Mediator.Queries.Author
{
    public class GetAuthorQuery : IRequest<IEnumerable<GetAuthorsQueryResult>>
    {

    }
}
