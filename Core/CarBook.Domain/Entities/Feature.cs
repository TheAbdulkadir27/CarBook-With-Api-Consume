namespace CarBook.Domain.Entities
{
    public class Feature
    {
        public int FeatureID { get; set; }
        public string Name { get; set; }
        public IEnumerable<CarFeature>  CarFeatures { get; set; }
    }
}
