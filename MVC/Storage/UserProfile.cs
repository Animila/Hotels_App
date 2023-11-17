using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelApp.MVVM.Model;

namespace HotelApp.MVVM.Storage
{
    public class UserProfile
    {
        private static UserProfile _instance;

        public event EventHandler UserProfileUpdated;

        public static UserProfile Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new UserProfile();
                }
                return _instance;
            }
        }

        private User _currentUser;

        // Добавьте свойства пользователя
        public User CurrentUser
        {
            get { return _currentUser; }
            set
            {
                if (_currentUser != value)
                {
                    _currentUser = value;
                    // Вызываем событие при изменении данных пользователя
                    OnUserProfileUpdated();
                }
            }
        }
        protected virtual void OnUserProfileUpdated()
        {
            UserProfileUpdated?.Invoke(this, EventArgs.Empty);
        }
    }
}
