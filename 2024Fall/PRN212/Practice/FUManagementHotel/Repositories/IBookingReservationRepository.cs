namespace Repositories
{
    using BusinessObjects;
    using System.Collections.Generic;

    public interface IBookingReservationRepository
    {
        void AddBookingReservation(BookingReservation bookingReservation);
        void UpdateBookingReservation(BookingReservation bookingReservation);
        void DeleteBookingReservation(int bookingReservationId);
        BookingReservation GetBookingReservation(int bookingReservationId);
        List<BookingReservation> GetBookingReservations();
        List<BookingReservation> GetBookingReservationsByCustomerId(int customerId);
    }
}