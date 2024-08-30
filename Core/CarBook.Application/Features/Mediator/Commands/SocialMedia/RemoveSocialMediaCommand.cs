using MediatR;

namespace CarBook.Application.Features.Mediator.Commands.SocialMedia
{
    public class RemoveSocialMediaCommand : IRequest
    {
        public int SocialMediaID { get; set; }
        public RemoveSocialMediaCommand(int socialMediaID)
        {
            SocialMediaID = socialMediaID;
        }
    }
}
