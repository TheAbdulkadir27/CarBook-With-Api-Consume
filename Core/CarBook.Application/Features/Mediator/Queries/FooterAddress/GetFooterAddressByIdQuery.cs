using CarBook.Application.Features.Mediator.Results.FooterAddress;
using MediatR;

namespace CarBook.Application.Features.Mediator.Queries.FooterAddress
{
    public class GetFooterAddressByIdQuery : IRequest<GetFooterAddressByIdQueryResult>
    {
        public int _id { get; set; }
        public GetFooterAddressByIdQuery(int id)
        {
            _id = id;
        }
    }
}
