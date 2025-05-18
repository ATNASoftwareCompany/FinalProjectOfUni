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
        public BookGenre_VM GetBookGenre(BookGenre_VM inputModel)
        {
            return appDb.BookGenres.Where(x => x.Id == inputModel.Id).FirstOrDefault();
        }
    }
}
