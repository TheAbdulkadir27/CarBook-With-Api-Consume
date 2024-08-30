namespace CarBook.Application.Features.CQRS.Queries.BannerQueries
{
    public class GetBannerByIdQuery
    {
        public int id { get; set; }
        public GetBannerByIdQuery(int id)
        {
            this.id = id;
        }
    }
}
