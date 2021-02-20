using DAL;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Types;
using System.Data;

namespace Repository
{
    public class ReservationRepo
    {
        private DataAccess db;
        public ReservationRepo()
        {
            db = new DataAccess();
        }

     

        public string GetReservationNumber()
        {
           

            Random random = new Random();
            string digitNumber = random.Next(10000000, 99999999).ToString();
            return digitNumber;
        }

        public bool Create(Reservation reservation)
        {
            List<ParmStruct> parms = new List<ParmStruct>();
            
            parms.Add(new ParmStruct("@LastReservationNumber", SqlDbType.Char, 8, reservation.ReservationNumber, ParameterDirection.Input));
            parms.Add(new ParmStruct("@CheckInDate", SqlDbType.Date, 0, reservation.CheckInDate, ParameterDirection.Input));
            parms.Add(new ParmStruct("@CheckOutDate", SqlDbType.Date, 0, reservation.CheckOutDate, ParameterDirection.Input));
            parms.Add(new ParmStruct("@AdultNumber", SqlDbType.SmallInt, 0, reservation.AdultNumber, ParameterDirection.Input));
            parms.Add(new ParmStruct("@ChildNumber", SqlDbType.SmallInt, 0, reservation.ChildNumber, ParameterDirection.Input));
            parms.Add(new ParmStruct("@CreationDate", SqlDbType.Date, 0, reservation.CreationDate, ParameterDirection.Input));
            parms.Add(new ParmStruct("@ClerkId", SqlDbType.Int, 0, 1, ParameterDirection.Input));
            parms.Add(new ParmStruct("@RoomId", SqlDbType.Int, 0, reservation.RoomId, ParameterDirection.Input));
            
            parms.Add(new ParmStruct("@FirstName", SqlDbType.Char, 30, reservation.Guest.FirstName.Trim(), ParameterDirection.Input));
            parms.Add(new ParmStruct("@MiddleName", SqlDbType.Char, 2, reservation.Guest.MiddleName.Trim(), ParameterDirection.Input));
            parms.Add(new ParmStruct("@LastName", SqlDbType.Char, 30, reservation.Guest.LastName.Trim(), ParameterDirection.Input));
            parms.Add(new ParmStruct("@StreetAddress", SqlDbType.Char, 30, reservation.Guest.StreetAddress, ParameterDirection.Input));
            parms.Add(new ParmStruct("@City", SqlDbType.Char, 20, reservation.Guest.City, ParameterDirection.Input));
            parms.Add(new ParmStruct("@PostalCode", SqlDbType.Char, 7, reservation.Guest.PostalCode, ParameterDirection.Input));
            parms.Add(new ParmStruct("@HomePhone", SqlDbType.Char, 15, reservation.Guest.HomePhone, ParameterDirection.Input));
            parms.Add(new ParmStruct("@CellPhone", SqlDbType.Char, 15, reservation.Guest.CellPhone, ParameterDirection.Input));
            parms.Add(new ParmStruct("@Email", SqlDbType.Char, 35, reservation.Guest.Email, ParameterDirection.Input));
            parms.Add(new ParmStruct("@DateOfBirth", SqlDbType.DateTime2, 30, reservation.Guest.DateOfBirth, ParameterDirection.Input));
            parms.Add(new ParmStruct("@ProvinceId", SqlDbType.Int, 0, reservation.Guest.ProvinceId, ParameterDirection.Input));
            parms.Add(new ParmStruct("@CountryId", SqlDbType.Int, 0, reservation.Guest.CountryId, ParameterDirection.Input));

            return db.SendData("spCreateReservation",parms) > 0;

        }

        private SortableBindingList<ReservationViewDTO> GetReservationsFromDB(DataTable dt)
        {
            SortableBindingList<ReservationViewDTO> reservations = new SortableBindingList<ReservationViewDTO>();
            foreach (DataRow row in dt.Rows)
            {
                reservations.Add(new ReservationViewDTO
                {
                    ReservationNumber = row[0].ToString(),
                    CheckInDate = Convert.ToDateTime(row[1]),
                    CheckOutDate = Convert.ToDateTime(row[2]),
                    CreationDate = Convert.ToDateTime(row[3]),
                    RoomNumber = Convert.ToInt32(row[4]),
                    RoomName = row[5].ToString(),
                    GuestName = row[6].ToString()
                });
            }
            return reservations;
        }

        public SortableBindingList<ReservationViewDTO> Retrieve()
        {
            DataTable dt =  db.GetData("spGetReservations");

            SortableBindingList<ReservationViewDTO> reservations = GetReservationsFromDB(dt);

            return reservations;
        }

        public SortableBindingList<ReservationViewDTO> SearchReservationsByRoomNumber(int searchText)
        {
            List<ParmStruct> parms = new List<ParmStruct>();
            parms.Add(new ParmStruct("@searchText", SqlDbType.Int, 0, searchText, ParameterDirection.Input));

            DataTable dt = db.GetData("spSearchReservationsByRoomNumber",parms);

            SortableBindingList<ReservationViewDTO> reservations = GetReservationsFromDB(dt);

            return reservations;
        }

