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
        public BaseResult_VM GetActionsCount(int nothing)
        {
            return new BaseResult_VM(Action_DL.GetCountOfActions(),0,"",DataModel.Enum.ErrorType.Sussess);
        }
    }
}
