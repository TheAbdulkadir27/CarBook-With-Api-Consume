namespace CarBook.Application.Features.CQRS.Queries.CategoryQueries
{
    public class GetCategoryByIdQuery
    {
        public int _id { get; set; }
        public GetCategoryByIdQuery(int id)
        {
            _id = id;
        }
    }
}
