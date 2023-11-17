using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelApp.MVVM.Model
{
    public class Room
    {
        public int id { get; set; }
        public int count_person { get; set; }
        public int id_type { get; set; }
        public TypeRoom type { get; set; }
        public Employee employee { get; set; }
        public int price { get; set; }
        public int id_employess { get; set; }
    }

    public class StatisticRooms
    {
        public string precent;
    }

    class RoomsResponse
    {
        public bool success { get; set; }
        public List<Room> data { get; set; }
        public string message { get; set; }
    }

    class RoomResponse
    {
        public bool success { get; set; }
        public Room data { get; set; }
        public string message { get; set; }
    }

    class StatisticRoomsResponse
    {
        public bool success { get; set; }
        public StatisticRooms data { get; set; }
        public string message { get; set; }

    }
}
