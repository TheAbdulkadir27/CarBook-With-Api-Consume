namespace CarBook.Application.Features.CQRS.Queries.CarQueries
{
    public class GetCarByIdQuery
    {
        public int _id { get; set; }
        public GetCarByIdQuery(int id)
        {
            _id = id;
        }
    }
}
