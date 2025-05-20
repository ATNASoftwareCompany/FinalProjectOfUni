using DataModel.ViewModel;
using FinalApp.Access;
using FinalApp.Book;
using FinalApp.LogManagment;
using FinalApp.Users;
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

namespace FinalApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        FinalApp.MessageBox _msBox;
        AppPresenter.AppPresenter _presenter;

        public static string Username { get; set; }
        public static string Password { get; set; }
        public static int UserId { get; set; }

        public string _username { get; set; }
        public string _password { get; set; }
        public int _userId { get; set; }

        public static void SetStaticValue(int userId , string username , string password)
        {
            UserId = userId;
            Username = username;
            Password = password;
        }

        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            _msBox = new FinalApp.MessageBox();
            _presenter = new AppPresenter.AppPresenter();
            SetStaticValue(_userId, _username, _password);
            GetBooksCount();
            GetUsersCount();
        }

        private void txbBooks_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            var result = _presenter.CheckUserAccess(new Access_VM { ActionCode = new Action_VM { ActionCode = 10036}, UserId = UserId });
            if (result.ErrorCode != 0)
            {
                _msBox.Show(new MessageBox_VM
                {
                    OK = true,
                    ErrorType = DataModel.Enum.ErrorType.Error,
                    Message = "شما به این قسمت دسترسی ندارید",
                    Title = "دسترسی"
                });
                return;
            }
            BookManagment bookManagment = new BookManagment();
            bookManagment.ShowDialog();
        }

        private void GetUsersCount()
        {
            var result = _presenter.GetUsersCount(0);
            if (result.ErrorCode != 0)
            {
                _msBox.Show(new MessageBox_VM
                {
                    Title = "صفحه اصلی",
                    Message = result.Message,
                    ErrorType = result.ErrorType,
                    OK = true,
                });
                return;
            }
            txbUserNO.Text = result.Result.ToString() + " نفر ";
        }

        private void GetBooksCount()
        {
            var result = _presenter.GetBooksCount(0);
            if (result.ErrorCode != 0)
            {
                _msBox.Show(new MessageBox_VM
                {
                    Title = "صفحه اصلی",
                    Message = result.Message,
                    ErrorType = result.ErrorType,
                    OK = true,
                });
                return;
            }
            txbBooksNO.Text = result.Result.ToString() + " جلد ";
        }

        private void imginformation_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Information.Information information = new Information.Information();
            information.ShowDialog();
        }

        private void imgshutdown_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Login login = new Login();
            login._username = Username;
            login.Show();
            this.Close();
        }

        private void txbAccess_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            var result = _presenter.CheckUserAccess(new Access_VM { ActionCode = new Action_VM { ActionCode = 10037 }, UserId = UserId });
            if (result.ErrorCode != 0)
            {
                _msBox.Show(new MessageBox_VM
                {
                    OK = true,
                    ErrorType = DataModel.Enum.ErrorType.Error,
                    Message = "شما به این قسمت دسترسی ندارید",
                    Title = "دسترسی"
                });
                return;
            }
            AccessManagment accessManagment = new AccessManagment();
            accessManagment.ShowDialog();
        }

        private void txbRoles_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            var result = _presenter.CheckUserAccess(new Access_VM { ActionCode = new Action_VM { ActionCode = 10039 }, UserId = UserId });
            if (result.ErrorCode != 0)
            {
                _msBox.Show(new MessageBox_VM
                {
                    OK = true,
                    ErrorType = DataModel.Enum.ErrorType.Error,
                    Message = "شما به این قسمت دسترسی ندارید",
                    Title = "دسترسی"
                });
                return;
            }
            UsersManagment usersManagment = new UsersManagment();
            usersManagment.ShowDialog();
        }

        private void txbLogging_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            var result = _presenter.CheckUserAccess(new Access_VM { ActionCode = new Action_VM { ActionCode = 10038 }, UserId = UserId });
            if (result.ErrorCode != 0)
            {
                _msBox.Show(new MessageBox_VM
                {
                    OK = true,
                    ErrorType = DataModel.Enum.ErrorType.Error,
                    Message = "شما به این قسمت دسترسی ندارید",
                    Title = "دسترسی"
                });
                return;
            }
            LogManagment.LogManagment logManagment = new LogManagment.LogManagment();
            logManagment.ShowDialog();
        }
    }
}
