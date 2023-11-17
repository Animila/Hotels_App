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
using HotelApp.MVVM.Model;
using HotelApp.MVVM.View.Admin.ExtraPage;

namespace HotelApp.MVC.View.Admin.Modals
{
    /// <summary>
    /// Логика взаимодействия для AddPersonal.xaml
    /// </summary>
    public partial class AddPersonal : Page
    {
        private IPositionInterface _positionInterface = new PositionService();
        private IEmployeeInterface _employeeInterface = new EmployeeService();
        private List<Position> allPositions;
        private Employee selectedEmployee;
        private bool isEditing = false;

        public AddPersonal()
        {
            InitializeComponent();
            allPositions = _positionInterface.getAll().Result;
            position.ItemsSource = allPositions;
            titleAdd.Text = "Создание сотрудника";
        }

        public AddPersonal(Employee employee) : this()
        {
            allPositions = _positionInterface.getAll().Result;
            isEditing = true;
            this.selectedEmployee = employee;
            titleAdd.Text = "Редактирование";
            first.Text = employee.first_name;
            last.Text = employee.last_name;
            third.Text = employee.third_name;
            address.Text = employee.address;
            telephone.Text = employee.telephone;
            var selectedIndex = allPositions.Find(position => position.id == employee.id_position).id;
            position.SelectedIndex = selectedIndex - 1;
        }

        private void position_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            SaveBtn.IsEnabled = true;

            var idPos = position.SelectedIndex + 1;
            Employee result;

            if (isEditing)
            {
                result = _employeeInterface.update(new MergeAccount
                {
                   id = selectedEmployee.id,
                   first_name = first.Text, 
                   last_name = last.Text,
                   third_name =  third.Text,
                   address = address.Text,
                   telephone = telephone.Text,
                   id_position = allPositions.Find(position => position.id == idPos).id
                }).Result;
                if(result == null)
                {
                    MessageBox.Show("Ошибка сохранения"); 
                    SaveBtn.IsEnabled = false;
                    return;
                }
            } else
            {
                result = CreateEmployee(first.Text, last.Text, third.Text, address.Text, telephone.Text, allPositions.Find(position => position.id == idPos).id);
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
                mainWindow.MainContentFrame.Navigate(new PersonalsView());
            }

        }

        private void BackButton(object sender, RoutedEventArgs e)
        {
            NavigationService?.GoBack();
        }

        private Employee CreateEmployee(string firstName, string lastName, string thirdName, string address, string telephone, int positionId)
        {
            var newpos =  _employeeInterface.create(new Employee
            {
                first_name = firstName, 
                last_name = lastName,
                third_name = thirdName,
                address = address,
                telephone = telephone, 
                id_position = positionId
            }).Result;
            return newpos;
        }
    }
}
