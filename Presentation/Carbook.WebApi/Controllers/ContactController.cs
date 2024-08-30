﻿using CarBook.Application.Features.CQRS.Commands.CarCommand;
using CarBook.Application.Features.CQRS.Commands.ContactCommand;
using CarBook.Application.Features.CQRS.Handlers.ContactHandlers;
using CarBook.Application.Features.CQRS.Queries.ContactQueries;
using Microsoft.AspNetCore.Mvc;

namespace Carbook.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        private readonly GetContactQueryHandler _getContactQueryHandler;
        private readonly GetContactByIdQueryHandler _getContactByIdQueryHandler;
        private readonly CreateContactCommandHandler _createContactCommandHandler;
        private readonly UpdateContactCommandHandler _updateContactCommandHandler;
        private readonly RemoveContactCommandHandler _removeContactCommandHandler;

        public ContactController(GetContactQueryHandler getContactQueryHandler, GetContactByIdQueryHandler getContactByIdQueryHandler, CreateContactCommandHandler createContactCommandHandler, UpdateContactCommandHandler updateContactCommandHandler, RemoveContactCommandHandler removeContactCommandHandler)
        {
            _getContactQueryHandler = getContactQueryHandler;
            _getContactByIdQueryHandler = getContactByIdQueryHandler;
            _createContactCommandHandler = createContactCommandHandler;
            _updateContactCommandHandler = updateContactCommandHandler;
            _removeContactCommandHandler = removeContactCommandHandler;
        }

        [HttpGet]
        public async Task<IActionResult> GetContact()
        {
            var values = await _getContactQueryHandler.Handle();
            return Ok(values);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdContact(int id)
        {
            var value = await _getContactByIdQueryHandler.Handle(new GetContactByIdQuery(id));
            return Ok(value);
        }

        [HttpPost]
        public async Task<IActionResult> CreateContact(CreateContactCommand command)
        {
            await _createContactCommandHandler.Handle(command);
            return Ok("Başarıyla Contact Eklendi");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteContact(int id)
        {
            await _removeContactCommandHandler.Handle(new RemoveContactCommand(id));
            return Ok("Başarıyla Silinme İşlemi Yapıldı");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateContact(UpdateContactCommand command)
        {
            await _updateContactCommandHandler.Handle(command);
            return Ok("Başarıyla Güncelleme İşlemi Yapıldı");
        }
    }
}
