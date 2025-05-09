using DataAccess;
using DataModel.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.BookAuthor
{
    public partial class BookAuthor_BL
    {
        public BaseResult_VM GetAllBookAuthor(BookAuthor_VM inputModel)
        {
            return new BaseResult_VM(bookAuthor_DL.GetAllBookAuthor(), 0, "عملیات با موفقیت انجام شد", DataModel.Enum.ErrorType.Sussess);
        }
    }
}
