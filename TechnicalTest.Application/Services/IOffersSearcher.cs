using System.Collections.Generic;
using TechnicalTest.Core.Dtos.Offer;
using TechnicalTest.Core.Dtos.OfferRequest;

namespace TechnicalTest.Application.Services
{
    public interface IOffersSearcher
    {
        public IEnumerable<OfferDto> SearchOffers(OfferRequestDto offerRequestDto);
    }
}