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
        public BaseResult_VM InsertBookGenre(BookGenre_VM inputModel)
        {
            var result = bookGenre_DL.InsertBookGenre(inputModel);
            if (result == -1)
            {
                return new BaseResult_VM(null, -1, "خطا در درج ژانر", DataModel.Enum.ErrorType.Error);
            }
            return new BaseResult_VM(result, 0, "عملیات با موفقیت انجام شد", DataModel.Enum.ErrorType.Sussess);
        }
    }
}
