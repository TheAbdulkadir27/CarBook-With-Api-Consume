using CarBook.Application.Features.Mediator.Commands.SocialMedia;
using CarBook.Application.Interfaces;
using MediatR;

namespace CarBook.Application.Features.Mediator.Handlers.SocialMedia
{
    using CarBook.Domain.Entities;
    public class CreateSocialMediaCommandHandler : IRequestHandler<CreateSocialMediaCommand>
    {
        private readonly IRepository<SocialMedia> _repository;
        public CreateSocialMediaCommandHandler(IRepository<SocialMedia> repository)
        {
            _repository = repository;
        }

        public async Task<Unit> Handle(CreateSocialMediaCommand request, CancellationToken cancellationToken)
        {
            await _repository.CreateAsync(new SocialMedia()
            {
                icon = request.icon,
                Name = request.Name,
                Url = request.Url,
            });
            return Unit.Value;
        }
    }
}
