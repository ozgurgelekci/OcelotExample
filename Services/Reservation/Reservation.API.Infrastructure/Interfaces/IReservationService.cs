using Reservation.API.Models.Dtos;

namespace Reservation.API.Infrastructure.Interfaces
{
    public interface IReservationService
    {
        ReservationDto GetByBookingNumber(int bookingNumber);
    }
}
