using MediatR;

namespace CarBook.Application.Features.Mediator.Commands.Feature
{
    public class CreateFeatureCommand : IRequest
    {
        public int FeatureID { get; set; }
        public string Name { get; set; }
    }
}
