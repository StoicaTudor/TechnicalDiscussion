using System.Collections.Generic;
using System.Linq;
using TechnicalTest.Core.Entities;

namespace TechnicalTest.Core.Service.SearchAvailability
{
    public class SearchAvailability : ISearchAvailability
    {
        public IEnumerable<Offer> GetOffersMatchingRequest(OfferRequest offerRequest,
            IEnumerable<Offer> offersSearchPool)
            => offersSearchPool
                .ToList()
                .FindAll(offer => OfferMatchesRequest(offer, offerRequest));

        private bool OfferMatchesRequest(Offer offer, OfferRequest offerRequest)
            => (offer.CheckInDate.Equals(offerRequest.CheckInDate)
                && offer.StayDurationNights == offerRequest.Duration
                && offer.NumberPersons == offerRequest.NrPeople);
    }
}