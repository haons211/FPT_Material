namespace Services;
using BusinessObjects;
using System.Collections.Generic;

public interface IRoomInformationService
{
    void AddRoomInformation(RoomInformation room);
    void UpdateRoomInformation(RoomInformation room);
    void DeleteRoomInformation(int roomId);
    RoomInformation GetRoomInformation(int roomId);
    List<RoomInformation> GetRooms();
    List<RoomInformation> GetRoomsByRoomNumber(string roomNumber);
}