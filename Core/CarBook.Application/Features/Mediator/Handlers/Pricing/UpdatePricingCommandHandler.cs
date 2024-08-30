using CarBook.Application.Features.Mediator.Commands.Pricing;
using CarBook.Application.Interfaces;
using MediatR;
namespace CarBook.Application.Features.Mediator.Handlers.Pricing
{
    using CarBook.Domain.Entities;
    public class UpdatePricingCommandHandler : IRequestHandler<UpdatePricingCommand>
    {
        private readonly IRepository<Pricing> _repository;
        public UpdatePricingCommandHandler(IRepository<Pricing> repository)
        {
            _repository = repository;
        }

        public async Task<Unit> Handle(UpdatePricingCommand request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIDAsync(request.PricingID);
            value.Name = request.Name;
            await _repository.UpdateAsync(value);
            return Unit.Value;
        }
    }
}
