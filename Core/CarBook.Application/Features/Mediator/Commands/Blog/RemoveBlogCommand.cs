using MediatR;

namespace CarBook.Application.Features.Mediator.Commands.Blog
{
    public class RemoveBlogCommand : IRequest
    {
        public int _blogid { get; set; }
        public RemoveBlogCommand(int blogid)
        {
            _blogid = blogid;
        }
    }
}
