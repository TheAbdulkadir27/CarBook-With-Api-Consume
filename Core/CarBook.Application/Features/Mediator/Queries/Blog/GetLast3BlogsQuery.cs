using CarBook.Application.Features.Mediator.Results.Blog;
using MediatR;

namespace CarBook.Application.Features.Mediator.Queries.Blog
{
    public class GetLast3BlogsQuery : IRequest<IEnumerable<GetLast3BlogsWithAuthorQueryResult>>
    {

    }
}
