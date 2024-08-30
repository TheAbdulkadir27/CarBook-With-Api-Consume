using CarBook.Application.Features.Mediator.Results.SocialMedia;
using MediatR;

namespace CarBook.Application.Features.Mediator.Queries.SocialMedia
{
    public class GetSocialMediaByIdQuery : IRequest<GetSocialMediaByIdQueryResult>
    {
        public int SocialMediaID { get; set; }
        public GetSocialMediaByIdQuery(int socialMediaID)
        {
            SocialMediaID = socialMediaID;
        }
    }
}
