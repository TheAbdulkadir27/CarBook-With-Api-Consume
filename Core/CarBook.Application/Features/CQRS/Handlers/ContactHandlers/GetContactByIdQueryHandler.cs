using CarBook.Application.Features.CQRS.Queries.ContactQueries;
using CarBook.Application.Features.CQRS.Results.ContactResults;
using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;

namespace CarBook.Application.Features.CQRS.Handlers.ContactHandlers
{
    public class GetContactByIdQueryHandler
    {
        private readonly IRepository<Contact> _repository;
        public GetContactByIdQueryHandler(IRepository<Contact> repository)
        {
            _repository = repository;
        }
        public async Task<GetContactByIdQueryResult> Handle(GetContactByIdQuery query)
        {
            var value = await _repository.GetByIDAsync(query._id);
            return new GetContactByIdQueryResult()
            {
                ContactID = value.ContactID,
                Email = value.Email,
                Subject = value.Subject,
                Message = value.Message,
                Name = value.Name,
                SendDate = value.SendDate,
            };
        }
    }
}
