namespace DataAccessLayer;
using BusinessObjects;

public class BookingReservationDAO
{
    public static void AddBookingReservation(BookingReservation bookingReservation)
    {
        using var context = new FuminiHotelManagementContext();
        context.BookingReservations.Add(bookingReservation);
        context.SaveChanges();
    }

    // Update an existing booking reservation in the database
    public static void UpdateBookingReservation(BookingReservation bookingReservation)
    {
        using var context = new FuminiHotelManagementContext();
        context.BookingReservations.Update(bookingReservation);
        context.SaveChanges();
    }

    // Delete a booking reservation by ID
    public static void DeleteBookingReservation(int bookingReservationId)
    {
        using var context = new FuminiHotelManagementContext();
        var bookingReservation = context.BookingReservations.Find(bookingReservationId);
        if (bookingReservation != null)
        {
            context.BookingReservations.Remove(bookingReservation);
            context.SaveChanges();
        }
    }

    // Get a booking reservation by ID
    public static BookingReservation GetBookingReservation(int bookingReservationId)
    {
        using var context = new FuminiHotelManagementContext();
        return context.BookingReservations.Find(bookingReservationId);
    }

    // Get all booking reservations
    public static List<BookingReservation> GetBookingReservations()
    {
        using var context = new FuminiHotelManagementContext();
        return context.BookingReservations.ToList();
    }

    // Get booking reservations by customer ID
    public static List<BookingReservation> GetBookingReservationsByCustomerId(int customerId)
    {
        using var context = new FuminiHotelManagementContext();
        return context.BookingReservations
            .Where(br => br.CustomerId == customerId)
            .ToList();
    }
}