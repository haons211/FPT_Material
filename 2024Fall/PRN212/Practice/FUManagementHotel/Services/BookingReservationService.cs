using BusinessObjects;
using System.Collections.Generic;
using Repositories;

namespace Services
{
    public class BookingReservationService : IBookingReservationService
    {
        private readonly IBookingReservationRepository _bookingReservationRepository;

        public BookingReservationService(IBookingReservationRepository bookingReservationRepository)
        {
            _bookingReservationRepository = bookingReservationRepository;
        }

        public void AddBookingReservation(BookingReservation bookingReservation)
        {
            _bookingReservationRepository.AddBookingReservation(bookingReservation);
        }

        public void UpdateBookingReservation(BookingReservation bookingReservation)
        {
            _bookingReservationRepository.UpdateBookingReservation(bookingReservation);
        }

        public void DeleteBookingReservation(int bookingReservationId)
        {
            _bookingReservationRepository.DeleteBookingReservation(bookingReservationId);
        }

        public BookingReservation GetBookingReservation(int bookingReservationId)
        {
            return _bookingReservationRepository.GetBookingReservation(bookingReservationId);
        }

        public List<BookingReservation> GetBookingReservations()
        {
            return _bookingReservationRepository.GetBookingReservations();
        }

        public List<BookingReservation> GetBookingReservationsByCustomerId(int customerId)
        {
            return _bookingReservationRepository.GetBookingReservationsByCustomerId(customerId);
        }
    }
}