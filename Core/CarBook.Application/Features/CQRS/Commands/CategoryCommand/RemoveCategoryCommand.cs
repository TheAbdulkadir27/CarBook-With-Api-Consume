namespace CarBook.Application.Features.CQRS.Commands.CategoryCommand
{
    public class RemoveCategoryCommand
    {
        public RemoveCategoryCommand(int id)
        {
            _id = id;
        }
        public int _id { get; set; }
    }
}
