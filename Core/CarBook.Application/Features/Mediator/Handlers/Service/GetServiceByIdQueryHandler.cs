using CarBook.Application.Features.Mediator.Queries.Service;
using CarBook.Application.Features.Mediator.Results.Service;
using CarBook.Application.Interfaces;
using MediatR;
namespace CarBook.Application.Features.Mediator.Handlers.Service
{
    using CarBook.Domain.Entities;
    public class GetServiceByIdQueryHandler : IRequestHandler<GetServiceByIdQuery, GetServiceByIdQueryResult>
    {
        private readonly IRepository<Service> _repository;
        public GetServiceByIdQueryHandler(IRepository<Service> repository)
        {
            _repository = repository;
        }

        public async Task<GetServiceByIdQueryResult> Handle(GetServiceByIdQuery request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIDAsync(request.ServiceID);
            return new GetServiceByIdQueryResult()
            {
                Description = value.Description,
                IconUrl = value.IconUrl,
                Title = value.Title,
            };
        }
    }
}
