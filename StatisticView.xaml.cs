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

namespace HotelApp.MVVM.View
{
    /// <summary>
    /// Логика взаимодействия для StatisticView.xaml
    /// </summary>
    public partial class StatisticView : Page
    {
        readonly IEmployeeInterface _personalRepository = new EmployeeService();
        readonly IGuestInterface _guestsRepository = new GuestServices();
        readonly IRoomInterface _roomsRepository = new RoomService();
        public StatisticView()
        {
            InitializeComponent();
            var guestsStat = _guestsRepository.getStatistics().Result;
            var employeeStat = _personalRepository.getStatistics().Result;
            var roomsStat = _roomsRepository.getStatistics().Result;
            EmployeeCount.Text = employeeStat.count.ToString();
            EmployeeOnline.Text = employeeStat.active.ToString();
            GuestsCount.Text = guestsStat.count.ToString();
            NewGuest.Text = guestsStat.count_of_day.ToString();
            RoomFree.Text = roomsStat.precent.ToString() + "%";
        }
    }
}
