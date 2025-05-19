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
        public bool UpdateBookAuthor(BookAuthor_VM inputModel)
        {
            var result = GetBookAuthor(inputModel);
            if (result == null)
            {
                return false;
            }
            result.UpdateDate = DateTime.Now;
            result.IsDelete = inputModel.IsDelete;
            result.InsertDate = inputModel.InsertDate;
            result.Status = inputModel.Status;
            result.Name = inputModel.Name;
            SaveChanges();
            return true;
        }
    }
}
