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
        public List<Book_VM> BookNameSearch(string text)
        {
            return appDb.Books.Where(x => x.BookTitle.Contains(text)).ToList();
        }
    }
}
