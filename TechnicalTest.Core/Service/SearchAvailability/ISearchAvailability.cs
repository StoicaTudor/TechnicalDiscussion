using System.Collections;
using System.Collections.Generic;
using TechnicalTest.Core.Entities;

namespace TechnicalTest.Core.Service.SearchAvailability
{
    public interface ISearchAvailability
    {
        IEnumerable<Offer> GetOffersMatchingRequest(OfferRequest offerRequest, IEnumerable<Offer> offersSearchPool);
    }
}