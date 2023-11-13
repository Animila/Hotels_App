using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelApp.MVVM.Model;

namespace HotelApp.MVVM.Interface
{
    public interface IRoomsEnterface
    {
        Task<List<Room>> GetAll();
        Task<StatisticRooms> getStatistics();
    }
}
