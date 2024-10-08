namespace Repositories;

using BusinessObjects;
using DataAccessLayer;
using System.Collections.Generic;

public class RoomTypeRepository : IRoomTypeRepository
{
    public void AddRoomType(RoomType roomType)
    {
        RoomTypeDAO.AddRoomType(roomType);
    }

    public void UpdateRoomType(RoomType roomType)
    {
        RoomTypeDAO.UpdateRoomType(roomType);
    }

    public void DeleteRoomType(int roomTypeId)
    {
        RoomTypeDAO.DeleteRoomType(roomTypeId);
    }

    public RoomType GetRoomType(int roomTypeId)
    {
        return RoomTypeDAO.GetRoomType(roomTypeId);
    }

    public List<RoomType> GetRoomTypes()
    {
        return RoomTypeDAO.GetRoomTypes();
    }
}