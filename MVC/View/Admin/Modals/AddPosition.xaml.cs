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
    /// Логика взаимодействия для AddPosition.xaml
    /// </summary>
    public partial class AddPosition : Page
    {
        private IPositionInterface _positionInterface = new PositionService();
        private bool isEditing = false;
        private Position selectedPosition;

        public AddPosition()
        {
            InitializeComponent();
            titleAdd.Text = "Создание";
        }

        public AddPosition(Position position) : this()
        {
            isEditing = true;
            this.selectedPosition = position;
            title.Text = position.title;
            salary.Text = position.salary.ToString();
            titleAdd.Text = "Редактирование";
        }


        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {

            SaveBtn.IsEnabled = false;
            var new_title = title.Text;
            var new_salary = int.Parse(salary.Text);

            if (isEditing)
            {
                EditPosition(new_title, new_salary);
            }
            else
            {
                CreatePosition(new_title, new_salary);
            }
        }

        private void BackButton(object sender, RoutedEventArgs e)
        {
            NavigationService?.GoBack();
        }

        private async void CreatePosition(string new_title, int new_salary)
        {
            var newpos = await _positionInterface.create(new_title, new_salary);
            if (newpos == null)
            {
                MessageBox.Show("Ошибка сохранения");
                SaveBtn.IsEnabled = true;

                return;
            }

            NavigateToPositionsView();
        }

        private async void EditPosition(string new_title, int new_salary)
        {
            var editedPos = await _positionInterface.update(selectedPosition.id, new_title, new_salary);
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
                mainWindow.MainContentFrame.Navigate(new PositionsView());
            }
        }
    }

}
