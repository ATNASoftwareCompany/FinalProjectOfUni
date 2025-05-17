using AppPresenter;
using DataModel.Enum;
using DataModel.ViewModel;
using FinalApp.Book.DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
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
        AppPresenter.AppPresenter _presenter;
        FinalApp.MessageBox msBox;
        List<CollectionDTOs> collectionDTOs = new List<CollectionDTOs>();

        #endregion
        public AddNewBook()
        {
            InitializeComponent();
            msBox = new FinalApp.MessageBox();
            _presenter = new AppPresenter.AppPresenter();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            GetAllNeccesseryThingsForRegisterNewBook();
        }

        public void GetAllNeccesseryThingsForRegisterNewBook()
        {
            GetAuthorList();
            GetPublisherList();
            GetGenreList();
        }

        public void GetAuthorList()
        {
            var result = _presenter.GetAllBookAuthor(new BookAuthor_VM { });
            txtAuthor.ItemsSource = (result.Result as List<BookAuthor_VM>).ToList();
        }

        public void GetPublisherList()
        {
            var result = _presenter.GetAllPublishers(new BookPublisher_VM { });
            txtPublisher.ItemsSource = (result.Result as List<BookPublisher_VM>).ToList();
        }

        public void GetGenreList()
        {
            var result = _presenter.GetAllBookGenre(new BookGenre_VM { });
            txtGenre.ItemsSource = (result.Result as List<BookGenre_VM>).ToList();
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
            bool isValidate = ValidationForm();
            if (isValidate)
            {
                return;
            }
            Book_VM newBook = new Book_VM
            {
                Author = ((txtAuthor.SelectedItem) as BookAuthor_VM).Id,
                BookGenre = (txtGenre.SelectedItem as BookGenre_VM).Id,
                Publisher  =(txtPublisher.SelectedItem as BookPublisher_VM).Id,
                BookTitle = txtTitle.Text,
                Price = Convert.ToDouble(txtPrice.Text),
                Quantity = Convert.ToInt32(txtQuantity.Text),
                IsDelete = false,
                InsertDate = DateTime.Now,
                DiscountAmount = Convert.ToInt32(txtDiscountAmount.Text),
                //HasCollection = chbHasCollection
                HasDiscount = chbHasDiscount.IsChecked == null ? false : true,
                Summary = txtSummary.Text,
                Status = (int)BStatus.Active,
                WriteDate = Convert.ToDateTime(dtpWriteDate.Text),
            };



        }

        public void GetDiscountTypeList()
        {
            var result = generateEnum<DiscountType>();
            txtDiscountType.ItemsSource = result;
        }

        private void Image_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }

        public List<EnumInfo> generateEnum<T>()
        {
            var type = typeof(T);
            return Enum.GetValues(type)
                       .Cast<T>()
                       .Select(e => new EnumInfo
                       {
                           Name = e.ToString(),
                           Value = Convert.ToInt32(e),
                           Description = type
                               .GetMember(e.ToString())[0]
                               .GetCustomAttribute<DescriptionAttribute>()?.Description ?? e.ToString()
                       })
                       .ToList();
        }
    }
}
