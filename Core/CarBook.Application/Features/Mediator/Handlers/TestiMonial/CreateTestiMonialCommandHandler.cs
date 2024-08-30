using CarBook.Application.Features.Mediator.Commands.TestiMonial;
using CarBook.Application.Interfaces;
using MediatR;
namespace CarBook.Application.Features.Mediator.Handlers.TestiMonial
{
	using CarBook.Domain.Entities;
	public class CreateTestiMonialCommandHandler : IRequestHandler<CreateTestiMonialCommand>
	{
		private readonly IRepository<Testimonial> _repository;
		public CreateTestiMonialCommandHandler(IRepository<Testimonial> repository) => _repository = repository;
		public async Task<Unit> Handle(CreateTestiMonialCommand request, CancellationToken cancellationToken)
		{
			await _repository.CreateAsync(new Testimonial()
			{
				Comment = request.Comment,
				ImageUrl = request.ImageUrl,
				Name = request.Name,
				Title = request.Title,
			});
			return Unit.Value;
		}
	}
}
