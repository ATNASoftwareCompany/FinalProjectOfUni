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

namespace FinalApp.Book
{
    /// <summary>
    /// Interaction logic for AddNewPublisher.xaml
    /// </summary>
    public partial class AddNewPublisher : Window
    {
        FinalApp.MessageBox.MessageBox _msBox;
        AppPresenter.AppPresenter _presenter;
        public AddNewPublisher()
        {
            InitializeComponent();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            _msBox = new FinalApp.MessageBox.MessageBox();
            _presenter = new AppPresenter.AppPresenter();
        }
        
        private void btnAddNewPublisher_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(txtNewPublisher.Text))
            {
                _msBox.Show(new MessageBox_VM
                {
                    Title = "افزودن ناشر جدید",
                    Message = "لطفا نام ناشر کنید",
                    ErrorType = DataModel.Enum.ErrorType.Warning,
                    OK = true,
                });
                return;
            }

            BookPublisher_VM bookPublisher = new BookPublisher_VM
            {
                PublisherName = txtNewPublisher.Text,
                IsDelete = false,
                Status = (int)BStatus.Active,
            };
            var result = _presenter.InsertBookPublisher(bookPublisher);
            if (result.ErrorCode != 0)
            {
                _msBox.Show(new MessageBox_VM
                {
                    Title = "افزودن ناشر جدید",
                    Message = result.Message,
                    ErrorType = result.ErrorType,
                    OK = true,
                });
                return;
            }

            _msBox.Show(new MessageBox_VM
            {
                Title = "افزودن ناشر جدید",
                Message = result.Message,
                ErrorType = result.ErrorType,
                OK = true,
            });

            this.Close();
        }

    }
}
