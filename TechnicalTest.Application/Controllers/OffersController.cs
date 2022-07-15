#nullable enable
using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using TechnicalTest.Application.Services;
using TechnicalTest.Core.Dtos.Offer;
using TechnicalTest.Core.Dtos.OfferRequest;
using Unity;

namespace TechnicalTest.Application.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OffersController : ControllerBase
    {
        private readonly IOffersSearcher _offersSearcher;

        public OffersController()
        {
            var container = IocConfig.GetConfiguredContainer();
            _offersSearcher = container.Resolve<IOffersSearcher>();
        }

        [HttpPost("SearchOffers")]
        public IEnumerable<OfferDto> SearchOffers(OfferRequestDto offerRequestDto)
        {
            if (offerRequestDto.Duration <= 0 || offerRequestDto.NrPeople <= 0)
                throw new Exception("Invalid Request");

            return _offersSearcher.SearchOffers(offerRequestDto);
        }
    }
}