using DataModel.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalApp.Book.DTOs
{
    public class BookDTO
    {
        public int RowNumber { get; set; }
        public string BookTitle { get; set; }
        public string BookGenre { get; set; }
        public int Quantity { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public double Price { get; set; }
        public string WriteDate { get; set; }
    }
}
