using Reservation.API.Infrastructure.Interfaces;
using Reservation.API.Models.Dtos;

namespace Reservation.API.Services.Classes
{
    public class ReservationService : IReservationService
    {
        public ReservationDto GetByBookingNumber(int bookingNumber)
        {
            return new ReservationDto
            {
                BookingNumber = bookingNumber,
                Id = (new Random()).Next(100),
                Amount = (new Random()).Next(10000),
                CheckDate = DateTime.Now.AddDays(30),
                CheckoutDate = DateTime.Now.AddDays(37)
            };
        }
    }
}
