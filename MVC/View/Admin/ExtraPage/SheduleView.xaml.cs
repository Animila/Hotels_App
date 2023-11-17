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
using HotelApp.MVVM.Controller;
using HotelApp.MVVM.Interface;
using HotelApp.MVVM.Model;

namespace HotelApp.MVC.View.Admin.ExtraPage
{
    /// <summary>
    /// Логика взаимодействия для SheduleView.xaml
    /// </summary>
    public partial class SheduleView : Page
    {
        //IPositionInterface _positionInterface = new PositionService();
        private ObservableCollection<Position> positionObserver;
        public SheduleView()
        {
            InitializeComponent();
        }

        private void dayList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void EditSchedule(object sender, RoutedEventArgs e)
        {

        }

        private void DelSchedule(object sender, RoutedEventArgs e)
        {

        }
    }
}
