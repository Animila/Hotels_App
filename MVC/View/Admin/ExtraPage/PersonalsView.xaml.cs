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
using HotelApp.MVC.View.Admin.Modals;
using HotelApp.MVC.View.Admin.Modals;
using HotelApp.MVVM.Controller;
using HotelApp.MVVM.Interface;
using HotelApp.MVVM.Model;

namespace HotelApp.MVVM.View.Admin.ExtraPage
{
    /// <summary>
    /// Логика взаимодействия для PersonalsView.xaml
    /// </summary>
    public partial class PersonalsView : Page
    {
        readonly IEmployeeInterface _personalRepository = new EmployeeService();
        readonly IPositionInterface _positionRepository = new PositionService();
        List<Employee> listEmployeesFiltered = new List<Employee>();
        List<Position> allPositions;
        private ObservableCollection<Employee> employeesObserver;

        public PersonalsView()
        {
            InitializeComponent();            
            employeesObserver = new ObservableCollection<Employee>();
            personalData.ItemsSource = employeesObserver;
            LoadData();
        }

        private async void LoadData()
        {
            var data = await _personalRepository.getAll();
            allPositions = _positionRepository.getAll().Result;
            Position testPosition = new Position
            {
                id = 0,
                title = "Все",
                salary = 0
            };
            allPositions.Add(testPosition);
            positionList.ItemsSource = allPositions;



            List<Employee> employees = new List<Employee>();

            foreach (var item in data.OrderBy(item => item.id))
            {
                item.position = allPositions[item.id_position - 1];
                employees.Add(item);
            }

            employeesObserver.Clear();
            employees.ForEach(emp => employeesObserver.Add(emp));


            positionList.SelectedIndex = allPositions.ToArray().Length - 1;

        }




        private void seacrh_TextChanged(object sender, TextChangedEventArgs e)
        {
        string searchTerm = seacrh.Text.ToLower().Trim();
            var listFiltered = listEmployeesFiltered.Where(employee =>
                employee.first_name.ToLower().Trim().Contains(searchTerm) ||
                employee.last_name.ToLower().Trim().Contains(searchTerm) ||
                employee.third_name.ToLower().Trim().Contains(searchTerm) ||
                employee.address.ToLower().Trim().Contains(searchTerm) ||
                employee.telephone.ToLower().Trim().Contains(searchTerm) ||
                employee.position?.title.ToLower().Trim().Contains(searchTerm) == true
            ).ToList();
            personalData.ItemsSource = listFiltered;
        }

        private void positionList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            List<Employee> listEmployeesFilteredPosition = new List<Employee>();

            if (positionList.SelectedItem != null)
            {
                if (positionList.SelectedValue is int selectedPositionId)
                {

                    if (selectedPositionId == 0)
                    {
                        // If "Все" is selected, show all employees
                        listEmployeesFiltered = employeesObserver.ToList();
                    }
                    else
                    {
                        // Filter employees based on the selected position
                        listEmployeesFiltered = employeesObserver.Where(employee => employee.id_position == selectedPositionId).ToList();
                    }

                    personalData.ItemsSource = listEmployeesFiltered;
                }
            }
        }

        private void EditEmployee(object sender, RoutedEventArgs e)
        {
            Employee selectedItem = (Employee)personalData.SelectedItem;
            if (selectedItem != null)
            {
                if (Application.Current.MainWindow is MainWindow mainWindow)
                {
                    mainWindow.MainContentFrame.Navigate(new AddPersonal(selectedItem));
                }
            }
        }

        private void AddEmployee(object sender, RoutedEventArgs e)
        {
            if (Application.Current.MainWindow is MainWindow mainWindow)
            {
                mainWindow.MainContentFrame.Navigate(new AddPersonal());
            }
        }

        private void DelEmployee(object sender, RoutedEventArgs e)
        {
            Employee selectedItem = (Employee)personalData.SelectedItem;
            if (selectedItem != null)
            {
                var posdel = _personalRepository.delete(selectedItem.id).Result;
                if (posdel == 0)
                {
                    MessageBox.Show("Ошибка удаления");
                    return;
                }
                employeesObserver.Remove(selectedItem);


            }
        }
    }
}
