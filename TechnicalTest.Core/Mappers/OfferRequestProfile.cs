using AutoMapper;
using TechnicalTest.Core.Dtos.Offer;
using TechnicalTest.Core.Dtos.OfferRequest;
using TechnicalTest.Core.Entities;

namespace TechnicalTest.Core.Mappers
{
    public class OfferRequestProfile : Profile
    {
        public OfferRequestProfile()
        {
            CreateMap<OfferRequest, OfferRequestDto>();
            CreateMap<OfferRequestDto, OfferRequest>();
        }
    }
}