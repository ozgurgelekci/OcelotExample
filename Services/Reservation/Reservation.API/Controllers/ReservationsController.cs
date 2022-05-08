using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Reservation.API.Infrastructure.Interfaces;
using Reservation.API.Models.Dtos;

namespace Reservation.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReservationsController : ControllerBase
    {
        private readonly IReservationService _reservationService;

        public ReservationsController(IReservationService reservationService)
        {
            _reservationService = reservationService;
        }

        [HttpGet("{bookingNumber}")]
        public ReservationDto Get(int bookingNumber)
        {
            return _reservationService.GetByBookingNumber(bookingNumber);
        }
    }
}
