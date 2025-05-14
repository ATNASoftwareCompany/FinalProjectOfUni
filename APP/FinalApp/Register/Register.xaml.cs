using DataModel;
using FinalApp.MessageBox;
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
    /// Interaction logic for Register.xaml
    /// </summary>
    public partial class Register : Window
    {
        AppPresenter.AppPresenter _presenter;
        MessageBox.MessageBox msgBox;
        public Register()
        {
            InitializeComponent();
            _presenter = new AppPresenter.AppPresenter();
            msgBox = new MessageBox.MessageBox();
        }

        private void btnRegister_Click(object sender, RoutedEventArgs e)
        {
            Authentication();
            RegisterPerson();
            Autenticate autenticate = new Autenticate();
            autenticate.ShowDialog();
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void RegisterPerson()
        {
            if (txtConfirmPassword.Text != txtPassword.Text)
            {
                msgBox.Show(new DataModel.ViewModel.MessageBox_VM
                {
                    ErrorType = DataModel.Enum.ErrorType.Warning,
                    OK = true,
                    Message = "لطفا در وارد نمودن کلمه عبور و تکرار آن دقت فرمایید",
                    Title = "ثبت نام"
                });
                return;
            }

            Person_VM person = new Person_VM
            {
                PhoneNo = txtMobile.Text.Trim(),
                Name = txtName.Text.Trim(),
                Family = txtFamily.Text.Trim(),
                BirthDate = txtBirthDate.Text.Trim(),
                E_Mail = txtEmail.Text.Trim(),
                Password = txtPassword.Text,
            };
            var result = _presenter.InsertPerson(person);
            if (result.ErrorCode != 0)
            {
                msgBox.Show(new DataModel.ViewModel.MessageBox_VM
                {
                    ErrorType = DataModel.Enum.ErrorType.Error,
                    OK = true,
                    Message = result.Message,
                    Title = "ثبت نام"
                });
                return;
            }

        }

        private void Authentication()
        {
            var result = _presenter.UserAuthentication(txtMobile.Text.Trim());
            if (result.ErrorCode != 0)
            {
                msgBox.Show(new DataModel.ViewModel.MessageBox_VM
                {
                    ErrorType = DataModel.Enum.ErrorType.Error,
                    OK = true,
                    Message = result.Message,
                    Title = "ثبت نام"
                });
                return;
            }
        }
    }
}
