using CarBook.Application.Features.Mediator.Queries.Feature;
using CarBook.Application.Features.Mediator.Results.Feature;
using CarBook.Application.Interfaces;
using MediatR;
namespace CarBook.Application.Features.Mediator.Handlers.Feature
{
    using CarBook.Domain.Entities;
    public class GetFeatureByIdQueryHandler : IRequestHandler<GetFeatureByIdQuery, GetFeatureByIdQueryResult>
    {
        private readonly IRepository<Feature> _repository;
        public GetFeatureByIdQueryHandler(IRepository<Feature> repository) => _repository = repository;
        public async Task<GetFeatureByIdQueryResult> Handle(GetFeatureByIdQuery request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIDAsync(request._id);
            return new GetFeatureByIdQueryResult()
            {
                FeatureID = value.FeatureID,
                Name = value.Name,
            };
        }
    }
}
