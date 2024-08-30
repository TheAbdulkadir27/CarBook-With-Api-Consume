namespace CarBook.Application.Features.CQRS.Queries.ContactQueries
{
    public class GetContactByIdQuery
    {
        public int _id { get; set; }
        public GetContactByIdQuery(int id)
        {
            _id = id;
        }
    }
}
