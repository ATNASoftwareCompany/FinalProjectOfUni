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
    /// Interaction logic for AddNewAuthor.xaml
    /// </summary>
    public partial class AddNewAuthor : Window
    {
        FinalApp.MessageBox _msBox;
        AppPresenter.AppPresenter _presenter;
        public bool isEdited = false;
        public BookAuthor_VM author;

        public AddNewAuthor()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            _msBox = new FinalApp.MessageBox();
            _presenter = new AppPresenter.AppPresenter();

            if (isEdited)
            {
                btnAddNewAuthor.Content = "ویرایش";
                txtNewAuthor.Text = author.Name;
            }
        }

        private void btnAddNewAuthor_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(txtNewAuthor.Text))
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

            if (isEdited)
            {

            }
            else
            {
                BookAuthor_VM bookPublisher = new BookAuthor_VM
                {
                    Name = txtNewAuthor.Text,
                    IsDelete = false,
                    Status = (int)BStatus.Active,
                };
                var result = _presenter.InsertBookAuthor(bookPublisher);
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
            }
            

            this.Close();
        }

        
    }
}
