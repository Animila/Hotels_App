using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using HotelApp.MVC.Controller;
using HotelApp.MVC.Interface;
using HotelApp.MVC.View.Admin.Modals;
using HotelApp.MVVM.Controller;
using HotelApp.MVVM.Interface;
using HotelApp.MVVM.Model;

namespace HotelApp.MVVM.View.Admin.ExtraPage
{
    /// <summary>
    /// Логика взаимодействия для RoomsView.xaml
    /// </summary>
    public partial class RoomsView : Page
    {
        IRoomInterface _roomsEnterface = new RoomService();
        ITypeRoomInterface _typeroomInterface = new TypeRoomService();
        IEmployeeInterface _employeeInterface = new EmployeeService();
        List<TypeRoom> allTypeRoom;
        List<Employee> allEmployee;
        private ObservableCollection<Room> roomsObserver;
        List<Room> listRoomFiltered = new List<Room>();

        public RoomsView()
        {
            InitializeComponent();
            roomsObserver = new ObservableCollection<Room>();
            roomsData.ItemsSource = roomsObserver;
            LoadData();
        }

        private async void LoadData()
        {
            var data = await _roomsEnterface.GetAll();

            allTypeRoom = _typeroomInterface.getAll().Result;
            TypeRoom testTypeRoom = new TypeRoom
            {
                id = 0,
                title = "Все"
            };
            allTypeRoom.Add(testTypeRoom);
            typeList.ItemsSource = allTypeRoom;

            allEmployee = _employeeInterface.getAll().Result;
            Employee testEmployee = new Employee
            {
                id = 0,
                first_name = "Все"
            };
            allEmployee.Add(testEmployee);

            List<Room> room = new List<Room>();

            foreach (var item in data.OrderBy(item => item.id))
            {
                item.type = allTypeRoom[item.id_type - 1];
                item.employee = allEmployee[item.id_employess - 1];
                room.Add(item);
            }

            // Очистите коллекцию перед добавлением новых данных
            roomsObserver.Clear();

            // Добавьте новые данные в коллекцию
            room.ForEach(emp => roomsObserver.Add(emp));


            typeList.SelectedIndex = allTypeRoom.ToArray().Length - 1;
        }

        private void typeList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            List<Room> listRoomFilteredType = new List<Room>();

            if (typeList.SelectedItem != null)
            {
                if (typeList.SelectedValue is int selectedTypeId)
                {

                    if (selectedTypeId == 0)
                    {
                        // If "Все" is selected, show all employees
                        listRoomFilteredType = roomsObserver.ToList();
                    }
                    else
                    {
                        // Filter employees based on the selected position
                        listRoomFilteredType = roomsObserver.Where(room => room.id_type == selectedTypeId).ToList();
                    }

                    roomsData.ItemsSource = listRoomFilteredType;
                }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (Application.Current.MainWindow is MainWindow mainWindow)
            {
                mainWindow.MainContentFrame.Navigate(new AddRoom());
            }
        }

        private void EditRoom(object sender, RoutedEventArgs e)
        {
            Room selectedItem = (Room)roomsData.SelectedItem;
            if (selectedItem != null)
            {
                if (Application.Current.MainWindow is MainWindow mainWindow)
                {
                    mainWindow.MainContentFrame.Navigate(new AddRoom(selectedItem));
                }
            }
        }

        private void DelRoom(object sender, RoutedEventArgs e)
        {
            Room selectedItem = (Room)roomsData.SelectedItem;
            if (selectedItem != null)
            {
                var posdel = _roomsEnterface.delete(selectedItem.id).Result;
                if (posdel == 0)
                {
                    MessageBox.Show("Ошибка удаления");
                    return;
                }
                roomsObserver.Remove(selectedItem);


            }
        }
    }
}
