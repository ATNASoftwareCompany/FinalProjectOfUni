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
    /// Interaction logic for AddNewGenre.xaml
    /// </summary>
    public partial class AddNewGenre : Window
    {
        FinalApp.MessageBox _msBox;
        AppPresenter.AppPresenter _presenter;
        public AddNewGenre()
        {
            InitializeComponent();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            _msBox = new FinalApp.MessageBox();
            _presenter = new AppPresenter.AppPresenter();
        }

        private void btnAddNewGenre_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(txtNewGenre.Text))
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

            BookGenre_VM bookGenre = new BookGenre_VM
            {
                GenreName = txtNewGenre.Text,
                IsDelete = false,
                Status = (int)BStatus.Active,
            };
            var result = _presenter.InsertBookGenre(bookGenre);
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
