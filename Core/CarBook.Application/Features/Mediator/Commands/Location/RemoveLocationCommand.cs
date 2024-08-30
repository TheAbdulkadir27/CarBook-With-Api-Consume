using MediatR;

namespace CarBook.Application.Features.Mediator.Commands.Location
{
    public class RemoveLocationCommand : IRequest
    {
        public RemoveLocationCommand(int locationID)
        {
            LocationID = locationID;
        }
        public int LocationID { get; set; }
    }
}
