﻿namespace CarBook.Application.Features.Mediator.Results.CarPricing
{
    public class GetCarPricingQueryResult
    {
        public int CarPricingID { get; set; }
        public string? Brand { get; set; }
        public string? Model { get; set; }
        public decimal Amount { get; set; }
        public string? CoverImageUrl { get; set; }
    }
}
