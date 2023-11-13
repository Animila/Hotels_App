using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelApp.MVVM.Model;

namespace HotelApp.MVVM.Interface
{
    internal interface IGuestsInterface
    {
        //Task<List<Employee>> getAll();
        Task<StatisticGuest> getStatistics();
    }
}
