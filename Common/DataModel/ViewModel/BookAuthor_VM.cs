using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel.ViewModel
{
    public class BookAuthor_VM : Base_VM
    {
        public string Name { get; set; }
        public List<Book_VM> Books { get; set; } = new List<Book_VM>();
    }
}
