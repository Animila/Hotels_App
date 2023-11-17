using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelApp.MVVM.Model;

namespace HotelApp.MVVM.Interface
{
    internal interface IGuestInterface
    {
        //Task<List<Employee>> getAll();
        Task<StatisticGuest> getStatistics();
    }
}
