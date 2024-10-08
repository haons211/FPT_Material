namespace Repositories
{
    using BusinessObjects;
    using System.Collections.Generic;

    public interface IBookingDetailRepository
    {
        void AddBookingDetail(BookingDetail bookingDetail);
        void UpdateBookingDetail(BookingDetail bookingDetail);
        void DeleteBookingDetail(int bookingDetailId);
        BookingDetail GetBookingDetail(int bookingDetailId);
        List<BookingDetail> GetBookingDetails();
        List<BookingDetail> GetBookingDetailsByRoomId(int roomId);
    }
}