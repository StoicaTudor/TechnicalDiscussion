#nullable enable
using System.Collections.Generic;
using System.Text.Json.Serialization;
using TechnicalTest.Core.Entities;

namespace TechnicalTest.Infrastructure.Entities
{
    public class OfferWrapper
    {
        [JsonPropertyName("Offers")]
        public IEnumerable<Offer>? Offers { get; set; }
    }
}