namespace CarBook.Application.Features.CQRS.Commands.CarCommand
{
    public class RemoveCarCommand
    {
        public int _id { get; set; }
        public RemoveCarCommand(int id)
        {
            _id = id;
        }
    }
}
