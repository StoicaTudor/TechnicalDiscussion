using AutoMapper;
using TechnicalTest.Core.Dtos.Offer;
using TechnicalTest.Core.Entities;

namespace TechnicalTest.Core.Mappers
{
    public class OfferProfile : Profile
    {
        public OfferProfile()
        {
            CreateMap<Offer, OfferDto>();
            CreateMap<OfferDto, Offer>();
        }
    }
}