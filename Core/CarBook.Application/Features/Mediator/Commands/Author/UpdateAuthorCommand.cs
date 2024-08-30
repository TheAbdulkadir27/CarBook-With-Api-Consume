using MediatR;

namespace CarBook.Application.Features.Mediator.Commands.Author
{
    public class UpdateAuthorCommand : IRequest
    {
        public int AuthorID { get; set; }
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }
    }
}
