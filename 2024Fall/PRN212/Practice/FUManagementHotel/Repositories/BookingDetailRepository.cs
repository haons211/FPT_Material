namespace Repositories;

using BusinessObjects;
using DataAccessLayer;
using System.Collections.Generic;

public class BookingDetailRepository : IBookingDetailRepository
{
    public void AddBookingDetail(BookingDetail bookingDetail)
    {
        BookingDetailDAO.AddBookingDetail(bookingDetail);
    }

    public void UpdateBookingDetail(BookingDetail bookingDetail)
    {
        BookingDetailDAO.UpdateBookingDetail(bookingDetail);
    }

    public void DeleteBookingDetail(int bookingDetailId)
    {
        BookingDetailDAO.DeleteBookingDetail(bookingDetailId);
    }

    public BookingDetail GetBookingDetail(int bookingDetailId)
    {
        return BookingDetailDAO.GetBookingDetail(bookingDetailId);
    }

    public List<BookingDetail> GetBookingDetails()
    {
        return BookingDetailDAO.GetBookingDetails();
    }
    

    public List<BookingDetail> GetBookingDetailsByRoomId(int roomId)
    {
        return BookingDetailDAO.GetBookingDetailsByRoomId(roomId);
    }
}