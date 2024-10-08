using BusinessObjects;
using System.Collections.Generic;
using Repositories;

namespace Services
{
    public class RoomTypeService : IRoomTypeService
    {
        private readonly IRoomTypeRepository _roomTypeRepository;

        public RoomTypeService(IRoomTypeRepository roomTypeRepository)
        {
            _roomTypeRepository = roomTypeRepository;
        }

        public void AddRoomType(RoomType roomType)
        {
            _roomTypeRepository.AddRoomType(roomType);
        }

        public void UpdateRoomType(RoomType roomType)
        {
            _roomTypeRepository.UpdateRoomType(roomType);
        }

        public void DeleteRoomType(int roomTypeId)
        {
            _roomTypeRepository.DeleteRoomType(roomTypeId);
        }

        public RoomType GetRoomType(int roomTypeId)
        {
            return _roomTypeRepository.GetRoomType(roomTypeId);
        }

        public List<RoomType> GetRoomTypes()
        {
            return _roomTypeRepository.GetRoomTypes();
        }

    
    }
}