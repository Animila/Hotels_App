using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using HotelApp.MVVM.Controller;
using HotelApp.MVVM.Interface;
using HotelApp.MVVM.Model;
using HotelApp.MVVM.Storage;

namespace HotelApp
{
    /// <summary>
    /// Логика взаимодействия для AuthWindows.xaml
    /// </summary>
    public partial class AuthWindows : Window
    {
        IUsersInterface _usersInterface = new UsersService();
        public AuthWindows()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string user_login = login.Text;
            string user_password = password.Text;

            if (user_login == "" || user_password == "" || user_login == null || user_password == null)
            { MessageBox.Show("Введите логин и пароль"); return; }

            Users user = _usersInterface.login(user_login, user_password).Result;


            if(user == null) { MessageBox.Show("Неправильный логин или пароль"); return; }
            UserProfile.Instance.CurrentUser = user;
            if (user.type == "Администратор")
            {
                //MainWindow mainWindow = new MainWindow();
                //mainWindow.Show();
            }
            if(user.type == "Гость")
            {
                MessageBox.Show("Гость " + user.account.first_name + " " + user.account.last_name); return;
            }
            if (user.type == "Персонал")
            {
                MessageBox.Show("Персонал " + user.account.first_name + " " + user.account.last_name); return;
            }
            this.Close();
        }
    }
}
