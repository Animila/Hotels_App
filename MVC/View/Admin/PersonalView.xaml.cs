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
using System.Windows.Navigation;
using System.Windows.Shapes;
using HotelApp.MVVM.Controller;
using HotelApp.MVVM.Interface;
using HotelApp.MVVM.Storage;

namespace HotelApp.MVVM.View.Admin
{
    /// <summary>
    /// Логика взаимодействия для PersonalPage.xaml
    /// </summary>
    public partial class PersonalView : Page
    {
        private readonly IUserInterface _usersInterface = new UserService();
        private readonly IEmployeeInterface _employessInterface = new EmployeeService();
        public PersonalView()
        {
            InitializeComponent();
            DataContext = UserProfile.Instance;
            LoadUserProfile();

        }
        private void LoadUserProfile()
        {
            // Проверка, что текущий пользователь существует
            if (UserProfile.Instance.CurrentUser != null)
            {
                // Загрузка данных профиля в текстовые поля
                first.Text = UserProfile.Instance.CurrentUser.account.first_name;
                last.Text = UserProfile.Instance.CurrentUser.account.last_name;
                third.Text = UserProfile.Instance.CurrentUser.account.third_name;
                login.Text = UserProfile.Instance.CurrentUser.login;
                address.Text = UserProfile.Instance.CurrentUser.account.address;
                tel.Text = UserProfile.Instance.CurrentUser.account.telephone;
                // Добавьте аналогичные строки для других полей

                // Можно также добавить загрузку данных из БД, если необходимо
            }
        }
        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            // Сохранение данных
            UserProfile.Instance.CurrentUser.account.first_name = first.Text;
            UserProfile.Instance.CurrentUser.account.last_name = last.Text;
            UserProfile.Instance.CurrentUser.account.third_name = third.Text;
            UserProfile.Instance.CurrentUser.login = login.Text;
            UserProfile.Instance.CurrentUser.account.address = address.Text;
            UserProfile.Instance.CurrentUser.account.telephone = tel.Text;

            if (password.Text != null)
            {
                if (password.Text != checkPassword.Text)
                {
                    MessageBox.Show("Пароли не совпадают");
                    return;

                }
            }
            SaveUserProfileToDatabase();

        }
        private void SaveUserProfileToDatabase()
        {
            var resultEmployee = _employessInterface.update(UserProfile.Instance.CurrentUser.account).Result;
            var resultUser = _usersInterface.update(UserProfile.Instance.CurrentUser.id,login.Text, password.Text).Result;
            if(resultUser == null)
            {
                MessageBox.Show("Проблема с сохранением пользователя");
                return;
            }
            if (resultEmployee == null)
            {
                MessageBox.Show("Проблема с сохранением профиля");
                return;
            }
            MessageBox.Show("Данные обновлены");
        }
    }
}
