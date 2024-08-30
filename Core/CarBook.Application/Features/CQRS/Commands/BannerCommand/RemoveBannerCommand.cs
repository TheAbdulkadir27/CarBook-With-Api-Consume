namespace CarBook.Application.Features.CQRS.Commands.BannerCommand
{
    public class RemoveBannerCommand
    {
        public int id { get; set; }
        public RemoveBannerCommand(int id)
        {
            this.id = id;
        }
    }
}
