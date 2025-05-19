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
        public BaseResult_VM UpdateBook(Book_VM book)
        {
            var result = Book_DL.UpdateBook(book);
            if (!result)
            {
                return new BaseResult_VM(null, 1, "خطا در بروزرسانی اطلاعات", DataModel.Enum.ErrorType.Error);
            }
            return new BaseResult_VM(true,0, "عملیات با موفقیت انجام شد", DataModel.Enum.ErrorType.Sussess);
        }
    }
}
