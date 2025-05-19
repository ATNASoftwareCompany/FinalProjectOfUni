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
        public List<BookAuthor_VM> GetAllBookAuthor()
        {
            return appDb.BookAuthors.Where(x => x.IsDelete == false).ToList();
        }
    }
}
