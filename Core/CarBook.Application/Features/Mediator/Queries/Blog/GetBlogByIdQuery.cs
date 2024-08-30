using CarBook.Application.Features.Mediator.Results.Blog;
using MediatR;

namespace CarBook.Application.Features.Mediator.Queries.Blog
{
    public class GetBlogByIdQuery : IRequest<GetBlogByIdQueryResult>
    {
        public int id { get; set; }
        public GetBlogByIdQuery(int id)
        {
            this.id = id;
        }
    }
}
