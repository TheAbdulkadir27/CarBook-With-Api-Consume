using MediatR;

namespace CarBook.Application.Features.Mediator.Commands.Pricing
{
    public class CreatePricingCommand : IRequest
    {
        public string Name { get; set; }
    }
}
