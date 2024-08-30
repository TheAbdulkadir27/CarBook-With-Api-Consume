using CarBook.Application.Features.CQRS.Commands.BannerCommand;
using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;

namespace CarBook.Application.Features.CQRS.Handlers.BannerHandlers
{
    public class UpdateBannerCommandHandler
    {
        private readonly IRepository<Banner> _repository;
        public UpdateBannerCommandHandler(IRepository<Banner> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateBannerCommand command)
        {
            var values = await _repository.GetByIDAsync(command.BannerID);
            values.VideoDescription = command.VideoDescription;
            values.Title = command.Title;
            values.VideoUrl = command.VideoUrl;
            values.Description = command.Description;
            await _repository.UpdateAsync(values);
        }
    }
}
