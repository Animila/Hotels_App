using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using HotelApp.MVC.Controller;
using HotelApp.MVC.Interface;
using HotelApp.MVC.View.Admin.Modals;
using HotelApp.MVVM.Interface;
using HotelApp.MVVM.Model;

namespace HotelApp.MVC.View.Admin.ExtraPage
{
    /// <summary>
    /// Логика взаимодействия для TypeRoom.xaml
    /// </summary>
    public partial class TypeRoomView : Page
    {
        ITypeRoomInterface _typeroomInterface = new TypeRoomService();
        private ObservableCollection<TypeRoom> typeroomObserver;
        public TypeRoomView()
        {
            InitializeComponent();
            typeroomObserver = new ObservableCollection<TypeRoom>();
            typeroomData.ItemsSource = typeroomObserver;
            LoadData();
        }


        private async void LoadData()
        {
            var data = await _typeroomInterface.getAll();

            // Очистите коллекцию перед добавлением новых данных
            typeroomObserver.Clear();

            // Добавьте новые данные в коллекцию
            foreach (var item in data)
            {
                typeroomObserver.Add(item);
            }
        }

        private void EditClick(object sender, System.Windows.RoutedEventArgs e)
        {
            TypeRoom selectedItem = (TypeRoom)typeroomData.SelectedItem;
            if (selectedItem != null)
            {
                if (Application.Current.MainWindow is MainWindow mainWindow)
                {
                    mainWindow.MainContentFrame.Navigate(new AddTypeRoom(selectedItem));
                }
            }
        }

        private void DelClick(object sender, System.Windows.RoutedEventArgs e)
        {
            TypeRoom selectedItem = (TypeRoom)typeroomData.SelectedItem;
            if (selectedItem != null)
            {
                var posdel = _typeroomInterface.delete(selectedItem.id).Result;
                if (posdel == 0)
                {
                    MessageBox.Show("Ошибка удаления");
                    return;
                }
                typeroomObserver.Remove(selectedItem);


            }
        }

        private void Button_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            if (Application.Current.MainWindow is MainWindow mainWindow)
            {
                mainWindow.MainContentFrame.Navigate(new AddTypeRoom());
            }
        }
    }
}
