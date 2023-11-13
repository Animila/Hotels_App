using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelApp.MVVM.Model;

namespace HotelApp.MVVM.Interface
{
    internal interface IUsersInterface
    {

        Task<Users> login(string login, string password);
        Task<Users> update(int id, string login, string password);
    }
}
