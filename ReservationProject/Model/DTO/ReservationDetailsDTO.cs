using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ReservationDetailsDTO
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string ProvinceAbbre { get; set; }
        public string CountryName { get; set; }
        public string PostalCode { get; set; }
        public string HomePhone { get; set; }
        public string CellPhone { get; set; }
        public string Email { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
        public string RoomName { get; set; }
        public int RoomNumber { get; set; }
        public int AdultNumber { get; set; }
        public int ChildNumber { get; set; }
        public decimal BaseRate { get; set; }
        public decimal Total { get; set; }
        public string ReservationNumber { get; set; }

    }
}
