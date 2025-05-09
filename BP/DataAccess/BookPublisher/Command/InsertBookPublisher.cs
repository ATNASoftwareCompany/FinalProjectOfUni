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
        public int InsertBookPublisher(BookPublisher_VM inputModel)
        {
            try
            {
                BookPublisher_VM bookPublisher = new BookPublisher_VM
                {
                    Books = inputModel.Books,
                    InsertDate = DateTime.Now,
                    IsDelete = inputModel.IsDelete,
                    PublisherName = inputModel.PublisherName,
                    Status = inputModel.Status,
                    UpdateDate = null,
                };

                var result = appDb.BookPublishers.Add(bookPublisher);
                SaveChanges();

                return result.Id;
            }
            catch (Exception)
            {
                return -1;
            }
        }
    }
}
