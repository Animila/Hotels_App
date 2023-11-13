using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelApp.MVVM.Model
{
    class EmployeesResponse
    {
        public bool success { get; set; }
        public List<Employee> data { get; set; }
        public string message { get; set; }

    }
    class EmployeeResponse
    {
        public bool success { get; set; }
        public Employee data { get; set; }
        public string message { get; set; }

    }

    public class Employee
    {
        public int id { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string third_name { get; set; }
        public string address { get; set; }
        public string telephone { get; set; }
        public Position position { get; set; }
        public int id_position { get; set; }
    }

    public class StatisticEmployee
    {
        public int count;
        public int active;
    }

    class StatisticEmployeeResponse
    {
        public bool success { get; set; }
        public StatisticEmployee data { get; set; }
        public string message { get; set; }

    }
}
