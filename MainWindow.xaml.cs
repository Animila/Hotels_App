using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media.Animation;
using HotelApp.MVVM.Model;
using HotelApp.MVVM.Storage;
using HotelApp.MVVM.View;
using HotelApp.MVVM.View.Admin;
using HotelApp.MVVM.View.Admin.ExtraPage;

namespace HotelApp
{
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        public Frame localMainContentFrame { get; set; }

        

        public MainWindow()
        {
            if(UserProfile.Instance.CurrentUser == null)
            {
                AuthWindows authWindow = new AuthWindows();
                authWindow.ShowDialog();
            }
            InitializeComponent();

            // Отобразите AuthWindows

            var currentUser = UserProfile.Instance.CurrentUser;

            firstLastName.Text = currentUser.account.first_name + " " + currentUser.account.last_name;
            typeUser.Text = currentUser.type;

            localMainContentFrame = MainContentFrame;
            MainContentFrame.Navigate(new StatisticView());
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if(e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }

        private bool isMaximized = false;

        public event PropertyChangedEventHandler PropertyChanged;

        private void Border_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if(e.ClickCount == 2 )
            {
                if(isMaximized )
                {
                    this.WindowState = WindowState.Normal;
                    this.Width = 1300;
                    this.Height = 750;

                    isMaximized = false;
                } else
                {
                    this.WindowState= WindowState.Maximized;
                    isMaximized= true;
                }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            Storyboard sb = (Storyboard)FindResource("MenuSlideIn");
            if (Sidebar.RenderTransform.Value.OffsetX == -237)
            {
                sb = (Storyboard)FindResource("MenuSlideOut");
            }
            sb.Begin();
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
                Close(); // Закрываем окно
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MainContentFrame.Navigate(new StatisticView());
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            MainContentFrame.Navigate(new AdministrationView());
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            MainContentFrame.Navigate(new PersonalPage());
        }

        private void exitBtn(object sender, RoutedEventArgs e)
        {
            UserProfile.Instance.CurrentUser = null;
            AuthWindows auth = new AuthWindows();
            auth.Show();
            this.Close();
        }
    }
}
