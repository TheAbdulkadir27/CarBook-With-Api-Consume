using CarBook.Application.Features.Mediator.Queries.Location;
using CarBook.Application.Features.Mediator.Results.Location;
using CarBook.Application.Interfaces;
using MediatR;
namespace CarBook.Application.Features.Mediator.Handlers.Location
{
    using CarBook.Domain.Entities;
    public class GetLocationQueryHandler : IRequestHandler<GetLocationQuery, IEnumerable<GetLocationQueryResult>>
    {
        private readonly IRepository<Location> _repository;
        public GetLocationQueryHandler(IRepository<Location> repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<GetLocationQueryResult>> Handle(GetLocationQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x => new GetLocationQueryResult()
            {
                LocationID = x.LocationID,
                Name = x.Name,
            }).ToList();
        }
    }
}
