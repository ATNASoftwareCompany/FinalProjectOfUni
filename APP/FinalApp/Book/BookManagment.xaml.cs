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
    /// Interaction logic for BookManagment.xaml
    /// </summary>
    public partial class BookManagment : Window
    {
        FinalApp.MessageBox _msBox;
        AppPresenter.AppPresenter _presenter;
        public BookManagment()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            _msBox = new FinalApp.MessageBox();
            _presenter = new AppPresenter.AppPresenter();
            GenerateDataInFormLoad();
        }



        private void BookList()
        {
            var result = _presenter.GetBooksListForShow(new Book_VM { });
            if (result.ErrorCode != 0)
            {
                _msBox.Show(new MessageBox_VM
                {
                    OK = true,
                    ErrorType = DataModel.Enum.ErrorType.Error,
                    Title = "مدیریت کتاب ها",
                    Message = "خطا در واکشی لیست کتاب ها"
                });
                return;
            }

            List<Book_VM> books = result.Result as List<Book_VM>;
            List<BookDTO> showbooks = new List<BookDTO>();
            int rowNumber = 0;
            foreach (var item in books)
            {
                rowNumber++;
                BookDTO showBook = new BookDTO
                {
                    BookId = item.Id,
                    BookTitle = item.BookTitle,
                    Price = item.Price,
                    Quantity = item.Quantity,
                    RowNumber = rowNumber,
                    BookGenre = _presenter.GetGenreName(item.BookGenre).Result.ToString(),
                    Author = _presenter.GetAuthorName(item.Author).Result.ToString(),
                    Publisher = _presenter.GetPublisherName(item.Publisher).Result.ToString(),
                };
                showBook.WriteDate = item.WriteDate.ToShortDateString();
                showbooks.Add(showBook);
            }


            BooksDataGrid.ItemsSource = null;
            BooksDataGrid.ItemsSource = showbooks;

        }


        private void Image_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }





        private void GenerateDataInFormLoad()
        {
            BookList();
            var result = _presenter.GetAllBookGenre(new BookGenre_VM { });
            List<CollectionDTOs> GenreList = new List<CollectionDTOs>();
            int rowNumber = 0;
            foreach (var item in result.Result as List<BookGenre_VM>)
            {
                rowNumber++;
                CollectionDTOs collection = new CollectionDTOs
                {
                    Genre = item.GenreName,
                    GenreID = item.Id,
                    RowNumber = rowNumber
                };
                GenreList.Add(collection);
            }

            result = _presenter.GetAllBookAuthor(new DataModel.ViewModel.BookAuthor_VM { });
            List<CollectionDTOs> AuthorList = new List<CollectionDTOs>();
            rowNumber = 0;
            foreach (var item in result.Result as List<BookAuthor_VM>)
            {
                rowNumber++;
                CollectionDTOs collection = new CollectionDTOs
                {
                    AuthorID = item.Id,
                    Author = item.Name,
                    RowNumber = rowNumber
                };
                AuthorList.Add(collection);
            }

            result = _presenter.GetAllPublishers(new DataModel.ViewModel.BookPublisher_VM { });
            List<CollectionDTOs> PublisherList = new List<CollectionDTOs>();
            rowNumber = 0;
            foreach (var item in result.Result as List<BookPublisher_VM>)
            {
                rowNumber++;
                CollectionDTOs collection = new CollectionDTOs
                {
                    PublisherID = item.Id,
                    Publisher = item.PublisherName,
                    RowNumber = rowNumber
                };
                PublisherList.Add(collection);
            }

            PublishersDataGrid.ItemsSource = null;
            PublishersDataGrid.ItemsSource = PublisherList;

            AuthorsDataGrid.ItemsSource = null;
            AuthorsDataGrid.ItemsSource = AuthorList;

            GenresDataGrid.ItemsSource = null;
            GenresDataGrid.ItemsSource = GenreList;
        }

        private void btnAddNewGenre_Click(object sender, RoutedEventArgs e)
        {
            AddNewGenre addNewGenre = new AddNewGenre();
            addNewGenre.ShowDialog();

            var result = _presenter.GetAllBookGenre(new BookGenre_VM { });
            List<CollectionDTOs> GenreList = new List<CollectionDTOs>();
            int rowNumber = 0;
            foreach (var item in result.Result as List<BookGenre_VM>)
            {
                rowNumber++;
                CollectionDTOs collection = new CollectionDTOs
                {
                    GenreID = item.Id,
                    Genre = item.GenreName,
                    RowNumber = rowNumber
                };
                GenreList.Add(collection);
            }


            GenresDataGrid.ItemsSource = null;
            GenresDataGrid.ItemsSource = GenreList;

        }
        private void GenresDataGrid_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            AddNewGenre addNewGenre = new AddNewGenre();
            CollectionDTOs collection = GenresDataGrid.SelectedItem as CollectionDTOs;
            BookGenre_VM bookGenre = new BookGenre_VM
            {
                Id = collection.GenreID,
                GenreName = collection.Genre
            };
            addNewGenre.isEdited = true;
            addNewGenre.genre = bookGenre;
            addNewGenre.ShowDialog();

            GenerateDataInFormLoad();
        }

        private void btnAddNewAuthor_Click(object sender, RoutedEventArgs e)
        {
            AddNewAuthor addNewAuthor = new AddNewAuthor();
            addNewAuthor.ShowDialog();

            var result = _presenter.GetAllBookAuthor(new DataModel.ViewModel.BookAuthor_VM { });
            List<CollectionDTOs> AuthorList = new List<CollectionDTOs>();
            int rowNumber = 0;
            foreach (var item in result.Result as List<BookAuthor_VM>)
            {
                rowNumber++;
                CollectionDTOs collection = new CollectionDTOs
                {
                    AuthorID = item.Id,
                    Author = item.Name,
                    RowNumber = rowNumber
                };
                AuthorList.Add(collection);
            }

            AuthorsDataGrid.ItemsSource = null;
            AuthorsDataGrid.ItemsSource = AuthorList;
        }
        private void AuthorsDataGrid_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            AddNewAuthor addNewAuthor = new AddNewAuthor();
            CollectionDTOs collection = AuthorsDataGrid.SelectedItem as CollectionDTOs;
            BookAuthor_VM bookAuthor = new BookAuthor_VM
            {
                Id = collection.AuthorID,
                Name = collection.Author,
            };
            addNewAuthor.isEdited = true;
            addNewAuthor.author = bookAuthor;
            addNewAuthor.ShowDialog();

            GenerateDataInFormLoad();
        }

        private void btnAddNewPublisher_Click(object sender, RoutedEventArgs e)
        {
            AddNewPublisher addNewPublisher = new AddNewPublisher();
            addNewPublisher.ShowDialog();

            var result = _presenter.GetAllPublishers(new DataModel.ViewModel.BookPublisher_VM { });
            List<CollectionDTOs> PublisherList = new List<CollectionDTOs>();
            int rowNumber = 0;
            foreach (var item in result.Result as List<BookPublisher_VM>)
            {
                rowNumber++;
                CollectionDTOs collection = new CollectionDTOs
                {
                    PublisherID = item.Id,
                    Publisher = item.PublisherName,
                    RowNumber = rowNumber
                };
                PublisherList.Add(collection);
            }
            PublishersDataGrid.ItemsSource = null;
            PublishersDataGrid.ItemsSource = PublisherList;
        }
        private void PublishersDataGrid_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            AddNewPublisher addNewAuthor = new AddNewPublisher();
            CollectionDTOs collection = PublishersDataGrid.SelectedItem as CollectionDTOs;

            BookPublisher_VM bookAuthor = new BookPublisher_VM
            {
                Id = collection.PublisherID,
                PublisherName = collection.Publisher,
            };
            addNewAuthor.isEdited = true;
            addNewAuthor.publisher = bookAuthor;
            addNewAuthor.ShowDialog();

            GenerateDataInFormLoad();
        }

        private void btnAddNewBook_Click(object sender, RoutedEventArgs e)
        {
            AddNewBook addNewBook = new AddNewBook();
            addNewBook.ShowDialog();

            BookList();
        }

        private void BooksDataGrid_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            AddNewBook addNewBook = new AddNewBook();
            BookDTO bookDTO = BooksDataGrid.SelectedItem as BookDTO;
            addNewBook.isEdited = true;
            addNewBook.bookID = bookDTO.BookId;
            addNewBook.ShowDialog();

            GenerateDataInFormLoad();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            var result = BooksDataGrid.SelectedItem as BookDTO;
            var isDeleted = _presenter.DeleteBook(result.BookId);
            if (!(bool)isDeleted.Result)
            {
                _msBox.Show(new MessageBox_VM
                {
                    ErrorType = DataModel.Enum.ErrorType.Error,
                    OK = true,
                    Message = "خطا در حذف رکورد",
                    Title = "حذف"
                });
                return;
            }
            _msBox.Show(new MessageBox_VM
            {
                ErrorType = DataModel.Enum.ErrorType.Sussess,
                OK = true,
                Message = isDeleted.Message,
                Title = "حذف"
            });
            GenerateDataInFormLoad();
            return;
        }

        private void PublisherData_Click(object sender, RoutedEventArgs e)
        {
            var result = PublishersDataGrid.SelectedItem as CollectionDTOs;
            var getdata = _presenter.GetBookPublisher(result.PublisherID);
            BookPublisher_VM bookPublisher = getdata.Result as BookPublisher_VM;
            bookPublisher.IsDelete = true;
            var isDeleted = _presenter.UpdateBookPublisher(bookPublisher);
            if (!(bool)isDeleted.Result)
            {
                _msBox.Show(new MessageBox_VM
                {
                    ErrorType = DataModel.Enum.ErrorType.Error,
                    OK = true,
                    Message = "خطا در حذف رکورد",
                    Title = "حذف"
                });
                return;
            }
            _msBox.Show(new MessageBox_VM
            {
                ErrorType = DataModel.Enum.ErrorType.Sussess,
                OK = true,
                Message = isDeleted.Message,
                Title = "حذف"
            });
            GenerateDataInFormLoad();
            return;
        }

        private void AuthorData_Click(object sender, RoutedEventArgs e)
        {
            var result = AuthorsDataGrid.SelectedItem as CollectionDTOs;
            var getdata = _presenter.GetBookAuthor(result.AuthorID);
            BookAuthor_VM bookAuthor = getdata.Result as BookAuthor_VM;
            bookAuthor.IsDelete = true;
            var isDeleted = _presenter.UpdateBookAuthor(bookAuthor);
            if (!(bool)isDeleted.Result)
            {
                _msBox.Show(new MessageBox_VM
                {
                    ErrorType = DataModel.Enum.ErrorType.Error,
                    OK = true,
                    Message = "خطا در حذف رکورد",
                    Title = "حذف"
                });
                return;
            }
            _msBox.Show(new MessageBox_VM
            {
                ErrorType = DataModel.Enum.ErrorType.Sussess,
                OK = true,
                Message = isDeleted.Message,
                Title = "حذف"
            });
            GenerateDataInFormLoad();
            return;
        }

        private void GenreData_Click(object sender, RoutedEventArgs e)
        {
            var result = GenresDataGrid.SelectedItem as CollectionDTOs;
            var getdata = _presenter.GetBookGenre(result.GenreID);
            BookGenre_VM bookGenre = getdata.Result as BookGenre_VM;
            bookGenre.IsDelete = true;
            var isDeleted = _presenter.UpdateBookGenre(bookGenre);
            if (!(bool)isDeleted.Result)
            {
                _msBox.Show(new MessageBox_VM
                {
                    ErrorType = DataModel.Enum.ErrorType.Error,
                    OK = true,
                    Message = "خطا در حذف رکورد",
                    Title = "حذف"
                });
                return;
            }
            _msBox.Show(new MessageBox_VM
            {
                ErrorType = DataModel.Enum.ErrorType.Sussess,
                OK = true,
                Message = isDeleted.Message,
                Title = "حذف"
            });
            GenerateDataInFormLoad();
            return;
        }
        int rowNumber;
        public void BookNameSearch()
        {
            rowNumber = 0;
            var result = _presenter.BookNameSearch(txtSearch.Text);
            List<Book_VM> books = result.Result as List<Book_VM>;
            List<BookDTO> dTOS = new List<BookDTO>();
            foreach (Book_VM book in books)
            {
                rowNumber++;
                BookDTO dTO = new BookDTO
                {
                    BookTitle = book.BookTitle,
                    Price = book.Price,
                    Quantity = book.Quantity,
                    RowNumber = rowNumber,
                    Publisher = _presenter.GetPublisherName(book.Publisher).Result.ToString(),
                    BookGenre = _presenter.GetGenreName(book.BookGenre).Result.ToString(),
                    Author = _presenter.GetAuthorName(book.Author).Result.ToString(),
                    WriteDate = book.WriteDate.ToShortDateString(),
                    BookId = book.Id
                };
                dTOS.Add(dTO);
            }
            grdBookNameSearch.ItemsSource = null;
            grdBookNameSearch.ItemsSource = dTOS;


        }

        public void AuthorNameSearch()
        {
            rowNumber = 0;
            var result = _presenter.AuthorNameSearch(txtSearch.Text);
            List<BookAuthor_VM> authors = result.Result as List<BookAuthor_VM>;
            List<CollectionDTOs> dTOS = new List<CollectionDTOs>();
            foreach (var item in authors)
            {
                rowNumber++;
                CollectionDTOs dTO = new CollectionDTOs
                {
                    Author = item.Name,
                    AuthorID = item.Id,
                    RowNumber = rowNumber
                };
                dTOS.Add(dTO);
            }
            grdAuthorNameSearch.ItemsSource = null;
            grdAuthorNameSearch.ItemsSource = dTOS;


        }

        public void PublisherNameSearch()
        {
            rowNumber = 0;
            var result = _presenter.PublisherNameSearch(txtSearch.Text);
            List<BookPublisher_VM> authors = result.Result as List<BookPublisher_VM>;
            List<CollectionDTOs> dTOS = new List<CollectionDTOs>();
            foreach (var item in authors)
            {
                rowNumber++;
                CollectionDTOs dTO = new CollectionDTOs
                {
                    Publisher = item.PublisherName,
                    PublisherID = item.Id,
                    RowNumber = rowNumber
                };
                dTOS.Add(dTO);
            }
            grdPublisherNameSearch.ItemsSource = null;
            grdPublisherNameSearch.ItemsSource = dTOS;


        }

        public void GenreNameSearch()
        {
            rowNumber = 0;
            var result = _presenter.GenreNameSearch(txtSearch.Text);
            List<BookGenre_VM> authors = result.Result as List<BookGenre_VM>;
            List<CollectionDTOs> dTOS = new List<CollectionDTOs>();
            foreach (var item in authors)
            {
                rowNumber++;
                CollectionDTOs dTO = new CollectionDTOs
                {
                    Genre = item.GenreName,
                    GenreID = item.Id,
                    RowNumber = rowNumber
                };
                dTOS.Add(dTO);
            }
            grdGenreNameSearch.ItemsSource = null;
            grdGenreNameSearch.ItemsSource = dTOS;


        }

        private void InitialSearchGrid()
        {
            switch (cobSearchType.SelectedIndex)
            {
                case 0:
                    BookNameSearch();
                    break;

                case 1:
                    GenreNameSearch();
                    break;

                case 2:
                    AuthorNameSearch();
                    break;

                case 3:
                    PublisherNameSearch();
                    break;

                default:
                    break;
            }
        }

        private void txtSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            InitialSearchGrid();
        }

        private void cobSearchType_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (cobSearchType.SelectedIndex)
            {
                case 0:
                    grdBookNameSearch.Visibility = Visibility.Visible;
                    grdAuthorNameSearch.Visibility = Visibility.Hidden;
                    grdGenreNameSearch.Visibility = Visibility.Hidden;
                    grdPublisherNameSearch.Visibility = Visibility.Hidden;
                    break;

                case 1:
                    grdBookNameSearch.Visibility = Visibility.Hidden;
                    grdAuthorNameSearch.Visibility = Visibility.Hidden;
                    grdGenreNameSearch.Visibility = Visibility.Visible;
                    grdPublisherNameSearch.Visibility = Visibility.Hidden;
                    break;

                case 2:
                    grdBookNameSearch.Visibility = Visibility.Hidden;
                    grdAuthorNameSearch.Visibility = Visibility.Visible;
                    grdGenreNameSearch.Visibility = Visibility.Hidden;
                    grdPublisherNameSearch.Visibility = Visibility.Hidden;
                    break;

                case 3:
                    grdBookNameSearch.Visibility = Visibility.Hidden;
                    grdAuthorNameSearch.Visibility = Visibility.Hidden;
                    grdGenreNameSearch.Visibility = Visibility.Hidden;
                    grdPublisherNameSearch.Visibility = Visibility.Visible;
                    break;

                default:
                    grdBookNameSearch.Visibility = Visibility.Hidden;
                    grdAuthorNameSearch.Visibility = Visibility.Hidden;
                    grdGenreNameSearch.Visibility = Visibility.Hidden;
                    grdPublisherNameSearch.Visibility = Visibility.Hidden;
                    break;
            }
        }
    }
}
