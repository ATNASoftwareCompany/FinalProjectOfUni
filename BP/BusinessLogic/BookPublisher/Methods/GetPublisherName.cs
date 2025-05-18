using DataAccess.BookGenre;
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
        public BaseResult_VM GetPublisherName(int id)
        {
            return new BaseResult_VM(BookPublisher_DL.GetPublisherName(id), 0, "عملیات با موفقیت انجام شد", DataModel.Enum.ErrorType.Sussess);
        }
    }
}
