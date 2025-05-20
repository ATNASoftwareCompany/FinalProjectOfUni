using DataModel;
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
using System.Windows.Shapes;

namespace FinalApp
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        AppPresenter.AppPresenter _presenter;
        MessageBox _msgBox;
        public string _username = string.Empty;
        public Login()
        {
            InitializeComponent();
            _presenter = new AppPresenter.AppPresenter();
            _msgBox = new MessageBox();
        }


        private void TextBlock_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Register register = new Register();
            register.Show();
            this.Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            txtUserName.Text = _username;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(txtUserName.Text) || string.IsNullOrEmpty(txtPassword.Password))
            {
                _msgBox.Show(new DataModel.ViewModel.MessageBox_VM
                {
                    OK = true,
                    ErrorType = DataModel.Enum.ErrorType.Error,
                    Message = "لطفا نام کاربری و کلمه عبور را وارد نمایید",
                    Title = "ورود به سیستم"
                });
                //_msgBox.ShowDialog();
                return;
            }
            _username = txtUserName.Text;
            LoginApp();
        }

        private void LoginApp()
        {
            var result = _presenter.GetUserSingle(new DataModel.User_VM { UserName = txtUserName.Text });
            if (result.ErrorCode != 0 && result.ErrorCode != 5)
            {
                _msgBox.Show(new DataModel.ViewModel.MessageBox_VM
                {
                    OK = true,
                    ErrorType = result.ErrorType,
                    Message = result.Message,
                    Title = "ورود به سیستم"
                });
                return;
            }

            if (result.ErrorCode == 5)
            {
                _msgBox.Show(new DataModel.ViewModel.MessageBox_VM
                {
                    OK = true,
                    ErrorType = result.ErrorType,
                    Message = result.Message,
                    Title = "ورود به سیستم"
                });
                result = _presenter.UserAuthentication(_username.Trim());
                Autenticate autenticate = new Autenticate();
                autenticate.authenticateType = DataModel.Enum.AuthenticateType.RestorePassword;
                autenticate.PhoneNo = _username.Trim();
                autenticate.ShowDialog();
                return;
            }

            User_VM user = result.Result as User_VM;

            if (user.Password != txtPassword.Password)
            {
                _msgBox.Show(new DataModel.ViewModel.MessageBox_VM
                {
                    OK = true,
                    ErrorType = DataModel.Enum.ErrorType.Error,
                    Message = "لطفا کلمه عبور صحیح را وارد نمایید",
                    Title = "ورود به سیستم"
                });
                return;
            }

            MainWindow mainWindow = new MainWindow();
            mainWindow._username = _username;
            mainWindow._userId = user.Id;
            mainWindow._password = txtPassword.Password;
            mainWindow.Show();
            this.Close();
        }

        private void Image_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            App.Current.Shutdown();
        }

        private void Hyperlink_Click(object sender, RoutedEventArgs e)
        {
            ForgetPassword forgetPassword = new ForgetPassword();
            forgetPassword.Show();
            this.Close();
        }

        private void Hyperlink_Click_1(object sender, RoutedEventArgs e)
        {
            Register register = new Register();
            register.Show();
            this.Close();
        }
    }
}
