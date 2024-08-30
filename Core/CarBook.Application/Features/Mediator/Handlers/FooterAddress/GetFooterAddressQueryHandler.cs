using CarBook.Application.Features.Mediator.Queries.FooterAddress;
using CarBook.Application.Features.Mediator.Results.FooterAddress;
using CarBook.Application.Interfaces;
using MediatR;
namespace CarBook.Application.Features.Mediator.Handlers.FooterAddress
{
    using CarBook.Domain.Entities;
    public class GetFooterAddressQueryHandler : IRequestHandler<GetFooterAddressQuery, IEnumerable<GetFooterAddressQueryResult>>
    {
        private readonly IRepository<FooterAddress> _repository;
        public GetFooterAddressQueryHandler(IRepository<FooterAddress> repository) => _repository = repository;

        public async Task<IEnumerable<GetFooterAddressQueryResult>> Handle(GetFooterAddressQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x => new GetFooterAddressQueryResult()
            {
                Address = x.Address,
                Description = x.Description,
                Email = x.Email,
                FooterAddressID = x.FooterAddressID,
                Phone = x.Phone
            }).ToList();
        }
    }
}
