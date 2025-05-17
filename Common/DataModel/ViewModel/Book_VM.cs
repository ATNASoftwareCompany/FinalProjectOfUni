using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel.ViewModel
{
    public class Book_VM:Base_VM
    {
        public string BookTitle { get; set; }
        public string Summary { get; set; }
        public int BookGenre { get; set; } = new BookGenre_VM().Id;
        public int Quantity { get; set; }
        public int Author { get; set; } = new BookAuthor_VM().Id;
        public int Publisher { get; set; } = new BookPublisher_VM().Id;
        public double Price { get; set; }
        public bool HasDiscount { get; set; }
        public int DiscountType { get; set; }
        public int DiscountAmount { get; set; }
        public DateTime WriteDate { get; set; }
    }
}
