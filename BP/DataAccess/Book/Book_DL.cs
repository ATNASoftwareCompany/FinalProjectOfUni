using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Book
{
    public partial class Book_DL
    {
        AppDb appDb;
        public Book_DL()
        {
            appDb = new AppDb();
        }

        public void SaveChanges()
        {
            appDb.SaveChanges();
        }
    }
}
