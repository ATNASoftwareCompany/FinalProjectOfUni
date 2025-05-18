using DataAccess.BookAuthor;
using DataModel.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.BookGenre
{
    public partial class BookGenre_BL
    {
        public BaseResult_VM GetGenreName(int id)
        {
            return new BaseResult_VM(bookGenre_DL.GetGenreName(id), 0, "عملیات با موفقیت انجام شد", DataModel.Enum.ErrorType.Sussess);
        }
    }
}
