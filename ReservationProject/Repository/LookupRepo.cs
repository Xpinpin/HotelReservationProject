using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Data;
using Types;

namespace Repository
{
    public class LookupRepo
    {
        private DataAccess db;
        
        public LookupRepo()
        {
            db = new DataAccess();
        }

        public List<RoomDTO> RetrieveRooms()
        {
            DataTable dt = db.GetData("spGetRoomName");
            List<RoomDTO> rooms = new List<RoomDTO>();
            foreach(DataRow row in dt.Rows)
            {
                rooms.Add(new RoomDTO
                {
                    RoomId = Convert.ToInt32(row["RoomId"]),
                    RoomName = row["RoomName"].ToString()
                });
            }

            return rooms;
        }

        public List<RoomDTO> SearchAvailableRooms(DateTime startDate, DateTime endDate)
        {
            List<ParmStruct> parms = new List<ParmStruct>();
            parms.Add(new ParmStruct("@CheckInDate", SqlDbType.Date, 0, startDate, ParameterDirection.Input));
            parms.Add(new ParmStruct("@CheckOutDate", SqlDbType.Date, 0, endDate, ParameterDirection.Input));
            DataTable dt = db.GetData("spSearchAvailableRooms",parms);
            List<RoomDTO> rooms = new List<RoomDTO>();
            foreach (DataRow row in dt.Rows)
            {
                rooms.Add(new RoomDTO
                {
                    RoomId = Convert.ToInt32(row["RoomId"]),
                    RoomName = row["RoomName"].ToString()
                });
            }

            return rooms;
        }


        public List<ProvinceDTO> RetrieveProvinces(int countryId)
        {
            List<ParmStruct> parms = new List<ParmStruct>();
            parms.Add(new ParmStruct("@CountryId", SqlDbType.Int, 0, countryId, ParameterDirection.Input));

            DataTable dt = db.GetData("spGetProvinceName",parms);
            List<ProvinceDTO> canadaProvince = new List<ProvinceDTO>();
            foreach(DataRow row in dt.Rows)
            {
                canadaProvince.Add(new ProvinceDTO
                {
                    ProvinceId = Convert.ToInt32(row["ProvinceId"]),
                    ProvinceName = row["ProvinceName"].ToString()
                });
            }
            return canadaProvince;
        }

        public List<CountryDTO> RetrieveCountries()
        {
            DataTable dt = db.GetData("spGetAllCountries");
            List<CountryDTO> countries = new List<CountryDTO>();
            foreach(DataRow row in dt.Rows)
            {
                countries.Add(new CountryDTO
                {
                    CountryId = Convert.ToInt32(row["CountryId"]),
                    CountryName = row["CountryName"].ToString()
                });
            }
            return countries;
        }        

        public RoomDTO GetRoomDetails(int roomId)
        {
            List<ParmStruct> parms = new List<ParmStruct>();

            parms.Add(new ParmStruct("RoomId", SqlDbType.Int, 0, roomId, ParameterDirection.Input));

            DataTable dt = db.GetData("spGetRoomDetails", parms);
            DataRow row = dt.Rows[0];

            return new RoomDTO
            {
                RoomId = Convert.ToInt32(row[0]),
                RoomNumber = Convert.ToInt32(row[1]),
                RoomName = row[2].ToString(),
                NumberOfBeds = row[3].ToString(),
                MaximumOccupancy = Convert.ToInt32(row[4]),
                BaseRate = Convert.ToDecimal(row[5]),
                Type = row[6].ToString()
            };
        }

    }
}
