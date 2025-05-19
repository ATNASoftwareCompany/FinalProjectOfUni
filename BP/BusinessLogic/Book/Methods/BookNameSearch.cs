using DataModel.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Book
{
    public partial class Book_BL
    {
        public BaseResult_VM BookNameSearch(string text)
        {
            return new BaseResult_VM(Book_DL.BookNameSearch(text),0,"عملیات با موفقیت انجام شد",DataModel.Enum.ErrorType.Sussess);
        }
    }
}
