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

namespace HotelApp.MVC.View.Admin.Modals.Positions
{
    /// <summary>
    /// Логика взаимодействия для AddPosition.xaml
    /// </summary>
    public partial class AddPosition : Page
    {
        private IPositionsInterface _positionInterface = new PositionsService();
        private bool isEditing = false;
        private Position selectedPosition; // Идентификатор должности, используемый при редактировании

        public AddPosition()
        {
            InitializeComponent();
        }

        // Добавьте конструктор для редактирования
        public AddPosition(Position position) : this()
        {
            isEditing = true;
            this.selectedPosition = position;

            title.Text = position.title;
            salary.Text = position.salary.ToString();

            //// Инициализация данных для редактирования
            //InitializeDataForEditing();
        }

        //private async void InitializeDataForEditing()
        //{
        //    //var position = await _positionInterface.getId(positionId);
        //    //if (position != null)
        //    //{
        //    //    // Заполните поля данными для редактирования
        //    //    title.Text = position.title;
        //    //    salary.Text = position.salary.ToString();
        //    //}
        //}

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            var new_title = title.Text;
            var new_salary = int.Parse(salary.Text);

            if (isEditing)
            {
                // Вызывайте метод для редактирования
                EditPosition(new_title, new_salary);
            }
            else
            {
                // Вызывайте метод для создания
                CreatePosition(new_title, new_salary);
            }
        }

        private async void CreatePosition(string new_title, int new_salary)
        {
            var newpos = await _positionInterface.create(new_title, new_salary);
            if (newpos == null)
            {
                MessageBox.Show("Ошибка сохранения");
                return;
            }

            NavigateToPositionsView();
        }

        private async void EditPosition(string new_title, int new_salary)
        {
            // Используйте positionId для редактирования существующей должности
            var editedPos = await _positionInterface.update(selectedPosition.id, new_title, new_salary);
            if (editedPos == null)
            {
                MessageBox.Show("Ошибка редактирования");
                return;
            }

            NavigateToPositionsView();
        }

        private void NavigateToPositionsView()
        {
            if (Application.Current.MainWindow is MainWindow mainWindow)
            {
                mainWindow.MainContentFrame.Navigate(new PositionsView());
            }
        }
    }

}
