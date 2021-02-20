using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ReservationViewDTO
    {
        public string ReservationNumber { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
        public DateTime CreationDate { get; set; }
        public int RoomNumber { get; set; }
        public string RoomName { get; set; }
        public string GuestName { get; set; }
    }
}
