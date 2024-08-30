using CarBook.Application.Features.Mediator.Commands.Location;
using CarBook.Application.Interfaces;
using MediatR;
namespace CarBook.Application.Features.Mediator.Handlers.Location
{
    using CarBook.Domain.Entities;
    public class UpdateLocationCommandHandler : IRequestHandler<UpdateLocationCommand>
    {
        private readonly IRepository<Location> _repository;

        public UpdateLocationCommandHandler(IRepository<Location> repository)
        {
            _repository = repository;
        }

        public async Task<Unit> Handle(UpdateLocationCommand request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIDAsync(request.LocationID);
            value.Name = request.Name;
            await _repository.UpdateAsync(value);
            return Unit.Value;
        }
    }
}
