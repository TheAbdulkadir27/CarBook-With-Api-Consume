using MediatR;

namespace CarBook.Application.Features.Mediator.Commands.Blog
{
    public class UpdateBlogCommand :IRequest
    {
        public int BlogID { get; set; }
        public string Title { get; set; }
        public int AuthorID { get; set; }
        public string CoverImageUrl { get; set; }
        public DateTime CreateDate { get => DateTime.Now; }
        public int CategoryID { get; set; }
    }
}
