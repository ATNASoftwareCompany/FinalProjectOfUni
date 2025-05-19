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
        public List<BookPublisher_VM> GetAllPublishers()
        {
            return appDb.BookPublishers.Where(x => x.IsDelete == false).ToList();
        }
    }
}
