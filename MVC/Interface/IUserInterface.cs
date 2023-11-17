using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelApp.MVVM.Model;

namespace HotelApp.MVVM.Interface
{
    internal interface IUserInterface
    {

        Task<User> login(string login, string password);
        Task<User> update(int id, string login, string password);
    }
}
