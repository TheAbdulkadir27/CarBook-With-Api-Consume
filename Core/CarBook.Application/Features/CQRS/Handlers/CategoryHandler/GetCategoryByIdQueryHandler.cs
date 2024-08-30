using CarBook.Application.Features.CQRS.Queries.CategoryQueries;
using CarBook.Application.Features.CQRS.Results.CategoryResults;
using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;
using System.Security.AccessControl;

namespace CarBook.Application.Features.CQRS.Handlers.CategoryHandler
{
    public class GetCategoryByIdQueryHandler
    {
        private readonly IRepository<Category> _repository;
        public GetCategoryByIdQueryHandler(IRepository<Category> repository) => _repository = repository;
        public async Task<GetCategoryByIdQueryResults> Handle(GetCategoryByIdQuery command)
        {
            var result = await _repository.GetByIDAsync(command._id);
            return new GetCategoryByIdQueryResults()
            {
                CategoryID = result.CategoryID,
                Name = result.Name,
            };
        }
    }
}
