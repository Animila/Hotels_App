using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelApp.MVVM.Model
{
    public class TypeRoom
    {
        public int id { get; set; }
        public string title { get; set; }
    }

    public class TypesRoomResponse
    {
        public bool success { get; set; }
        public List<TypeRoom> data { get; set; }
        public string message { get; set; }
    }

    public class TypeRoomResponse
    {
        public bool success { get; set; }
        public TypeRoom data { get; set; }
        public string message { get; set; }
    }
}
