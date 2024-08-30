using MediatR;
namespace CarBook.Application.Features.Mediator.Handlers.FooterAddress
{
    using CarBook.Application.Features.Mediator.Commands.FooterAddress;
    using CarBook.Application.Interfaces;
    using CarBook.Domain.Entities;
    public class UpdateFooterAddressCommandHandler : IRequestHandler<UpdateFooterAddressCommand>
    {
        private readonly IRepository<FooterAddress> _repository;
        public UpdateFooterAddressCommandHandler(IRepository<FooterAddress> repository) => _repository = repository;
        public async Task<Unit> Handle(UpdateFooterAddressCommand request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIDAsync(request.FooterAddressID);
            value.Description = request.Description;
            value.Address = request.Address;
            value.Phone = request.Phone;
            value.Email = request.Email;
            await _repository.UpdateAsync(value);
            return Unit.Value;
        }
    }
}
