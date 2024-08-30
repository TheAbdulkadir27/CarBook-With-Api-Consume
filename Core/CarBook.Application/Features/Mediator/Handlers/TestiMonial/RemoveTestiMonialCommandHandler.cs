using CarBook.Application.Features.Mediator.Commands.TestiMonial;
using CarBook.Application.Interfaces;
using MediatR;
namespace CarBook.Application.Features.Mediator.Handlers.TestiMonial
{
	using CarBook.Domain.Entities;
	public class RemoveTestiMonialCommandHandler : IRequestHandler<RemoveTestiMonialCommand>
	{
		private readonly IRepository<Testimonial> _Repository;
		public RemoveTestiMonialCommandHandler(IRepository<Testimonial> repository) => _Repository = repository;
		public async Task<Unit> Handle(RemoveTestiMonialCommand request, CancellationToken cancellationToken)
		{
			await _Repository.RemoveAsync(await _Repository.GetByIDAsync(request.TestiMonialID));
			return Unit.Value;
		}
	}
}
