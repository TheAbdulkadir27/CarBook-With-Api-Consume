namespace CarBook.Dtos.CarDtos
{
    public class GetCarPricingWithCarDto
    {
        public int CarPricingID { get; set; }
        public string? Brand { get; set; }
        public string? Model { get; set; }
        public decimal Amount { get; set; }
        public string? CoverImageUrl { get; set; }
    }
}
