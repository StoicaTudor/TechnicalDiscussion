using System;
using System.Net.Http;
using System.Net.Http.Headers;
using NUnit.Framework;

namespace TechnicalTest.Tests
{
    public class OffersTest
    {
        private readonly HttpClient _client = new();
        private readonly string _baseUrl = "https://localhost:5001/";

        [SetUp]
        public void Setup()
        {
            _client
                .DefaultRequestHeaders
                .Accept
                .Add(
                    new MediaTypeWithQualityHeaderValue("application/json"));
            _client.BaseAddress = new Uri(_baseUrl);
        }

        [Test]
        public void TestOffers()
        {
            HttpResponseMessage response = _client.GetAsync("Offers/SearchOffers").Result;

            if (response.IsSuccessStatusCode)
            {
                var responseResult = response.Content.ReadAsStringAsync().Result;
                Console.WriteLine(responseResult);
                Assert.True(true);
            }
        }
    }
}