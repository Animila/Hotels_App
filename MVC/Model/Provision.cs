using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelApp.MVVM.Model
{
    public class Provision
    {
        public int id { get; set; }
        public int id_service { get; set; }
        public int count { get; set; }
        public int id_guest { get; set; }
        public int result_price { get; set; }
        public string date { get; set; }
        public int id_employess { get; set; }
    }
}
