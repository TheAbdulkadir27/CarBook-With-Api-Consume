using CarBook.Application.Features.Mediator.Commands.Feature;
using CarBook.Application.Interfaces;
using MediatR;
namespace CarBook.Application.Features.Mediator.Handlers.Feature
{
    using CarBook.Domain.Entities;
    public class RemoveFeatureCommandHandler : IRequestHandler<RemoveFeatureCommand>
    {
        private readonly IRepository<Feature> _repository;
        public RemoveFeatureCommandHandler(IRepository<Feature> repository) => _repository = repository;
        public async Task<Unit> Handle(RemoveFeatureCommand request, CancellationToken cancellationToken)
        {
            await _repository.RemoveAsync(await _repository.GetByIDAsync(request.FeatureID));
            return Unit.Value;
        }
    }
}
