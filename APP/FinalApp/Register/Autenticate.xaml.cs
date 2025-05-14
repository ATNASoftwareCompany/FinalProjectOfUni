using AppPresenter;
using DataModel.Enum;
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
        public Autenticate()
        {
            InitializeComponent();
            _presenter = new AppPresenter.AppPresenter();
        }
        public AuthenticateType authenticateType;
        public string PhoneNo = string.Empty;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var res = _presenter.InsertActivation(new DataModel.ViewModel.Activation_VM { });
        }

        private void PersonRegister()
        {

        }

        private void RestorePassword()
        {
            //var result = _presenter.
        }
    }
}
