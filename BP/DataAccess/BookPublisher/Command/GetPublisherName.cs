using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.BookPublisher
{
    public partial class BookPublisher_DL
    {
        public string GetPublisherName(int id)
        {
            return appDb.BookPublishers.Where(x => x.Id == id).Select(x => x.PublisherName).FirstOrDefault();
        }
    }
}
