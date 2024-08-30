namespace CarBook.Domain.Entities
{
    public class Brand
    {
        public int BrandID { get; set; }
        public string Name { get; set; }
        public IEnumerable<Car> Cars { get; set; }
    }
}
