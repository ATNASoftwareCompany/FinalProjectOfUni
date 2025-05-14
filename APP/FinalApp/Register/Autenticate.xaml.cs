using AppPresenter;
using DataModel.Enum;
using DataModel.ViewModel;
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
    /// Interaction logic for Autenticate.xaml
    /// </summary>
    public partial class Autenticate : Window
    {
        AppPresenter.AppPresenter _presenter;
        MessageBox _msgBox;
        public Autenticate()
        {
            InitializeComponent();
            _presenter = new AppPresenter.AppPresenter();
            _msgBox = new MessageBox();
        }
        public AuthenticateType authenticateType;
        public string PhoneNo = string.Empty;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(authenticateType == AuthenticateType.Register)
            {
                PersonRegister();
            }

            if (authenticateType == AuthenticateType.RestorePassword)
            {
                RestorePassword();
            }

            Login login = new Login();
            login._username = PhoneNo;
            login.Show();
            this.Close();
        }

        private void PersonRegister()
        {
            _msgBox.Show(new DataModel.ViewModel.MessageBox_VM
            {
                ErrorType = ErrorType.Sussess,
                OK = true,
                Title = "بازیابی کلمه عبور",
                Message = "عملیات با موفقیت انجام شد",
            });
        }

        private void RestorePassword()
        {
            var result = _presenter.GetActivationByPhoneNo(PhoneNo);
            if(result.ErrorCode != 0)
            {
                _msgBox.Show(new DataModel.ViewModel.MessageBox_VM
                {
                    ErrorType = result.ErrorType,
                    OK = true,
                    Title = "بازیابی کلمه عبور",
                    Message = result.Message,
                });
                return;
            }

            Activation_VM activation = result.Result as Activation_VM;

            if(activation.ActivationCode != Convert.ToInt32(txtActiveCode.Text.Trim()))
            {
                _msgBox.Show(new DataModel.ViewModel.MessageBox_VM
                {
                    ErrorType = result.ErrorType,
                    OK = true,
                    Title = "بازیابی کلمه عبور",
                    Message = "لطفا کد اعتبارسنجی صحیح را وارد نمایید.",
                });
                return;
            }

            _msgBox.Show(new DataModel.ViewModel.MessageBox_VM
            {
                ErrorType = result.ErrorType,
                OK = true,
                Title = "بازیابی کلمه عبور",
                Message = "عملیات با موفقیت انجام شد",
            });
            activation.Status = (int)BStatus.DeActiva;
            activation.IsDelete = false;
            _presenter.UpdateActivation(activation);
            return;
        }
    }
}
