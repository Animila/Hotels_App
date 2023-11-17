using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelApp.MVVM.Model;

namespace HotelApp.MVVM.Interface
{
    public interface IRoomInterface
    {
        Task<List<Room>> GetAll();
        Task<Room> create(Room room);
        Task<Room> update(Room room);
        Task<int> delete(int id);
        Task<StatisticRooms> getStatistics();
    }
}
