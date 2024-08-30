﻿namespace CarBook.Domain.Entities
{
    public class Pricing
    {
        public int PricingID { get; set; }
        public string Name { get; set; }
        public IEnumerable<CarPricing> carPricings { get; set; }
    }
}
