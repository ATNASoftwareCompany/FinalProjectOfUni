using DataAccess.BookPublisher;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.BookPublisher
{
    public partial class BookPublisher_BL
    {
        BookPublisher_DL BookPublisher_DL;
        public BookPublisher_BL()
        {
            BookPublisher_DL = new BookPublisher_DL();
        }
    }
}
