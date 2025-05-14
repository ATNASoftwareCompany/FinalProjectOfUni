using DataModel.ViewModel;
using FinalApp.Book.DTOs;
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
    /// Interaction logic for AddNewBook.xaml
    /// </summary>
    public partial class AddNewBook : Window
    {
        #region models
        FinalApp.MessageBox msBox;
        List<CollectionDTOs> collectionDTOs = new List<CollectionDTOs>();

        #endregion
        public AddNewBook()
        {
            InitializeComponent();
            
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            msBox = new FinalApp.MessageBox();
        }

        private void chbHasDiscount_Checked(object sender, RoutedEventArgs e)
        {
            txtDiscountType.IsEnabled = true;
            txtDiscountType.SelectedIndex = 0;
            txtDiscountAmount.IsEnabled = true;
        }

        private void chbHasDiscount_Unchecked(object sender, RoutedEventArgs e)
        {
            txtDiscountType.IsEnabled = false;
            txtDiscountType.SelectedIndex = -1;
            txtDiscountAmount.IsEnabled = false;
        }

        private bool ValidationForm()
        {
            if (string.IsNullOrEmpty(txtTitle.Text))
            {
                msBox.Show(new MessageBox_VM
                {
                    Title = "افزودن کتاب جدید",
                    Message = "لطفا فیلد عنوان کتاب را کامل کنید",
                    ErrorType = DataModel.Enum.ErrorType.Warning,
                    OK = true,
                });
                return false;
            }

            if (string.IsNullOrEmpty(txtSummary.Text))
            {
                msBox.Show(new MessageBox_VM
                {
                    Title = "افزودن کتاب جدید",
                    Message = "لطفا فیلد خلاصه را کامل کنید",
                    ErrorType = DataModel.Enum.ErrorType.Warning,
                    OK = true,
                });
                return false;
            }

            if (string.IsNullOrEmpty(txtGenre.Text))
            {
                msBox.Show(new MessageBox_VM
                {
                    Title = "افزودن کتاب جدید",
                    Message = "لطفا فیلد ژانر را کامل کنید",
                    ErrorType = DataModel.Enum.ErrorType.Warning,
                    OK = true,
                });
                return false;
            }

            if (string.IsNullOrEmpty(txtPublisher.Text))
            {
                msBox.Show(new MessageBox_VM
                {
                    Title = "افزودن کتاب جدید",
                    Message = "لطفا فیلد ناشر را کامل کنید",
                    ErrorType = DataModel.Enum.ErrorType.Warning,
                    OK = true,
                });
                return false;
            }

            if (string.IsNullOrEmpty(txtAuthor.Text))
            {
                msBox.Show(new MessageBox_VM
                {
                    Title = "افزودن کتاب جدید",
                    Message = "لطفا فیلد نویسنده را کامل کنید",
                    ErrorType = DataModel.Enum.ErrorType.Warning,
                    OK = true,
                });
                return false;
            }

            if (string.IsNullOrEmpty(dtpWriteDate.Text))
            {
                msBox.Show(new MessageBox_VM
                {
                    Title = "افزودن کتاب جدید",
                    Message = "لطفا فیلد تاریخ تالیف را کامل کنید",
                    ErrorType = DataModel.Enum.ErrorType.Warning,
                    OK = true,
                });
                return false;
            }

            if (string.IsNullOrEmpty(txtPrice.Text))
            {
                msBox.Show(new MessageBox_VM
                {
                    Title = "افزودن کتاب جدید",
                    Message = "لطفا فیلد قیمت را کامل کنید",
                    ErrorType = DataModel.Enum.ErrorType.Warning,
                    OK = true,
                });
                return false;
            }

            if (string.IsNullOrEmpty(txtQuantity.Text))
            {
                msBox.Show(new MessageBox_VM
                {
                    Title = "افزودن کتاب جدید",
                    Message = "لطفا فیلد تعداد را کامل کنید",
                    ErrorType = DataModel.Enum.ErrorType.Warning,
                    OK = true,
                });
                return false;
            }

            if (chbHasDiscount.IsChecked == true)
            {
                if (txtDiscountType.SelectedIndex == -1)
                {
                    msBox.Show(new MessageBox_VM
                    {
                        Title = "افزودن کتاب جدید",
                        Message = "لطفا فیلد نوع تخفیف را کامل کنید",
                        ErrorType = DataModel.Enum.ErrorType.Warning,
                        OK = true,
                    });
                    return false;
                }

                if (string.IsNullOrEmpty(txtDiscountAmount.Text))
                {
                    msBox.Show(new MessageBox_VM
                    {
                        Title = "افزودن کتاب جدید",
                        Message = "لطفا فیلد مقدار را کامل کنید",
                        ErrorType = DataModel.Enum.ErrorType.Warning,
                        OK = true,
                    });
                    return false;
                }
            }


            if (chbHasCollection.IsChecked == true && collectionDTOs.Count == 0)
            {
                msBox.Show(new MessageBox_VM
                {
                    Title = "افزودن کتاب جدید",
                    Message = "لطفا مجموعه های مرتبط با کتاب را کامل کنید",
                    ErrorType = DataModel.Enum.ErrorType.Warning,
                    OK = true,
                });
                return false;
            }

            return true;
        }

        private void btnAddNewBook_Click(object sender, RoutedEventArgs e)
        {
            ValidationForm();
            if(ValidationForm())
            {
                return;
            }
            Book_VM newBook = new Book_VM
            {
                //Author = txtAuthor.Text,
                //BookGenre = txtGenre.Text,
            };
        }

        
    }
}
