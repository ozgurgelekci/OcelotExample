namespace Reservation.API.Models.Dtos
{
    public class ReservationDto
    {
        public int Id { get; set; }
        public int BookingNumber { get; set; }
        public DateTime? CheckDate { get; set; }
        public DateTime? CheckoutDate { get; set; }
        public DateTime? BookingDate { get; set; }
        public double Amount { get; set; }
    }
}
