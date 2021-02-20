using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class RoomDTO
    {
        public int RoomId { get; set; }
        public string RoomName { get; set; }
        public int RoomNumber { get; set; }
        public string NumberOfBeds { get; set; }
        public int MaximumOccupancy { get; set; }
        public decimal BaseRate { get; set; }
        public string Type { get; set; }

    }
}
