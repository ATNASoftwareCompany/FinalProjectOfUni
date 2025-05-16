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
    /// Interaction logic for ChangePassword.xaml
    /// </summary>
    public partial class ChangePassword : Window
    {
        AppPresenter.AppPresenter _presenter;
        FinalApp.MessageBox _msBox;
        public ChangePassword()
        {
            InitializeComponent();
            _presenter = new AppPresenter.AppPresenter();
            _msBox = new FinalApp.MessageBox();
        }

        public string _userName = string.Empty;
        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnRestorePassword_Click(object sender, RoutedEventArgs e)
        {
            ResetPassword();
            
        }

        public void ResetPassword()
        {
            var result = _presenter.GetUserSingle(new DataModel.User_VM { UserName = _userName });
            if(result.ErrorCode != 0)
            {
                _msBox.Show(new DataModel.ViewModel.MessageBox_VM
                {
                    OK = true,
                    ErrorType = result.ErrorType,
                    Title = "بازیابی کلمه عبور",
                    Message = result.Message,
                });
                return;
            }
            User_VM user = result.Result as User_VM;

            if (txtNewPassword.Password != txtConfirmNewPassword.Password)
            {
                _msBox.Show(new DataModel.ViewModel.MessageBox_VM
                {
                    OK = true,
                    ErrorType = DataModel.Enum.ErrorType.Warning,
                    Title = "بازیابی کلمه عبور",
                    Message = "عدم تطابق کلمه عبور جدید و تکرار آن",
                });
                return;
            }
            user.Password = txtNewPassword.Password;
            user.UpdateDate = DateTime.Now;
            result = _presenter.UpdateUser(user);
            if (result.ErrorCode != 0)
            {
                _msBox.Show(new DataModel.ViewModel.MessageBox_VM
                {
                    OK = true,
                    ErrorType = result.ErrorType,
                    Title = "بازیابی کلمه عبور",
                    Message = result.Message,
                });
                return;
            }

            _msBox.Show(new DataModel.ViewModel.MessageBox_VM
            {
                OK = true,
                ErrorType = DataModel.Enum.ErrorType.Sussess,
                Title = "بازیابی کلمه عبور",
                Message = "عملیات با موفقیت انجام شد",
            });
            this.Close();
        }
    }
}
