using CarBook.Application.Features.Mediator.Queries.SocialMedia;
using CarBook.Application.Features.Mediator.Results.SocialMedia;
using CarBook.Application.Interfaces;
using MediatR;
namespace CarBook.Application.Features.Mediator.Handlers.SocialMedia
{
    using CarBook.Domain.Entities;
    public class GetSocialMediaByIdQueryHandler : IRequestHandler<GetSocialMediaByIdQuery, GetSocialMediaByIdQueryResult>
    {
        private readonly IRepository<SocialMedia> _repository;
        public GetSocialMediaByIdQueryHandler(IRepository<SocialMedia> repository)
        {
            _repository = repository;
        }

        public async Task<GetSocialMediaByIdQueryResult> Handle(GetSocialMediaByIdQuery request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIDAsync(request.SocialMediaID);
            return new GetSocialMediaByIdQueryResult()
            {
                icon = value.icon,
                SocialMediaID = value.SocialMediaID,
                Name = value.Name,
                Url = value.Url,
            };
        }
    }
}
