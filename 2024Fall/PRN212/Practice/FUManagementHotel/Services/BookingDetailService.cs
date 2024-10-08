using BusinessObjects;
using System.Collections.Generic;
using Repositories;

namespace Services
{
    public class BookingDetailService : IBookingDetailService
    {
        private readonly IBookingDetailRepository _bookingDetailRepository;

        public BookingDetailService(IBookingDetailRepository bookingDetailRepository)
        {
            _bookingDetailRepository = bookingDetailRepository;
        }

        public void AddBookingDetail(BookingDetail bookingDetail)
        {
            _bookingDetailRepository.AddBookingDetail(bookingDetail);
        }

        public void UpdateBookingDetail(BookingDetail bookingDetail)
        {
            _bookingDetailRepository.UpdateBookingDetail(bookingDetail);
        }

        public void DeleteBookingDetail(int bookingDetailId)
        {
            _bookingDetailRepository.DeleteBookingDetail(bookingDetailId);
        }

        public BookingDetail GetBookingDetail(int bookingDetailId)
        {
            return _bookingDetailRepository.GetBookingDetail(bookingDetailId);
        }

        public List<BookingDetail> GetBookingDetails()
        {
            return _bookingDetailRepository.GetBookingDetails();
        }

        public List<BookingDetail> GetBookingDetailsByRoomId(int roomId)
        {
            return _bookingDetailRepository.GetBookingDetailsByRoomId(roomId);
        }
    }
}