using MediatR;

namespace CarBook.Application.Features.Mediator.Commands.Feature
{
    public class UpdateFeatureCommand : IRequest
    {
        public int FeatureID { get; set; }
        public string Name { get; set; }
    }
}
