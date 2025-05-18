using DataModel.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Book
{
    public partial class Book_DL
    {
        public List<Book_VM> GetBooksListForShow()
        {
            return appDb.Books.ToList();
        }
    }
}
