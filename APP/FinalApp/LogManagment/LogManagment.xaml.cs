using DataModel.Logging;
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

namespace FinalApp.LogManagment
{
    /// <summary>
    /// Interaction logic for LogManagment.xaml
    /// </summary>
    public partial class LogManagment : Window
    {
        public LogManagment()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var result = new AppPresenter.AppPresenter().GetResponseLogList(0);
            List<ResponseBaseLog_VM> responseBaseLog_VMs = result.Result as List<ResponseBaseLog_VM>;

            LogGrid.DataContext = null;
            LogGrid.DataContext = responseBaseLog_VMs;
        }

        private void Image_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }
    }
}
