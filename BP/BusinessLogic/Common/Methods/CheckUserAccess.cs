using DataAccess.Access;
using DataModel.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public partial class Common_BL
    {
        public BaseResult_VM CheckUserAccess(Access_VM inputModel)
        {
            var result = new Access_DL().CheckAccess(inputModel);
            if (!result)
            {
                return new BaseResult_VM(null, 1, "شما به این قسمت دسترسی ندارید", DataModel.Enum.ErrorType.Error);
            }
            return new BaseResult_VM(result, 0, "دسترسی چک شد", DataModel.Enum.ErrorType.Sussess);
        }
    }
}
