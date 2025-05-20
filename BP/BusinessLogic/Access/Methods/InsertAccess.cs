using DataModel.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Access
{
    public partial class Access_BL
    {
        public BaseResult_VM InsertAccess(List<Access_VM> inputModel)
        {
            return new BaseResult_VM(null, Access_DL.InsertAccess(inputModel), "عملیات با موفقیت انجام شد", DataModel.Enum.ErrorType.Sussess);
        }
    }
}
