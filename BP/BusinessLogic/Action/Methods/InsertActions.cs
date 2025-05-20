using DataModel.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Action
{
    public partial class Action_BL
    {
        public BaseResult_VM InsertActions(List<Action_VM> inputModel)
        {
            var result = Action_DL.InsertAction(inputModel);
            if (result != 0)
            {
                return new BaseResult_VM(null, -1, "خطا در درج اکش ها", DataModel.Enum.ErrorType.Error);
            }
            return new BaseResult_VM(null, 0, "عملیات با موفقیت انجام شد", DataModel.Enum.ErrorType.Sussess);
        }
    }
}
