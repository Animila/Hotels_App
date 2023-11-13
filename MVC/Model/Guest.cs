using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelApp.MVVM.Model
{
    public class Guest
    {
        public int id { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string third_name { get; set; }
        public string address { get; set; }
        public int sex { get; set; }
        public string birthday { get; set; }
        public string start_date { get; set; }
        public string end_date { get; set; }
    }

    public class StatisticGuest
    {
        public int count;
        public int count_of_day;
    }

    class StatisticGuestResponse
    {
        public bool success { get; set; }
        public StatisticGuest data { get; set; }
        public string message { get; set; }

    }
}
