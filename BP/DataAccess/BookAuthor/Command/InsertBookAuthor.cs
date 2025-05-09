using DataModel.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.BookAuthor
{
    public partial class BookAuthor_DL
    {
        public int InsertBookAuthor(BookAuthor_VM inputModel)
        {
			try
			{
                BookAuthor_VM bookAuthor = new BookAuthor_VM
                {
                    Books = inputModel.Books,
                    InsertDate = DateTime.Now,
                    IsDelete = false,
                    Name = inputModel.Name,
                    Status = inputModel.Status,
                    UpdateDate = null,
                };

                var result = appDb.BookAuthors.Add(bookAuthor);
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
