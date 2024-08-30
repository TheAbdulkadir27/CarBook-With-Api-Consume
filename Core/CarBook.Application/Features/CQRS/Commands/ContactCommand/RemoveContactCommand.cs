namespace CarBook.Application.Features.CQRS.Commands.ContactCommand
{
    public class RemoveContactCommand
    {
        public int _id { get; set; }
        public RemoveContactCommand(int id)
        {
            _id = id;
        }
    }
}
