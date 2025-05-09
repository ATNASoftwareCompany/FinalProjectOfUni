using DataAccess.BookAuthor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.BookAuthor
{
    public partial class BookAuthor_BL
    {
        BookAuthor_DL bookAuthor_DL;
        public BookAuthor_BL()
        {
            bookAuthor_DL = new BookAuthor_DL();
        }
    }
}
