using BusinessObjects;
using System.Collections.Generic;

namespace Services
{
    public interface IBookingDetailService
    {
        void AddBookingDetail(BookingDetail bookingDetail);
        void UpdateBookingDetail(BookingDetail bookingDetail);
        void DeleteBookingDetail(int bookingDetailId);
        BookingDetail GetBookingDetail(int bookingDetailId);
        List<BookingDetail> GetBookingDetails();
        List<BookingDetail> GetBookingDetailsByRoomId(int roomId);
    }
}