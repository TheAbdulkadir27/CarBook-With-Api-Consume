﻿using CarBook.Application.Features.CQRS.Commands.ContactCommand;
using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;

namespace CarBook.Application.Features.CQRS.Handlers.ContactHandlers
{
    public class UpdateContactCommandHandler
    {
        private readonly IRepository<Contact> _repository;

        public UpdateContactCommandHandler(IRepository<Contact> repository)
        {
            _repository = repository;
        }
        public async Task Handle(UpdateContactCommand command)
        {
            var values = await _repository.GetByIDAsync(command.ContactID);
            values.Email = command.Email;
            values.SendDate = command.SendDate;
            values.Subject = command.Subject;
            values.Message = command.Message;
            values.Name = command.Name;
            await _repository.UpdateAsync(values);
        }
    }
}
