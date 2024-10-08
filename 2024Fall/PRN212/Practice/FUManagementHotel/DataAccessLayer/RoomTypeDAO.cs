namespace DataAccessLayer;
using BusinessObjects;

public class RoomTypeDAO
{
    public static void AddRoomType(RoomType roomType)
    {
        using var context = new FuminiHotelManagementContext();
        context.RoomTypes.Add(roomType);
        context.SaveChanges();
    }

    // Update an existing room type in the database
    public static void UpdateRoomType(RoomType roomType)
    {
        using var context = new FuminiHotelManagementContext();
        context.RoomTypes.Update(roomType);
        context.SaveChanges();
    }

    // Delete a room type by ID
    public static void DeleteRoomType(int roomTypeId)
    {
        using var context = new FuminiHotelManagementContext();
        var roomType = context.RoomTypes.Find(roomTypeId);
        if (roomType != null)
        {
            context.RoomTypes.Remove(roomType);
            context.SaveChanges();
        }
    }

    // Get a room type by ID
    public static RoomType GetRoomType(int roomTypeId)
    {
        using var context = new FuminiHotelManagementContext();
        return context.RoomTypes.Find(roomTypeId);
    }

    // Get all room types
    public static List<RoomType> GetRoomTypes()
    {
        using var context = new FuminiHotelManagementContext();
        return context.RoomTypes.ToList();
    }
}