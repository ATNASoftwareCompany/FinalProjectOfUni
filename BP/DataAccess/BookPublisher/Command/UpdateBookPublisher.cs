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
        public bool UpdateBookPublisher(BookPublisher_VM inputModel)
        {
            var result = GetBookPublisher(inputModel);
            if (result == null)
            {
                return false;
            }
            result.UpdateDate = DateTime.Now;
            result.IsDelete = inputModel.IsDelete;
            result.InsertDate = inputModel.InsertDate;
            result.Status = inputModel.Status;
            result.PublisherName = inputModel.PublisherName;
            SaveChanges();
            return true;
        }
    }
}
