using CarBook.Application.Features.CQRS.Commands.CarCommand;
using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;

namespace CarBook.Application.Features.CQRS.Handlers.CarHandlers
{
    public class UpdateCarCommandHandler
    {
        private readonly IRepository<Car> _repository;
        public UpdateCarCommandHandler(IRepository<Car> repository) => _repository = repository;
        public async Task Handle(UpdateCarCommand command)
        {
            var values = await _repository.GetByIDAsync(command.CarID);
            values.BrandID = command.CarID;
            values.Model = command.Model;
            values.CoverImageUrl = command.CoverImageUrl;
            values.Km = command.Km;
            values.Tranmission = command.Tranmission;
            values.Seat = command.Seat;
            values.Luggage = command.Luggage;
            values.Fuel = command.Fuel;
            values.BigImageUrl = command.BigImageUrl;
            await _repository.UpdateAsync(values);
        }
    }
}
