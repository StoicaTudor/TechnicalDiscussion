using System.Collections.Generic;
using TechnicalTest.Core.Entities;

namespace TechnicalTest.Infrastructure.Repositories
{
    public interface IOffersRepository
    {
        IEnumerable<Offer> GetAll();
    }
}