using CarBook.Application.Features.Mediator.Results.Service;
using MediatR;

namespace CarBook.Application.Features.Mediator.Queries.Service
{
    public class GetServiceByIdQuery : IRequest<GetServiceByIdQueryResult>
    {
        public int ServiceID { get; set; }
        public GetServiceByIdQuery(int serviceID)
        {
            ServiceID = serviceID;
        }
    }
}
