using BusinessObjects;
using System.Collections.Generic;

namespace Services
{
    public interface IBookingReservationService
    {
        void AddBookingReservation(BookingReservation bookingReservation);
        void UpdateBookingReservation(BookingReservation bookingReservation);
        void DeleteBookingReservation(int bookingReservationId);
        BookingReservation GetBookingReservation(int bookingReservationId);
        List<BookingReservation> GetBookingReservations();
        List<BookingReservation> GetBookingReservationsByCustomerId(int customerId);
    }
}