using DataModel.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.BookGenre
{
    public partial class BookGenre_DL
    {
        public int InsertBookGenre(BookGenre_VM inputModel)
        {
			try
			{
				BookGenre_VM bookGenre = new BookGenre_VM
				{
					Books = inputModel.Books,
					GenreName = inputModel.GenreName,
					InsertDate = DateTime.Now,
					IsDelete = false,
					Status = inputModel.Status,
					UpdateDate = null,
				};

				var result = appDb.BookGenres.Add(bookGenre);
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
