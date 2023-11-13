using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.ConstrainedExecution;
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
using HotelApp.MVC.View.Admin.Modals.Positions;
using HotelApp.MVVM.Controller;
using HotelApp.MVVM.Interface;
using HotelApp.MVVM.Model;

namespace HotelApp.MVVM.View.Admin.ExtraPage
{
    /// <summary>
    /// Логика взаимодействия для PositionsView.xaml
    /// </summary>
    public partial class PositionsView : Page
    {
        IPositionsInterface _positionInterface = new PositionsService();
        private ObservableCollection<Position> positionObserver;
        public PositionsView()
        {
            InitializeComponent();
            var data = _positionInterface.getAll().Result;
            positionObserver = new ObservableCollection<Position>();
            positionsData.ItemsSource = positionObserver;
            LoadData();
        }

        private async void LoadData()
        {
            var data = await _positionInterface.getAll();

            // Очистите коллекцию перед добавлением новых данных
            positionObserver.Clear();

            // Добавьте новые данные в коллекцию
            foreach (var item in data)
            {
                positionObserver.Add(item);
            }
        }



        private void DelClick(object sender, RoutedEventArgs e)
        {
            Position selectedItem = (Position)positionsData.SelectedItem;
            if (selectedItem != null)
            {
                var posdel = _positionInterface.delete(selectedItem.id).Result;
                if(posdel == 0)
                {
                    MessageBox.Show("Ошибка удаления");
                    return;
                }
                positionObserver.Remove(selectedItem);
                

            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (Application.Current.MainWindow is MainWindow mainWindow)
            {
                mainWindow.MainContentFrame.Navigate(new AddPosition());
            }
        }

        private void EditClick(object sender, RoutedEventArgs e)
        {
            Position selectedItem = (Position)positionsData.SelectedItem;
            if (selectedItem != null)
            {
                if (Application.Current.MainWindow is MainWindow mainWindow)
                {
                    mainWindow.MainContentFrame.Navigate(new AddPosition(selectedItem));
                }
            }
                
        }
    }
}
