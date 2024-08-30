using CarBook.Application.Features.Mediator.Commands.Service;
using CarBook.Application.Interfaces;
using MediatR;

namespace CarBook.Application.Features.Mediator.Handlers.Service
{
    using CarBook.Domain.Entities;
    public class UpdateServiceCommandHandler : IRequestHandler<UpdateServiceCommand>
    {
        private readonly IRepository<Service> _repository;
        public UpdateServiceCommandHandler(IRepository<Service> repository)
        {
            _repository = repository;
        }

        public async Task<Unit> Handle(UpdateServiceCommand request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIDAsync(request.ServiceID);
            value.Description = request.Description;
            value.Title = request.Title;
            value.IconUrl = request.IconUrl;
            await _repository.UpdateAsync(value);
            return Unit.Value;
        }
    }
}
