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
    /// Interaction logic for Register.xaml
    /// </summary>
    public partial class Register : Window
    {
        public Register()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, RoutedEventArgs e)
        {
            var result = new AppPresenter.AppPresenter().InsertActivation(new DataModel.ViewModel.Activation_VM { PhoneNo = txtMobile.Text.Trim() });
        }

        private void RegisterUser()
        {
            Person_VM person = new Person_VM
            {
                PhoneNo = txtMobile.Text.Trim(),
                Name = txtName.Text.Trim(),
                Family = txtFamily.Text.Trim(),
                BirthDate = txtBirthDate.Text.Trim(),
                E_Mail = txtEmail.Text.Trim(),
            };

        }

        private void Authentication()
        {
            
        }
    }
}
