using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.BookAuthor
{
    public partial class BookAuthor_DL
    {
        AppDb appDb;
        public BookAuthor_DL()
        {
            appDb = new AppDb();
        }
        public void SaveChanges()
        { appDb.SaveChanges(); }
    }
}
