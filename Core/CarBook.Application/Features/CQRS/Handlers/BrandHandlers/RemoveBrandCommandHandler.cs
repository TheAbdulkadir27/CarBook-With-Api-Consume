﻿using CarBook.Application.Features.CQRS.Commands.BrandCommand;
using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;

namespace CarBook.Application.Features.CQRS.Handlers.BrandHandlers
{
    public class RemoveBrandCommandHandler
    {
        private readonly IRepository<Brand> _repository;
        public RemoveBrandCommandHandler(IRepository<Brand> repository) => _repository = repository;

        public async Task Handle(RemoveBrandCommand command)
        {
            var value = await _repository.GetByIDAsync(command.id);
            await _repository.RemoveAsync(value);
        }
    }
}
