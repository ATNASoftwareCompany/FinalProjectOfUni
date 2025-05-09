using DataAccess.Book;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Book
{
    public partial class Book_BL
    {
        Book_DL Book_DL;
        public Book_BL()
        {
            Book_DL = new Book_DL();
        }
    }
}
