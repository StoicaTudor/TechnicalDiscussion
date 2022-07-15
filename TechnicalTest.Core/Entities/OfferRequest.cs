using System;
using System.Text.Json.Serialization;

namespace TechnicalTest.Core.Entities
{
    public class OfferRequest
    {
        [JsonPropertyName("CheckInDate")] public DateTime CheckInDate { get; set; }

        [JsonPropertyName("Duration")] public int Duration { get; set; }

        [JsonPropertyName("NrPeople")] public int NrPeople { get; set; }

        public User User { get; set; }
    }
}