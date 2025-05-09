using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.BookPublisher
{
    public partial class BookPublisher_DL
    {
        AppDb appDb;
        public BookPublisher_DL()
        {
            appDb = new AppDb();
        }
        
        public void SaveChanges()
        { appDb.SaveChanges(); }
    }
}
