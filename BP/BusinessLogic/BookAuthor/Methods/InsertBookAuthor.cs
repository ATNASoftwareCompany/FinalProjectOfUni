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
        public BaseResult_VM InsertBookAuthor(BookAuthor_VM inputModel)
        {
            var result = bookAuthor_DL.InsertBookAuthor(inputModel);
            if (result == -1)
            {
                return new BaseResult_VM(null, -1, "خطا در درج نویسنده", DataModel.Enum.ErrorType.Error);
            }
            return new BaseResult_VM(result, 0, "عملیات با موفقیت انجام شد", DataModel.Enum.ErrorType.Sussess);
        }
    }
}
