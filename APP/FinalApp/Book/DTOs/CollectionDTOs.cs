using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalApp.Book.DTOs
{
    public class CollectionDTOs
    {
        public int RowNumber { get; set; }
        public int BookID { get; set; }
        public string BookTitle { get; set; }
        public int GenreID { get; set; }
        public string Genre { get; set; }
        public int AuthorID { get; set; }
        public string Author { get; set; }
        public int PublisherID { get; set; }
        public string Publisher { get; set; }
    }
}
