using CarBook.Application.Features.Mediator.Commands.Pricing;
using CarBook.Application.Interfaces;
using MediatR;

namespace CarBook.Application.Features.Mediator.Handlers.Pricing
{
    using CarBook.Domain.Entities;
    public class RemovePricingCommandHandler : IRequestHandler<RemovePricingCommand>
    {
        private readonly IRepository<Pricing> _repository;
        public RemovePricingCommandHandler(IRepository<Pricing> repository) => _repository = repository;
        public async Task<Unit> Handle(RemovePricingCommand request, CancellationToken cancellationToken)
        {
            await _repository.RemoveAsync(await _repository.GetByIDAsync(request.PricingID));
            return Unit.Value;
        }
    }
}
