using BusinessObjects;
using System.Collections.Generic;
using Repositories;

namespace Services
{
    public class RoomInformationService : IRoomInformationService
    {
        private readonly IRoomInformationRepository _roomInformationRepository;

        public RoomInformationService(IRoomInformationRepository roomInformationRepository)
        {
            _roomInformationRepository = roomInformationRepository;
        }

        public void AddRoomInformation(RoomInformation room)
        {
            _roomInformationRepository.AddRoomInformation(room);
        }

        public void UpdateRoomInformation(RoomInformation room)
        {
            _roomInformationRepository.UpdateRoomInformation(room);
        }

        public void DeleteRoomInformation(int roomId)
        {
            _roomInformationRepository.DeleteRoomInformation(roomId);
        }

        public RoomInformation GetRoomInformation(int roomId)
        {
            return _roomInformationRepository.GetRoomInformation(roomId);
        }

        public List<RoomInformation> GetRooms()
        {
            return _roomInformationRepository.GetRooms();
        }

        public List<RoomInformation> GetRoomsByRoomNumber(string roomNumber)
        {
            return _roomInformationRepository.GetRoomsByRoomNumber(roomNumber);
        }
    }
}