using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelApp.MVVM.Model
{
    public class Position
    {
        public int id { get; set; }
        public string title { get; set; }
        public int salary { get; set; }
    }

    public  class PositionsResponse
    {
        public bool success { get; set; }
        public List<Position> data { get; set; }
        public string message { get; set; }
    }

    public class PositionResponse
    {
        public bool success { get; set; }
        public Position  data { get; set; }
        public string message { get; set; }
    }
}
