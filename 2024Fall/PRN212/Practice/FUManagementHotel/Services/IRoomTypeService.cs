using BusinessObjects;
using System.Collections.Generic;

namespace Services
{
    public interface IRoomTypeService
    {
        void AddRoomType(RoomType roomType);
        void UpdateRoomType(RoomType roomType);
        void DeleteRoomType(int roomTypeId);
        RoomType GetRoomType(int roomTypeId);
        List<RoomType> GetRoomTypes();
        
    }
}