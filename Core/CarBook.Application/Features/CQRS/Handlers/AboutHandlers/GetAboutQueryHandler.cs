using CarBook.Application.Features.CQRS.Results.AboutResults;
using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;
namespace CarBook.Application.Features.CQRS.Handlers.AboutHandlers
{
    public class GetAboutQueryHandler
    {
        private readonly IRepository<About> _aboutrepository;
        public GetAboutQueryHandler(IRepository<About> aboutrepository)
        {
            _aboutrepository = aboutrepository;
        }
        public async Task<IEnumerable<GetAboutQueryResult>> Handle()
        {
            var values = await _aboutrepository.GetAllAsync();
            return values.Select(x => new GetAboutQueryResult
            {
                Title = x.Title,
                ImageUrl = x.ImageUrl,
                AboutID = x.AboutID,
                Description = x.Description,
            }).ToList();
        }
    }
}
