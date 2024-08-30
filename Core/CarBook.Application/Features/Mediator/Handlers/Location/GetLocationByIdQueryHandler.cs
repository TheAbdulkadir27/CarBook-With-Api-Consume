using CarBook.Application.Features.Mediator.Queries.Location;
using CarBook.Application.Features.Mediator.Results.Location;
using CarBook.Application.Interfaces;
using MediatR;

namespace CarBook.Application.Features.Mediator.Handlers.Location
{
    using CarBook.Domain.Entities;
    public class GetLocationByIdQueryHandler : IRequestHandler<GetLocationByIdQuery, GetLocationByIdQueryResult>
    {
        private readonly IRepository<Location> _repository;
        public GetLocationByIdQueryHandler(IRepository<Location> repository)
        {
            _repository = repository;
        }

        public async Task<GetLocationByIdQueryResult> Handle(GetLocationByIdQuery request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIDAsync(request.LocationID);
            return new GetLocationByIdQueryResult()
            {
                LocationID = value.LocationID,
                Name = value.Name,
            };
        }
    }
}
