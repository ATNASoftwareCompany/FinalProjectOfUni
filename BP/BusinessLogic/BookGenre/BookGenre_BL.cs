using DataAccess.BookGenre;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.BookGenre
{
    public partial class BookGenre_BL
    {
        BookGenre_DL bookGenre_DL;
        public BookGenre_BL()
        {
            bookGenre_DL = new BookGenre_DL();
        }
    }
}
