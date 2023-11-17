using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
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
using HotelApp.MVC.Controller;
using HotelApp.MVC.Interface;
using HotelApp.MVVM.Controller;
using HotelApp.MVVM.Interface;
using HotelApp.MVVM.Model;
using HotelApp.MVVM.View.Admin.ExtraPage;

namespace HotelApp.MVC.View.Admin.Modals
{
    /// <summary>
    /// Логика взаимодействия для AddRoom.xaml
    /// </summary>
    public partial class AddRoom : Page
    {
        IRoomInterface _roomsEnterface = new RoomService();
        ITypeRoomInterface _typeroomInterface = new TypeRoomService();
        IEmployeeInterface _employeeInterface = new EmployeeService();
        private List<TypeRoom> allType;
        private List<Employee> allEmployee;
        private bool isEditing = false;
        private Room selectedRoom;
        public AddRoom()
        {
            InitializeComponent();
            allType = _typeroomInterface.getAll().Result;
            typeRoom.ItemsSource = allType;
            allEmployee = _employeeInterface.getAll().Result;
            mainPeople.ItemsSource = allEmployee;
            titleAdd.Text = "Создание";
        }
        public AddRoom(Room room) : this()
        {
            isEditing = true;
            this.selectedRoom = room;

            countPeople.Text = room.count_person.ToString();
            priceRoom.Text = room.price.ToString();

            var selectedIndexType = allType.Find(position => position.id == room.id_type).id;
            var selectedIndexEmployee = allEmployee.Find(position => position.id == room.id_employess).id;

            typeRoom.SelectedIndex = selectedIndexType - 1;
            mainPeople.SelectedIndex = selectedIndexEmployee - 1;

            titleAdd.Text = "Редактирование";
        }

        private void main_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void type_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private Room CreateEmployee(int count_person, int price, int id_employess, int id_type)
        {
           
            var newpos = _roomsEnterface.create(new Room
            {
                count_person = count_person,
                price = price,
                id_employess = allEmployee.Find(position => position.id == id_employess).id,
                id_type = allType.Find(position => position.id == id_type).id,
            }).Result;
            return newpos;
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            SaveBtn.IsEnabled = false;
            var idType = typeRoom.SelectedIndex + 1;
            var idMain = mainPeople.SelectedIndex + 1;
            Room result;

            if (isEditing)
            {
                
                result = _roomsEnterface.update(new Room
                {
                    id = selectedRoom.id,
                    count_person = int.Parse(countPeople.Text),
                    price = int.Parse(priceRoom.Text),
                    id_employess = allEmployee.Find(position => position.id == idMain).id,
                    id_type = allType.Find(position => position.id == idType).id,
                }).Result;
                if (result == null)
                {
                    MessageBox.Show("Ошибка сохранения");
                    SaveBtn.IsEnabled = true;

                    return;
                }
            }
            else
            {
                result = CreateEmployee(int.Parse(countPeople.Text), int.Parse(priceRoom.Text), idMain, idType);
                if (result == null)
                {
                    MessageBox.Show("Ошибка сохранения"); 
                    SaveBtn.IsEnabled = true;
                    return;
                }
            }
            MessageBox.Show("Данные сохранены");
            if (Application.Current.MainWindow is MainWindow mainWindow)
            {
                mainWindow.MainContentFrame.Navigate(new RoomsView());
            }
        }

        private void BackButton(object sender, RoutedEventArgs e)
        {
            NavigationService?.GoBack();
        }
    }
}
