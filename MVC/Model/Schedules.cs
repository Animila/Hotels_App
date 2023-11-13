using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelApp.MVVM.Model
{
    public class Schedules
    {
        public int id { get; set; }
        public int id_employess { get; set; }
        public string id_day_of_week { get; set; }
        public string start_time { get; set; }
        public string end_time { get; set; }
    }
}
