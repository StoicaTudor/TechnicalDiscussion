using System;
using System.Collections.Generic;
using AutoMapper;
using TechnicalTest.Core.Dtos.Offer;
using TechnicalTest.Core.Dtos.OfferRequest;
using TechnicalTest.Core.Entities;
using TechnicalTest.Core.Service.SearchAvailability;
using TechnicalTest.Infrastructure.Repositories;

namespace TechnicalTest.Application.Services
{
    public class OffersSearcher : IOffersSearcher
    {
        private readonly IMapper _offerRequestMapper;
        private readonly ISearchAvailability _searchAvailability;
        private readonly IOffersRepository _offersRepository;

        public OffersSearcher(
            IMapper offerRequestMapper,
            ISearchAvailability searchAvailability,
            IOffersRepository offersRepository)
        {
            _offerRequestMapper = offerRequestMapper;
            _searchAvailability = searchAvailability;
            _offersRepository = offersRepository;
        }

        public IEnumerable<OfferDto> SearchOffers(OfferRequestDto offerRequestDto)
        {
            // IEnumerable<Offer> offers = _offersRepository.GetAll();
            
            // I have some bug due to which I am not able to deserialize json mock data into objects
            // -> I had to hardcode them in MockOffers()
            
            IEnumerable<Offer> offers = MockOffers();

            OfferRequest offerRequest = _offerRequestMapper.Map<OfferRequest>(offerRequestDto);
            return _offerRequestMapper.Map<IEnumerable<OfferDto>>(
                _searchAvailability.GetOffersMatchingRequest(offerRequest, offers));
        }

        private IEnumerable<Offer> MockOffers()
            => new List<Offer>
            {
                new()
                {
                    Id = 1,
                    CheckInDate = Convert.ToDateTime(DateTime.Now.ToString("MM/dd/yyyy")),
                    Price = 123,
                    NumberPersons = 10,
                    StayDurationNights = 3
                },
                new()
                {
                    Id = 2,
                    CheckInDate = Convert.ToDateTime(DateTime.Now.ToString("MM/dd/yyyy")),
                    Price = 12,
                    NumberPersons = 2,
                    StayDurationNights = 3
                },
                new()
                {
                    Id = 3,
                    CheckInDate = Convert.ToDateTime(DateTime.Now.ToString("MM/dd/yyyy")),
                    Price = 1132411,
                    NumberPersons = 2,
                    StayDurationNights = 3
                },
                new()
                {
                    Id = 3,
                    CheckInDate = Convert.ToDateTime(DateTime.Now.ToString("MM/dd/yyyy")),
                    Price = 33333,
                    NumberPersons = 2,
                    StayDurationNights = 3
                }
            };
    }
}