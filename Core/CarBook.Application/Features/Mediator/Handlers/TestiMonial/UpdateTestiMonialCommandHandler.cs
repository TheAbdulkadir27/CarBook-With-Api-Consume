using CarBook.Application.Features.Mediator.Commands.TestiMonial;
using CarBook.Application.Interfaces;
using MediatR;

namespace CarBook.Application.Features.Mediator.Handlers.TestiMonial
{
	using CarBook.Domain.Entities;
	public class UpdateTestiMonialCommandHandler : IRequestHandler<UpdateTestiMonialCommand>
	{
		private readonly IRepository<Testimonial> _repository;
		public UpdateTestiMonialCommandHandler(IRepository<Testimonial> repository) => _repository = repository;
		public async Task<Unit> Handle(UpdateTestiMonialCommand request, CancellationToken cancellationToken)
		{
			var value = await _repository.GetByIDAsync(request.TestiMonialID);
			value.Title = request.Title;
			value.Comment = request.Comment;
			value.Name = request.Name;
			value.ImageUrl = request.ImageUrl;
			await _repository.UpdateAsync(value);
			return Unit.Value;
		}
	}
}
