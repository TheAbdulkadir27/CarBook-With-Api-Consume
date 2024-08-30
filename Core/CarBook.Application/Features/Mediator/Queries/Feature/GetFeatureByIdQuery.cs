using CarBook.Application.Features.Mediator.Results.Feature;
using MediatR;

namespace CarBook.Application.Features.Mediator.Queries.Feature
{
    public class GetFeatureByIdQuery : IRequest<GetFeatureByIdQueryResult>
    {
        public GetFeatureByIdQuery(int id) => _id = id;
        public int _id { get; set; }
    }
}
