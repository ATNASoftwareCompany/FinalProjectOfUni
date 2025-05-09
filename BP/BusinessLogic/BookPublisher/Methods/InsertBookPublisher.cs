using DataModel.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.BookPublisher
{
    public partial class BookPublisher_BL
    {
        public BaseResult_VM InsertBookPublisher(BookPublisher_VM inputModel)
        {
            var result = BookPublisher_DL.InsertBookPublisher(inputModel);
            if (result == -1)
            {
                return new BaseResult_VM(null, -1, "خطا در درج ناشر", DataModel.Enum.ErrorType.Error);
            }

            return new BaseResult_VM(result, 0, "عملیات با موفقیت انجام شد", DataModel.Enum.ErrorType.Sussess);
        }
    }
}
