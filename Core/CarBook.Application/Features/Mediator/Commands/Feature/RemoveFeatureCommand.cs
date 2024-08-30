using MediatR;

namespace CarBook.Application.Features.Mediator.Commands.Feature
{
    public class RemoveFeatureCommand : IRequest
    {
        public RemoveFeatureCommand(int featureID)
        {
            FeatureID = featureID;
        }
        public int FeatureID { get; set; }
    }
}
