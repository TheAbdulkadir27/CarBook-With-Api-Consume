using CarBook.Application.Features.Mediator.Queries.SocialMedia;
using CarBook.Application.Features.Mediator.Results.SocialMedia;
using CarBook.Application.Interfaces;
using MediatR;
namespace CarBook.Application.Features.Mediator.Handlers.SocialMedia
{
    using CarBook.Domain.Entities;
    public class GetSocialMediaQueryHandler : IRequestHandler<GetSocialMediaQuery, IEnumerable<GetSocialMediaQueryResult>>
    {
        private readonly IRepository<SocialMedia> _repository;
        public GetSocialMediaQueryHandler(IRepository<SocialMedia> repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<GetSocialMediaQueryResult>> Handle(GetSocialMediaQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x => new GetSocialMediaQueryResult()
            {
                SocialMediaID = x.SocialMediaID,
                icon = x.icon,
                Name = x.Name,
                Url = x.Url,
            }).ToList();
        }
    }
}
