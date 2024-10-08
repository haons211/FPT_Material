namespace Repositories
{
    using BusinessObjects;
    using System.Collections.Generic;

    public interface IRoomTypeRepository
    {
        void AddRoomType(RoomType roomType);
        void UpdateRoomType(RoomType roomType);
        void DeleteRoomType(int roomTypeId);
        RoomType GetRoomType(int roomTypeId);
        List<RoomType> GetRoomTypes();
    }
}