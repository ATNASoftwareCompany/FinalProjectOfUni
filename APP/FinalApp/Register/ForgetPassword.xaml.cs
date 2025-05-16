using AppPresenter;
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
    /// Interaction logic for ForgetPassword.xaml
    /// </summary>
    public partial class ForgetPassword : Window
    {
        AppPresenter.AppPresenter _presenter;
        public ForgetPassword()
        {
            InitializeComponent();
            _presenter = new AppPresenter.AppPresenter();
        }
        
        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }

        private void btnAuthenticate_Click(object sender, RoutedEventArgs e)
        {
            var result = _presenter.UserAuthentication(txtPhoneNo.Text.Trim());
            Autenticate autenticate = new Autenticate();
            autenticate.authenticateType = DataModel.Enum.AuthenticateType.RestorePassword;
            autenticate.PhoneNo = txtPhoneNo.Text.Trim();
            autenticate.ShowDialog();

            ChangePassword changePassword = new ChangePassword();
            changePassword._userName = txtPhoneNo.Text;
            changePassword.ShowDialog();
            Login login = new Login();
            login.Show();
            this.Close();
        }
    }
}