        public SortableBindingList<ReservationViewDTO> SearchReservationsByRoomName(string searchText)
        {
            List<ParmStruct> parms = new List<ParmStruct>();
            parms.Add(new ParmStruct("@searchText", SqlDbType.Char, 30, searchText, ParameterDirection.Input));

            DataTable dt = db.GetData("spSearchReservationsByRoomName", parms);
            SortableBindingList<ReservationViewDTO> reservations = GetReservationsFromDB(dt);

            return reservations;
        }

        public SortableBindingList<ReservationViewDTO> SearchReservationsByLastName(string searchText)
        {
            List<ParmStruct> parms = new List<ParmStruct>();
            parms.Add(new ParmStruct("@searchText", SqlDbType.Char, 30, searchText, ParameterDirection.Input));

            DataTable dt = db.GetData("spSearchReservationsByLastName", parms);
            SortableBindingList<ReservationViewDTO> reservations = GetReservationsFromDB(dt);

            return reservations;
        }

        public SortableBindingList<ReservationViewDTO> SearchReservationsByResNumber(string searchText)
        {
            List<ParmStruct> parms = new List<ParmStruct>();
            parms.Add(new ParmStruct("@searchText", SqlDbType.Char, 12, searchText, ParameterDirection.Input));

            DataTable dt =  db.GetData("spSearchReservationsByResNumber", parms);
            SortableBindingList<ReservationViewDTO> reservations = GetReservationsFromDB(dt);

            return reservations;
        }
        public SortableBindingList<ReservationViewDTO> SearchReservationsByCreationDate(DateTime searchText)
        {
            List<ParmStruct> parms = new List<ParmStruct>();
            parms.Add(new ParmStruct("@searchText", SqlDbType.Date, 0, searchText, ParameterDirection.Input));

            DataTable dt =  db.GetData("spSearchReservationsByCreationDate", parms);
            SortableBindingList<ReservationViewDTO> reservations = GetReservationsFromDB(dt);

            return reservations;
        }
        public SortableBindingList<ReservationViewDTO> SearchReservationsByCheckInDate(DateTime searchText)
        {
            List<ParmStruct> parms = new List<ParmStruct>();
            parms.Add(new ParmStruct("@searchText", SqlDbType.Date, 0, searchText, ParameterDirection.Input));

            DataTable dt = db.GetData("spSearchReservationsByCheckInDate", parms);
            SortableBindingList<ReservationViewDTO> reservations = GetReservationsFromDB(dt);

            return reservations;
        }
        public SortableBindingList<ReservationViewDTO> SearchReservationsByCheckOutDate(DateTime searchText)
        {
            List<ParmStruct> parms = new List<ParmStruct>();
            parms.Add(new ParmStruct("@searchText", SqlDbType.Date, 0, searchText, ParameterDirection.Input));

            DataTable dt = db.GetData("spSearchReservationsByCheckOutDate", parms);
            SortableBindingList<ReservationViewDTO> reservations = GetReservationsFromDB(dt);

            return reservations;
        }

        public ReservationDetailsDTO RetrieveReservationDetails(string reservationNumber)
        {
            List<ParmStruct> parms = new List<ParmStruct>();
            parms.Add(new ParmStruct("@ReservationNumber", SqlDbType.Char, 12, reservationNumber, ParameterDirection.Input));

            DataTable dt = db.GetData("spGetReservationDetails", parms);
            DataRow row = dt.Rows[0];
            return new ReservationDetailsDTO
            {
                FirstName = row["FirstName"].ToString(),
                MiddleName = row["MiddleName"].ToString(),
                LastName = row["LastName"].ToString(),
                StreetAddress = row["StreetAddress"].ToString().Trim(),
                City = row["City"].ToString().Trim(),
                ProvinceAbbre = row["ProvinceAbbre"].ToString().Trim(),
                CountryName = row["CountryName"].ToString().Trim(),
                PostalCode = row["PostalCode"].ToString().Trim(),
                HomePhone = row["HomePhone"].ToString().Trim(),
                CellPhone = row["CellPhone"].ToString().Trim(),
                Email = row["Email"].ToString(),
                DateOfBirth = Convert.ToDateTime(row["DateOfBirth"]).Date,
                CheckInDate = Convert.ToDateTime(row["CheckInDate"]).Date,
                CheckOutDate = Convert.ToDateTime(row["CheckOutDate"]).Date,
                RoomName = row["RoomName"].ToString(),
                RoomNumber = Convert.ToInt32(row["RoomNumber"]),
                AdultNumber = Convert.ToInt32(row["AdultNumber"]),
                ChildNumber = Convert.ToInt32(row["ChildNumber"]),
                BaseRate = Convert.ToDecimal(row["BaseRate"]),
                Total = Convert.ToDecimal(row["Total"]),
                ReservationNumber = row["ReservationNumber"].ToString()
            };


          
        }

        public string GetReservationNumberFromDB(DateTime checkInDate, DateTime checkOutDate, int roomId)
        {
            List<ParmStruct> parms = new List<ParmStruct>();

            parms.Add(new ParmStruct("@CheckInDate", SqlDbType.Date, 0, checkInDate, ParameterDirection.Input));
            parms.Add(new ParmStruct("@CheckOutDate", SqlDbType.Date, 0, checkOutDate, ParameterDirection.Input));
            parms.Add(new ParmStruct("@RoomId", SqlDbType.Int, 0, roomId, ParameterDirection.Input));

            return db.GetValue("spGetReservationNumber", parms).ToString();


        }
    }
}
