﻿using CarBook.Application.Features.CQRS.Commands.CategoryCommand;
using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;

namespace CarBook.Application.Features.CQRS.Handlers.CategoryHandler
{
    public class CreateCategoryCommandHandler
    {
        private readonly IRepository<Category> _repository;
        public CreateCategoryCommandHandler(IRepository<Category> repository)
        {
            _repository = repository;
        }
        public async Task Handle(CreateCategoryCommand command)
        {
            await _repository.CreateAsync(new Category()
            {
                Name = command.Name,
            });
        }
    }
}
