using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.BookAuthor
{
    public partial class BookAuthor_DL
    {
        public string GetAuthorName(int id)
        {
            return appDb.BookAuthors.Where(x => x.Id == id).Select(x => x.Name).FirstOrDefault();
        }
    }
}
