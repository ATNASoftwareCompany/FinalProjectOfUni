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
        public BaseResult_VM UpdateAccessList(List<Access_VM> inputModel)
        {
            return new BaseResult_VM(Access_DL.UpdateAccessList(inputModel), 0, "عملیات با موفقیت انجام شد", DataModel.Enum.ErrorType.Sussess);
        }
    }
}
