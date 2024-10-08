namespace DataAccessLayer;
using BusinessObjects;

public class RoomInformationDAO
{
    public static void AddRoomInformation(RoomInformation roomInformation)
    {
        using var context = new FuminiHotelManagementContext();
        context.RoomInformations.Add(roomInformation);
        context.SaveChanges();
    }

    // Update an existing room information in the database
    public static void UpdateRoomInformation(RoomInformation roomInformation)
    {
        using var context = new FuminiHotelManagementContext();
        context.RoomInformations.Update(roomInformation);
        context.SaveChanges();
    }

    // Delete a room information by ID
    public static void DeleteRoomInformation(int roomInformationId)
    {
        using var context = new FuminiHotelManagementContext();
        var roomInformation = context.RoomInformations.Find(roomInformationId);
        if (roomInformation != null)
        {
            context.RoomInformations.Remove(roomInformation);
            context.SaveChanges();
        }
    }

    // Get a room information by ID
    public static RoomInformation GetRoomInformation(int roomInformationId)
    {
        using var context = new FuminiHotelManagementContext();
        return context.RoomInformations.Find(roomInformationId);
    }

    // Get all room informations
    public static List<RoomInformation> GetRoomInformations()
    {
        using var context = new FuminiHotelManagementContext();
        return context.RoomInformations.ToList();
    }

    // Get room informations by room number
    public static List<RoomInformation> GetRoomInformationsByRoomNumber(string roomNumber)
    {
        using var context = new FuminiHotelManagementContext();
        return context.RoomInformations
            .Where(ri => ri.RoomNumber == roomNumber)
            .ToList();
    }
}