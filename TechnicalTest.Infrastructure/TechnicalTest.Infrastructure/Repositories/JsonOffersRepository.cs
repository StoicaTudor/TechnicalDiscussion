using System;
using System.Collections.Generic;
using System.Text.Json;
using TechnicalTest.Core.Entities;
using TechnicalTest.Infrastructure.Entities;

namespace TechnicalTest.Infrastructure.Repositories
{
    public class JsonOffersRepository : IOffersRepository
    {
        public IEnumerable<Offer> GetAll()
        {
            var a = JsonSerializer.Deserialize<IEnumerable<OfferWrapper>>(
                System.IO.File.ReadAllText(@"/home/citadin/Desktop/Offers.json"));

            Console.WriteLine("xx");

            return null;
        }
    }
}