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

namespace HotelApp.MVVM.View.Admin.ExtraPage
{
    /// <summary>
    /// Логика взаимодействия для PersonalsView.xaml
    /// </summary>
    public partial class PersonalsView : Page
    {
        readonly IEmployessInterface _personalRepository = new EmployeeService();
        readonly IPositionsInterface _positionRepository = new PositionsService();
        List<Employee> listEmployees = new List<Employee>();

        public PersonalsView()
        {
            InitializeComponent();
            List<Position> allPositions = _positionRepository.getAll().Result;
            listEmployees = _personalRepository.getAll().Result;
            foreach (var employee in listEmployees)
            {
                employee.position = allPositions[employee.id_position - 1];
            }
            personalData.ItemsSource = listEmployees;
            Console.WriteLine(listEmployees[0].first_name);
            
        }

        private void seacrh_TextChanged(object sender, TextChangedEventArgs e)
        {
            string searchTerm = seacrh.Text.ToLower();
            if (!string.IsNullOrEmpty(searchTerm))
            {
                personalData.ItemsSource = listEmployees.Where(employee =>
                    employee.first_name.ToLower().Contains(searchTerm) ||
                    employee.last_name.ToLower().Contains(searchTerm) ||
                    employee.third_name.ToLower().Contains(searchTerm) ||
                    employee.address.ToLower().Contains(searchTerm) ||
                    employee.telephone.ToLower().Contains(searchTerm) ||
                    employee.position?.title.ToLower().Contains(searchTerm) == true
                ).ToList();

            }
            personalData.ItemsSource = listEmployees;
        }
    }
}
