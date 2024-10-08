namespace DataAccessLayer;
using BusinessObjects;

public class BookingDetailDAO
{
    public static void AddBookingDetail(BookingDetail bookingDetail)
    {
        using var context = new FuminiHotelManagementContext();
        context.BookingDetails.Add(bookingDetail);
        context.SaveChanges();
    }

    // Update an existing booking detail in the database
    public static void UpdateBookingDetail(BookingDetail bookingDetail)
    {
        using var context = new FuminiHotelManagementContext();
        context.BookingDetails.Update(bookingDetail);
        context.SaveChanges();
    }

    // Delete a booking detail by ID
    public static void DeleteBookingDetail(int bookingDetailId)
    {
        using var context = new FuminiHotelManagementContext();
        var bookingDetail = context.BookingDetails.Find(bookingDetailId);
        if (bookingDetail != null)
        {
            context.BookingDetails.Remove(bookingDetail);
            context.SaveChanges();
        }
    }

    // Get a booking detail by ID
    public static BookingDetail GetBookingDetail(int bookingDetailId)
    {
        using var context = new FuminiHotelManagementContext();
        return context.BookingDetails.Find(bookingDetailId);
    }

    // Get all booking details
    public static List<BookingDetail> GetBookingDetails()
    {
        using var context = new FuminiHotelManagementContext();
        return context.BookingDetails.ToList();
    }

    // Get booking details by room ID
    public static List<BookingDetail> GetBookingDetailsByRoomId(int roomId)
    {
        using var context = new FuminiHotelManagementContext();
        return context.BookingDetails
            .Where(bd => bd.RoomId == roomId)
            .ToList();
    }
}