 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelApp.MVVM.Model
{
    public class MergeAccount
    {
        public int id { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string third_name { get; set; }
        public string address { get; set; }
        // employee
        public string telephone { get; set; }
        public int id_position { get; set; }
        // guest
        public int sex { get; set; }
        public string birthday { get; set; }
        public string start_date { get; set; }
        public string end_date { get; set; }
    }

    public class UserResponce
    {
        public bool success { get; set; }
        public Users data { get; set; }
        public string message { get; set; }
    }

    public class UsersResponce
    {
        public bool success { get; set; }
        public List<Users> data { get; set; }
        public string message { get; set; }
    }

    public class Users
    {
        public int id { get; set; }
        public string login { get; set; }
        public string type { get; set; }
        public MergeAccount account { get; set; }
    }

    
}
