using CarBook.Application.Features.Mediator.Queries.Feature;
using CarBook.Application.Features.Mediator.Results.Feature;
using CarBook.Application.Interfaces;
using MediatR;
namespace CarBook.Application.Features.Mediator.Handlers.Feature
{
    using CarBook.Domain.Entities;
    public class GetFeatureQueryHandler : IRequestHandler<GetFeatureQuery, IEnumerable<GetFeatureQueryResult>>
    {
        private readonly IRepository<Feature> _repository;
        public GetFeatureQueryHandler(IRepository<Feature> repository) => _repository = repository;
        public async Task<IEnumerable<GetFeatureQueryResult>> Handle(GetFeatureQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x => new GetFeatureQueryResult()
            {
                FeatureID = x.FeatureID,
                Name = x.Name,
            }).ToList();
        }
    }
}
