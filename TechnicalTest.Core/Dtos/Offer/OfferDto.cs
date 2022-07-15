using System;

namespace TechnicalTest.Core.Dtos.Offer
{
    public class OfferDto
    {
        public long Id { get; set; }
        public DateTime CheckInDate { get; set; }
        public int StayDurationNights { get; set; }
        public int NumberPersons { get; set; }
        public string ServiceCode { get; set; }
        public string OperatorCode { get; set; }
        public float Price { get; set; }
        public float PricePerAdult { get; set; }
        public float StrikePrice { get; set; }
        public float StrikePricePerAdult { get; set; }
        public string RegionCode { get; set; }
    }
}