using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Reservation : BaseEntity
    {

        public string ReservationNumber { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }

        [Required]
        
        public int AdultNumber { get; set; }
        [Required]
        public int ChildNumber { get; set; }
        public decimal BaseRate { get; set; }
        public decimal AdultRate { get; set; }
        public decimal ChildRate { get; set; }
        public DateTime CreationDate { get; set; }
        public int ClerkId { get; set; }
        public Guest Guest { get; set; }
        public int RoomId { get; set; }

     
    }
}
