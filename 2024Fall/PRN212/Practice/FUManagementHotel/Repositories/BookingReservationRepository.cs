namespace Repositories;

using BusinessObjects;
using DataAccessLayer;
using System.Collections.Generic;

public class BookingReservationRepository : IBookingReservationRepository
{
    public void AddBookingReservation(BookingReservation bookingReservation)
    {
        BookingReservationDAO.AddBookingReservation(bookingReservation);
    }

    public void UpdateBookingReservation(BookingReservation bookingReservation)
    {
        BookingReservationDAO.UpdateBookingReservation(bookingReservation);
    }

    public void DeleteBookingReservation(int bookingReservationId)
    {
        BookingReservationDAO.DeleteBookingReservation(bookingReservationId);
    }

    public BookingReservation GetBookingReservation(int bookingReservationId)
    {
        return BookingReservationDAO.GetBookingReservation(bookingReservationId);
    }

    public List<BookingReservation> GetBookingReservations()
    {
        return BookingReservationDAO.GetBookingReservations();
    }

    public List<BookingReservation> GetBookingReservationsByCustomerId(int customerId)
    {
        return BookingReservationDAO.GetBookingReservationsByCustomerId(customerId);
    }
}