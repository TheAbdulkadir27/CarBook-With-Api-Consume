using CarBook.Application.Features.Mediator.Results.Blog;
using MediatR;
namespace CarBook.Application.Features.Mediator.Queries.Blog
{
    public class GetBlogQuery : IRequest<IEnumerable<GetBlogQueryResult>>
    {
    }
}
