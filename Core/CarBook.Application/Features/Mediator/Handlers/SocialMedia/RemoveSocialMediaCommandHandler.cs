using CarBook.Application.Features.Mediator.Commands.SocialMedia;
using CarBook.Application.Interfaces;
using MediatR;

namespace CarBook.Application.Features.Mediator.Handlers.SocialMedia
{
    using CarBook.Domain.Entities;
    public class RemoveSocialMediaCommandHandler : IRequestHandler<RemoveSocialMediaCommand>
    {
        private readonly IRepository<SocialMedia> _repository;
        public RemoveSocialMediaCommandHandler(IRepository<SocialMedia> repository)
        {
            _repository = repository;
        }

        public async Task<Unit> Handle(RemoveSocialMediaCommand request, CancellationToken cancellationToken)
        {
            await _repository.RemoveAsync(await _repository.GetByIDAsync(request.SocialMediaID));
            return Unit.Value;
        }
    }
}
