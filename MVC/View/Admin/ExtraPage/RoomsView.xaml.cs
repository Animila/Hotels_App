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

namespace HotelApp.MVVM.View.Admin.ExtraPage
{
    /// <summary>
    /// Логика взаимодействия для RoomsView.xaml
    /// </summary>
    public partial class RoomsView : Page
    {
        IRoomsEnterface _roomsEnterface = new RoomsService();
        public RoomsView()
        {
            InitializeComponent();
            var data = _roomsEnterface.GetAll().Result;
            roomsData.ItemsSource = data;
        }
    }
}
