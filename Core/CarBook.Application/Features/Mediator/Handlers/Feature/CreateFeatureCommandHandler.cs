using CarBook.Application.Features.Mediator.Commands.Feature;
using CarBook.Application.Interfaces;
using MediatR;
namespace CarBook.Application.Features.Mediator.Handlers.Feature
{
    using CarBook.Domain.Entities;
    public class CreateFeatureCommandHandler : IRequestHandler<CreateFeatureCommand>
    {
        private readonly IRepository<Feature> _repository;
        public CreateFeatureCommandHandler(IRepository<Feature> repository) => _repository = repository;

        public async Task<Unit> Handle(CreateFeatureCommand request, CancellationToken cancellationToken)
        {
            await _repository.CreateAsync(new Feature()
            {
                FeatureID = request.FeatureID,
                Name = request.Name,
            });
            return Unit.Value;
        }
    }
}
