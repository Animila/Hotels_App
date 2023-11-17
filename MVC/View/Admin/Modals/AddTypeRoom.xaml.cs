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
using HotelApp.MVC.Controller;
using HotelApp.MVC.Interface;
using HotelApp.MVC.View.Admin.ExtraPage;
using HotelApp.MVVM.Controller;
using HotelApp.MVVM.Interface;
using HotelApp.MVVM.Model;
using HotelApp.MVVM.View.Admin.ExtraPage;

namespace HotelApp.MVC.View.Admin.Modals
{
    /// <summary>
    /// Логика взаимодействия для AddTypeRoom.xaml
    /// </summary>
    public partial class AddTypeRoom : Page
    {
        private ITypeRoomInterface _typeroomInterface = new TypeRoomService();
        private bool isEditing = false;
        private TypeRoom selectedType;
        public AddTypeRoom()
        {
            InitializeComponent();
            titleAdd.Text = "Создание типа комнаты";
        }

        public AddTypeRoom(TypeRoom typeroom) : this()
        {
            isEditing = true;
            this.selectedType = typeroom;
            title.Text = typeroom.title;
            titleAdd.Text = "Редактирование";
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            SaveBtn.IsEnabled = false;

            var new_title = title.Text;

            if (isEditing)
            {
                EditPosition(new_title);
            }
            else
            {
                CreatePosition(new_title);
            }
        }

        private void BackButton(object sender, RoutedEventArgs e)
        {
            NavigationService?.GoBack();
        }

        private async void CreatePosition(string new_title)
        {
            var newpos = await _typeroomInterface.create(new_title);
            if (newpos == null)
            {
                MessageBox.Show("Ошибка сохранения");
                SaveBtn.IsEnabled = true;

                return;
            }

            NavigateToPositionsView();
        }

        private async void EditPosition(string new_title)
        {
            var editedPos = await _typeroomInterface.update(selectedType.id, new_title);
            if (editedPos == null)
            {
                MessageBox.Show("Ошибка редактирования");
                SaveBtn.IsEnabled = true;

                return;
            }

            NavigateToPositionsView();
        }

        private void NavigateToPositionsView()
        {
            MessageBox.Show("Данные сохранены");
            if (Application.Current.MainWindow is MainWindow mainWindow)
            {
                mainWindow.MainContentFrame.Navigate(new TypeRoomView());
            }
        }
    }
}
