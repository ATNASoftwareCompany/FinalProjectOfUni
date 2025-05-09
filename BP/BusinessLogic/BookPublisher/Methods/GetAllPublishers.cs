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
        public BaseResult_VM GetAllPublishers(BookPublisher_VM inputModel)
        {
            return new BaseResult_VM(BookPublisher_DL.GetAllPublishers(), 0, "عملیات با موفقیت انجام شد", DataModel.Enum.ErrorType.Sussess);
        }
    }
}
