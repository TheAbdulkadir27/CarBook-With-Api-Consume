namespace CarBook.Application.Features.CQRS.Commands.CategoryCommand
{
    public class UpdateCategoryCommand
    {
        public int CategoryID { get; set; }
        public string Name { get; set; }
    }
}
