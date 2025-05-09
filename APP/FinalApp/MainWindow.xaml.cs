using DataModel.ViewModel;
using FinalApp.Book;
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
        FinalApp.MessageBox.MessageBox _msBox;
        AppPresenter.AppPresenter _presenter;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            _msBox = new FinalApp.MessageBox.MessageBox();
            _presenter = new AppPresenter.AppPresenter();
            GetBooksCount();
        }

        private void txbBooks_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            BookManagment bookManagment = new BookManagment();
            bookManagment.ShowDialog();
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
            txbBooksNO.Text = result.Result.ToString() + " عدد ";
        }


    }
}
