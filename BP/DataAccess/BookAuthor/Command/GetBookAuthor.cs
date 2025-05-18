using DataModel.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.BookAuthor
{
    public partial class BookAuthor_DL
    {
        public BookAuthor_VM GetBookAuthor(BookAuthor_VM inputModel)
        {
            return appDb.BookAuthors.Where(x => x.Id == inputModel.Id).FirstOrDefault();
        }
    }
}
