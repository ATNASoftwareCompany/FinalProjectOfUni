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
        public Book_VM GetBook(int id)
        {
            return appDb.Books.Where(x =>x.Id == id).FirstOrDefault();
        }
    }
}
