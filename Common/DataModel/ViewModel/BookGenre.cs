using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel.ViewModel
{
    public class BookGenre : Base_VM
    {
        public string GenreName { get; set; }
        public List<Book_VM> Books { get; set; } = new List<Book_VM>();
    }
}
