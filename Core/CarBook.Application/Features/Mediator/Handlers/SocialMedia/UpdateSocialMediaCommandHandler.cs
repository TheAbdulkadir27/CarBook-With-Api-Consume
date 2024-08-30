using CarBook.Application.Features.Mediator.Commands.SocialMedia;
using CarBook.Application.Interfaces;
using MediatR;
namespace CarBook.Application.Features.Mediator.Handlers.SocialMedia
{
    using CarBook.Domain.Entities;
    public class UpdateSocialMediaCommandHandler : IRequestHandler<UpdateSocialMediaCommand>
    {
        private readonly IRepository<SocialMedia> _repository;
        public UpdateSocialMediaCommandHandler(IRepository<SocialMedia> repository)
        {
            _repository = repository;
        }

        public async Task<Unit> Handle(UpdateSocialMediaCommand request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIDAsync(request.SocialMediaID);
            value.Url = request.Url;
            value.icon = request.icon;
            value.Name = request.Name;
            await _repository.UpdateAsync(value);
            return Unit.Value;
        }
    }
}
