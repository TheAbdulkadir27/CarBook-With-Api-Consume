using MediatR;

namespace CarBook.Application.Features.Mediator.Commands.Pricing
{
    public class RemovePricingCommand : IRequest
    {
        public int PricingID { get; set; }

        public RemovePricingCommand(int pricingID)
        {
            PricingID = pricingID;
        }
    }
}
