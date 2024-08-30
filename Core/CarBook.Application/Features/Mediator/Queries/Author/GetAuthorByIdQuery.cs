using CarBook.Application.Features.Mediator.Results.Author;
using MediatR;
namespace CarBook.Application.Features.Mediator.Queries.Author
{
    public class GetAuthorByIdQuery : IRequest<GetAuthorByIdQueryResult>
    {
        public int AuthorID { get; set; }
        public GetAuthorByIdQuery(int authorID)
        {
            AuthorID = authorID;
        }
    }
}
