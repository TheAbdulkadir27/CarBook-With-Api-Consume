using CarBook.Application.Features.CQRS.Commands.CategoryCommand;
using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;
namespace CarBook.Application.Features.CQRS.Handlers.CategoryHandler
{
    public class UpdateCategoryCommandHandler
    {
        private readonly IRepository<Category> _repository;
        public UpdateCategoryCommandHandler(IRepository<Category> repository)
        {
            _repository = repository;
        }
        public async Task Handle(UpdateCategoryCommand command)
        {
            var result = await _repository.GetByIDAsync(command.CategoryID);
            result.Name = command.Name;
            await _repository.UpdateAsync(result);
        }
    }
}
