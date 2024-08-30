namespace CarBook.Application.Features.CQRS.Commands.BrandCommand
{
    public class RemoveBrandCommand
    {
        public int id { get; set; }
        public RemoveBrandCommand(int id)
        {
            this.id = id;
        }
    }
}
