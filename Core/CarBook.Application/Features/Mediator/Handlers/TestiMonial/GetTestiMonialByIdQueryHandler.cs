using CarBook.Application.Features.Mediator.Queries.TestiMonial;
using CarBook.Application.Features.Mediator.Results.TestiMonial;
using CarBook.Application.Interfaces;
using MediatR;
namespace CarBook.Application.Features.Mediator.Handlers.TestiMonial
{
	using CarBook.Domain.Entities;
	public class GetTestiMonialByIdQueryHandler : IRequestHandler<GetTestiMonialByIdQuery, GetTestiMonialByIdQueryResult>
	{
		private readonly IRepository<Testimonial> _repository;
		public GetTestiMonialByIdQueryHandler(IRepository<Testimonial> repository) => _repository = repository;
		public async Task<GetTestiMonialByIdQueryResult> Handle(GetTestiMonialByIdQuery request, CancellationToken cancellationToken)
		{
			var value  = await _repository.GetByIDAsync(request.TestiMonialId);
			return new GetTestiMonialByIdQueryResult()
			{
				Comment = value.Comment,
				ImageUrl = value.ImageUrl,
				Name = value.Name,
				Title = value.Title
			};
		}
	}
}
