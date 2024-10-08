namespace Repositories;

using BusinessObjects;
using DataAccessLayer;
using System.Collections.Generic;

public class RoomInformationRepository : IRoomInformationRepository
{
    public void AddRoomInformation(RoomInformation room)
    {
        RoomInformationDAO.AddRoomInformation(room);
    }

    public void UpdateRoomInformation(RoomInformation room)
    {
        RoomInformationDAO.UpdateRoomInformation(room);
    }

    public void DeleteRoomInformation(int roomId)
    {
        RoomInformationDAO.DeleteRoomInformation(roomId);
    }

    public RoomInformation GetRoomInformation(int roomId)
    {
        return RoomInformationDAO.GetRoomInformation(roomId);
    }

    public List<RoomInformation> GetRooms()
    {
        return RoomInformationDAO.GetRoomInformations();
    }

    public List<RoomInformation> GetRoomsByRoomNumber(string roomNumber)
    {
        return RoomInformationDAO.GetRoomInformationsByRoomNumber(roomNumber);
    }
}