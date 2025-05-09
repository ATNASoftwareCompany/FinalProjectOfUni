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
        public BaseResult_VM InsertBook(Book_VM inputModel)
        {
            var result = Book_DL.InsertBook(inputModel);
            if (result == -1)
            {
                return new BaseResult_VM(null , -1 , "خطا در درج اطلاعات کتاب" , DataModel.Enum.ErrorType.Error);
            }
            return new BaseResult_VM(result, 0, "عملیات با موفقیت انجام شد", DataModel.Enum.ErrorType.Sussess);
        }
    }
}
