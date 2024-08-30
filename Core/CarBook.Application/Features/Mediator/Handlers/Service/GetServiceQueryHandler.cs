using CarBook.Application.Features.Mediator.Queries.Service;
using CarBook.Application.Features.Mediator.Results.Service;
using CarBook.Application.Interfaces;
using MediatR;
namespace CarBook.Application.Features.Mediator.Handlers.Service
{
    using CarBook.Domain.Entities;
    public class GetServiceQueryHandler : IRequestHandler<GetServiceQuery, IEnumerable<GetServiceQueryResult>>
    {
        private readonly IRepository<Service> repository;
        public GetServiceQueryHandler(IRepository<Service> repository)
        {
            this.repository = repository;
        }

        public async Task<IEnumerable<GetServiceQueryResult>> Handle(GetServiceQuery request, CancellationToken cancellationToken)
        {
            var values = await repository.GetAllAsync();
            return values.Select(x => new GetServiceQueryResult()
            {
                Description = x.Description,
                IconUrl = x.IconUrl,
                ServiceID = x.ServiceID,
                Title = x.Title
            }).ToList();
        }
    }
}
