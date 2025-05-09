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

namespace FinalApp.Book
{
    /// <summary>
    /// Interaction logic for BookManagment.xaml
    /// </summary>
    public partial class BookManagment : Window
    {
        FinalApp.MessageBox.MessageBox _msBox;
        AppPresenter.AppPresenter _presenter;
        public BookManagment()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            _msBox = new FinalApp.MessageBox.MessageBox();
            _presenter = new AppPresenter.AppPresenter();
        }

        private void btnAddNewBook_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnAddNewPublisher_Click(object sender, RoutedEventArgs e)
        {
            AddNewPublisher addNewPublisher = new AddNewPublisher();
            addNewPublisher.ShowDialog();
            
            var result = _presenter.GetAllPublishers(new DataModel.ViewModel.BookPublisher_VM { });

            PublishersDataGrid.ItemsSource = null;
            PublishersDataGrid.ItemsSource = result.Result as List<BookPublisher_VM>;
        }


    }
}
