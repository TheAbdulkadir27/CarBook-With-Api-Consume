using System.ComponentModel.DataAnnotations;

namespace CarBook.Domain.Entities
{
    public class Car
    {
        [Key]
        public int CarID { get; set; }
        public int BrandID { get; set; }
        public Brand Brand { get; set; }
        public string Model { get; set; }
        public string CoverImageUrl { get; set; }
        public int Km { get; set; }
        public string Tranmission { get; set; }
        public byte Seat { get; set; }
        public byte Luggage { get; set; }
        public string Fuel { get; set; }
        public string BigImageUrl { get; set; }
        public IEnumerable<CarFeature> CarFeatures { get; set; }
        public IEnumerable<CarDescription> CarDescriptions { get; set; }
        public IEnumerable<CarPricing> carPricings { get; set; }

    }
}
