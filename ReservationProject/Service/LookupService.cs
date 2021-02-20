using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
namespace Service
{
    public class LookupService
    {
        private LookupRepo repo;

        public LookupService()
        {
            repo = new LookupRepo();
        }

        public List<RoomDTO> GetRooms()
        {
            return repo.RetrieveRooms();
        }

        public List<RoomDTO> GetAvailableRooms(DateTime startDate, DateTime endDate)
        {
            return repo.SearchAvailableRooms(startDate, endDate);
        }

        public List<ProvinceDTO> GetAllProvinces(int countryId)
        {
            return repo.RetrieveProvinces(countryId);
        }

        public List<CountryDTO> GetAllCountries()
        {
            return repo.RetrieveCountries();
        }
     
        public RoomDTO ShowRoomDetails(int roomId)
        {
            return repo.GetRoomDetails(roomId);
        }
    }
}
