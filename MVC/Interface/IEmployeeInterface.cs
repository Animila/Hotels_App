using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelApp.MVVM.Model;

namespace HotelApp.MVVM.Interface
{
    internal interface IEmployeeInterface
    {
        Task<List<Employee>> getAll();
        Task<Employee> getId();
        Task<Employee> create(Employee employee);
        Task<Employee> update(MergeAccount person);
        Task<int> delete(int id);
        Task<Employee> getCreate();
        Task<StatisticEmployee> getStatistics();
    }
}
