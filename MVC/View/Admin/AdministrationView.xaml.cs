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
using HotelApp.MVC.View.Admin.ExtraPage;
using HotelApp.MVC.View.Admin.Modals;
using HotelApp.MVVM.View.Admin;
using HotelApp.MVVM.View.Admin.ExtraPage;

namespace HotelApp.MVVM.View
{
    /// <summary>
    /// Логика взаимодействия для AdministrationView.xaml
    /// </summary>
    public partial class AdministrationView : Page
    {
        public AdministrationView()
        {
            InitializeComponent();
        }

        private void openEmployee(object sender, RoutedEventArgs e)
        {
            if (Application.Current.MainWindow is MainWindow mainWindow)
            {
                mainWindow.MainContentFrame.Navigate(new PersonalsView());
            } else
            {
                MessageBox.Show("errro");
            }
        }
        private void openPosition(object sender, RoutedEventArgs e)
        {
            if (Application.Current.MainWindow is MainWindow mainWindow)
            {
                mainWindow.MainContentFrame.Navigate(new PositionsView());
            }
        }
        private void openSchedule(object sender, RoutedEventArgs e)
        {
            if (Application.Current.MainWindow is MainWindow mainWindow)
            {
                mainWindow.MainContentFrame.Navigate(new SheduleView());
            }
        }
        private void openRooms(object sender, RoutedEventArgs e)
        {
            if (Application.Current.MainWindow is MainWindow mainWindow)
            {
                mainWindow.MainContentFrame.Navigate(new RoomsView());
            }
        }
        private void openTypesRoom(object sender, RoutedEventArgs e)
        {
            if (Application.Current.MainWindow is MainWindow mainWindow)
            {
                mainWindow.MainContentFrame.Navigate(new TypeRoomView());
            }
        }
        private void openService(object sender, RoutedEventArgs e)
        {
            if (Application.Current.MainWindow is MainWindow mainWindow)
            {
                mainWindow.MainContentFrame.Navigate(new PersonalsView());
            }
        }
    }
}
