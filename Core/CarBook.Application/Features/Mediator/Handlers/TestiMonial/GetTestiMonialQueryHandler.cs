using CarBook.Application.Features.Mediator.Queries.TestiMonial;
using CarBook.Application.Features.Mediator.Results.TestiMonial;
using CarBook.Application.Interfaces;
using MediatR;
namespace CarBook.Application.Features.Mediator.Handlers.TestiMonial
{
	using CarBook.Domain.Entities;
	public class GetTestiMonialQueryHandler : IRequestHandler<GetTestiMonialQuery, IEnumerable<GetTestiMonialQueryResult>>
	{
		private readonly IRepository<Testimonial> _repository;
		public GetTestiMonialQueryHandler(IRepository<Testimonial> repository) => _repository = repository;
		public async Task<IEnumerable<GetTestiMonialQueryResult>> Handle(GetTestiMonialQuery request, CancellationToken cancellationToken)
		{
			var values = await _repository.GetAllAsync();
			return values.Select(x => new GetTestiMonialQueryResult()
			{
				Comment = x.Comment,
				ImageUrl = x.ImageUrl,
				Name = x.Name,
				Title = x.Title
			}).ToList();
		}
	}
}
