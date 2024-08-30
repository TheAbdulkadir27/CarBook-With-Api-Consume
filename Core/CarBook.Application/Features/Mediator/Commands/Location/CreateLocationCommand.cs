using MediatR;

namespace CarBook.Application.Features.Mediator.Commands.Location
{
    public class CreateLocationCommand : IRequest
    {
        public string Name { get; set; }
    }
}
