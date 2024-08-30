using CarBook.Application.Features.Mediator.Commands.Feature;
using CarBook.Application.Interfaces;
using MediatR;
namespace CarBook.Application.Features.Mediator.Handlers.Feature
{
    using CarBook.Domain.Entities;
    public class UpdateFeatureCommandHandler : IRequestHandler<UpdateFeatureCommand>
    {
        private readonly IRepository<Feature> _repository;
        public UpdateFeatureCommandHandler(IRepository<Feature> repository) => _repository = repository;
        public async Task<Unit> Handle(UpdateFeatureCommand request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIDAsync(request.FeatureID);
            value.FeatureID = request.FeatureID;
            value.Name = request.Name;
            await _repository.UpdateAsync(value);
            return Unit.Value;
        }
    }
}
