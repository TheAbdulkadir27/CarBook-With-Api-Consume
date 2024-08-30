namespace CarBook.Application.Features.CQRS.Commands.BrandCommand
{
    public class UpdateBrandCommand
    {
        public int BrandID { get; set; }
        public string Name { get; set; }
    }
}
