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
        public BookPublisher_VM GetBookPublisher(BookPublisher_VM inputModel)
        {
            return appDb.BookPublishers.Where(x => x.Id == inputModel.Id).FirstOrDefault();
        }
    }
}
