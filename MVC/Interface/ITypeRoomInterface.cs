using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelApp.MVVM.Model;

namespace HotelApp.MVC.Interface
{
    internal interface ITypeRoomInterface
    {
        Task<List<TypeRoom>> getAll();
        Task<TypeRoom> create(string title);
        Task<TypeRoom> getId(int id);
        Task<TypeRoom> update(int id, string title);
        Task<int> delete(int id);
    }
}
