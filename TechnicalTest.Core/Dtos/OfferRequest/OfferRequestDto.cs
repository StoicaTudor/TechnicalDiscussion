using System;
using TechnicalTest.Core.Dtos.User;

namespace TechnicalTest.Core.Dtos.OfferRequest
{
    public class OfferRequestDto
    {
        public DateTime CheckInDate { get; set; }
        public int Duration { get; set; }
        public int NrPeople { get; set; }
        public UserDto UserDto { get; set; }
    }
}