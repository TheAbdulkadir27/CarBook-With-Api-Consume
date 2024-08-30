using CarBook.Application.Features.Mediator.Commands.FooterAddress;
using CarBook.Application.Interfaces;
using MediatR;

namespace CarBook.Application.Features.Mediator.Handlers.FooterAddress
{
    using CarBook.Domain.Entities;
    public class RemoveFooterAddressCommandHandler : IRequestHandler<RemoveFooterAddressCommand>
    {
        private readonly IRepository<FooterAddress> _repository;
        public RemoveFooterAddressCommandHandler(IRepository<FooterAddress> repository) => _repository = repository;

        public async Task<Unit> Handle(RemoveFooterAddressCommand request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIDAsync(request.FooterAddressID);
            await _repository.RemoveAsync(value);
            return Unit.Value;
        }
    }
}
