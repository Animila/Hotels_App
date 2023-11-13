using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelApp.MVVM.Model;

namespace HotelApp.MVVM.Interface
{
    internal interface IPositionsInterface
    {
        Task<List<Position>> getAll();
        Task<Position> create(string title, int salary);
        Task<Position> getId(int id);
        Task<Position> update(int id, string title, int salary);
        Task<int> delete(int id);
    }
}
