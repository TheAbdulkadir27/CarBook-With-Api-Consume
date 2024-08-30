using MediatR;

namespace CarBook.Application.Features.Mediator.Commands.Author
{
    public class RemovAuthorCommand : IRequest
    {
        public int AuthorID { get; set; }
        public RemovAuthorCommand(int authorID)
        {
            AuthorID = authorID;
        }
    }
}
