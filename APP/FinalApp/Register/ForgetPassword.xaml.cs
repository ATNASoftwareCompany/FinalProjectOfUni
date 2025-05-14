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
        public ForgetPassword()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }

        private void btnAuthenticate_Click(object sender, RoutedEventArgs e)
        {
            Autenticate autenticate = new Autenticate();
            autenticate.authenticateType = DataModel.Enum.AuthenticateType.RestorePassword;
            autenticate.PhoneNo = txtPhoneNo.Text.Trim();
            autenticate.Show();
            this.Close();
        }
    }
}
