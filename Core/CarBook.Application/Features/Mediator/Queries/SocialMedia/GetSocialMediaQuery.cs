using CarBook.Application.Features.Mediator.Results.SocialMedia;
using MediatR;

namespace CarBook.Application.Features.Mediator.Queries.SocialMedia
{
    public class GetSocialMediaQuery : IRequest<IEnumerable<GetSocialMediaQueryResult>>
    {
    }
}
