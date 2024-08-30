using CarBook.Application.Features.Mediator.Commands.FooterAddress;
using CarBook.Application.Interfaces;
using MediatR;
namespace CarBook.Application.Features.Mediator.Handlers.FooterAddress
{
    using CarBook.Domain.Entities;
    public class CreateFooterAddressCommandHandler : IRequestHandler<CreateFooterAddressCommand>
    {
        private readonly IRepository<FooterAddress> _Repository;
        public CreateFooterAddressCommandHandler(IRepository<FooterAddress> repository) => _Repository = repository;
        public async Task<Unit> Handle(CreateFooterAddressCommand request, CancellationToken cancellationToken)
        {
            await _Repository.CreateAsync(new FooterAddress()
            {
                Address = request.Address,
                Description = request.Description,
                Email = request.Email,
                Phone = request.Phone
            });
            return Unit.Value;
        }
    }
}
