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

        private void btnAddNewBook_Click(object sender, RoutedEventArgs e)
        {
            AddNewBook addNewBook = new AddNewBook();
            addNewBook.ShowDialog();
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

        private void Image_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.Close();
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

        private void GenerateDataInFormLoad()
        {
            var result = _presenter.GetAllBookGenre(new BookGenre_VM { });
            List<CollectionDTOs> GenreList = new List<CollectionDTOs>();
            int rowNumber = 0;
            foreach (var item in result.Result as List<BookGenre_VM>)
            {
                rowNumber++;
                CollectionDTOs collection = new CollectionDTOs
                {
                    Genre = item.GenreName,
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

            AuthorsDataGrid.ItemsSource = null;
            AuthorsDataGrid.ItemsSource = AuthorList;

            GenresDataGrid.ItemsSource = null;
            GenresDataGrid.ItemsSource = GenreList;
        }
    }
}
