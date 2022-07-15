using System;
using System.Text.Json.Serialization;

namespace TechnicalTest.Core.Entities
{
    public class Offer
    {
        [JsonPropertyName("Id")] public long Id { get; set; }
        [JsonPropertyName("CheckInDate")] public DateTime CheckInDate { get; set; }

        [JsonPropertyName("StayDurationNights")]
        public int StayDurationNights { get; set; }

        [JsonPropertyName("NumberPersons")] public int NumberPersons { get; set; }

        [JsonPropertyName("ServiceCode")] public string ServiceCode { get; set; }

        [JsonPropertyName("OperatorCode")] public string OperatorCode { get; set; }

        [JsonPropertyName("Price")] public float Price { get; set; }

        [JsonPropertyName("PricePerAdult")] public float PricePerAdult { get; set; }

        [JsonPropertyName("StrikePrice")] public float StrikePrice { get; set; }

        [JsonPropertyName("StrikePricePerAdult")]
        public float StrikePricePerAdult { get; set; }

        [JsonPropertyName("RegionCode")] public string RegionCode { get; set; }
    }
}