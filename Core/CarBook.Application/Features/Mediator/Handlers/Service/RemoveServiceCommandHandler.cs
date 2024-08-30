using CarBook.Application.Features.Mediator.Commands.Service;
using CarBook.Application.Interfaces;
using MediatR;

namespace CarBook.Application.Features.Mediator.Handlers.Service
{
    using CarBook.Domain.Entities;
    public class RemoveServiceCommandHandler : IRequestHandler<RemoveServiceCommand>
    {
        private readonly IRepository<Service> _repository;
        public RemoveServiceCommandHandler(IRepository<Service> repository)
        {
            _repository = repository;
        }

        public async Task<Unit> Handle(RemoveServiceCommand request, CancellationToken cancellationToken)
        {
            await _repository.RemoveAsync(await _repository.GetByIDAsync(request.ServiceID));
            return Unit.Value;
        }
    }
}
