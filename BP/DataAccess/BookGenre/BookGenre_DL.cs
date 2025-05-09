using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.BookGenre
{
    public partial class BookGenre_DL
    {
        AppDb appDb;
        public BookGenre_DL()
        {
            appDb = new AppDb();
        }
        public void SaveChanges()
        { appDb.SaveChanges(); }
    }
}
