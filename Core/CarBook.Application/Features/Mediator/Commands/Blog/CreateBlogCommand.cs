using MediatR;

namespace CarBook.Application.Features.Mediator.Commands.Blog
{
    public class CreateBlogCommand : IRequest
    {
        public string Title { get; set; }
        public int AuthorID { get; set; }
        public string CoverImageUrl { get; set; }
        public DateTime CreateDate { get => DateTime.Now; }
        public int CategoryID { get; set; }
    }
}
