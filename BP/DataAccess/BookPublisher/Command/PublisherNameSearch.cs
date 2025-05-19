using DataModel.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.BookPublisher
{
    public partial class BookPublisher_DL
    {
        public List<BookPublisher_VM> PublisherNameSearch(string text)
        {
            return appDb.BookPublishers.Where(x => x.PublisherName.Contains(text)).ToList();
        }
    }
}
