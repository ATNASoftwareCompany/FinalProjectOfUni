using DataModel.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.BookGenre
{
    public partial class BookGenre_DL
    {
        public List<BookGenre_VM> GetAllBookGenre()
        {
            return appDb.BookGenres.ToList();
        }
    }
}
