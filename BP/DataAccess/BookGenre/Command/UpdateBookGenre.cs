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
        public bool UpdateBookGenre(BookGenre_VM inputModel)
        {
            var result = GetBookGenre(inputModel);
            if (result == null)
            {
                return false;
            }
            result.UpdateDate = DateTime.Now;
            result.IsDelete = inputModel.IsDelete;
            result.InsertDate = inputModel.InsertDate;
            result.Status = inputModel.Status;
            result.GenreName = inputModel.GenreName;
            SaveChanges();
            return true;
        }
    }
}
