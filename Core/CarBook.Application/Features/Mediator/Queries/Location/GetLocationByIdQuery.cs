using CarBook.Application.Features.Mediator.Results.Location;
using MediatR;

namespace CarBook.Application.Features.Mediator.Queries.Location
{
    public class GetLocationByIdQuery : IRequest<GetLocationByIdQueryResult>
    {
        public int LocationID { get; set; }

        public GetLocationByIdQuery(int locationID)
        {
            LocationID = locationID;
        }
    }
}
