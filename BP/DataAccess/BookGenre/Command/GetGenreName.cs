using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.BookGenre
{
    public partial class BookGenre_DL
    {
        public string GetGenreName(int id)
        {
            return appDb.BookGenres.Where(x => x.Id == id).Select(x => x.GenreName).FirstOrDefault();
        }
    }
}
