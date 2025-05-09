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
    /// Interaction logic for BookCollection.xaml
    /// </summary>
    public partial class BookCollection : Window
    {
        public BookCollection()
        {
            InitializeComponent();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Collections.Clear();
        }
        public List<CollectionDTOs> Collections = new List<CollectionDTOs>();

        private void dtgCollection_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            CollectionDTOs collectionDT = sender as CollectionDTOs;
            Collections.Add(collectionDT);
        }

        
    }
}
